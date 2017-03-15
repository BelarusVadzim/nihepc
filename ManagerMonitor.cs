using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace nihe_computers2
{
    public class ManagerMonitor
    {
        public ManagerMonitor(DS_NiheComputers DS)
        {
            this.DS = DS;
        }

        public event MonitorAddDelegate MonitorAddEvent;
        public event MonitorDelegate MonitorInfo;
        public event ManagerChangeStringValueDelegate ChangeStringValueEvent;
        public event MoveDelegate MoveEvent;
        public event ManagerChangeListValueDelegate ChangeListValueEvent;
        public event ManagerChangeStringValueDelegate SimpleEditEvent;
        private DS_NiheComputers DS = null;

        public void Add()
        {
            DS_NiheComputers.MonitorRow mr = null;
            if (MonitorAddEvent != null)
            {
                DialogMonitorAdd D = new DialogMonitorAdd();
                MonitorAddEvent(this, D);
                if (D.Changed)
                {
                    mr = DS.Monitor.NewMonitorRow();
                    mr.DepartmentID = D.DepartmentID;
                    mr.MonitorModelID = D.MonitorModelID;
                    mr.GUID = Guid.NewGuid().ToString();
                    mr.Number = D.Number;
                    mr.Room = D.Room;
                    mr.Deleted = false;
                    mr.PurchaseDate = D.PurchaseDate;
                    mr.WarantyDate = D.PurchaseDate.AddYears((int)D.WarantyDate);
                    DS.Monitor.AddMonitorRow(mr);
                    DS_NiheComputers.MonitorEventRow mer = DS.MonitorEvent.NewMonitorEventRow();
                    mer.MonitorGUID = mr.GUID;
                    mer.Date = D.PurchaseDate;
                    mer.ExtendedInfo = D.ExtendedInfo;
                    //mer.MonitorText = Dialog.
                    mer.Info = "Покупка монитора";
                    mer.EventName = "Создание монитора";
                    DS.MonitorEvent.AddMonitorEventRow(mer);
                    DS.AcceptChanges();
                }
                D = null;
            }

        }  

        public void ChangeNumber(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = monitor.Number;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeNumber(monitor, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            monitor = null;
        }
        public void ChangeNumber(Monitor monitor, string NewNumber, DateTime Date, string ExtendInfo)
        {
            if (monitor.Number != NewNumber)
            {
                monitor.Number = NewNumber;
                WriteEvent("Изменение инвентарника", Date, monitor, ExtendInfo);
            }
        }
        public void ChangeNumber(string MonitorGuid, string NewNumber, DateTime Date, string ExtendedInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGuid);
            ChangeNumber(monitor, NewNumber, Date, ExtendedInfo);
        }

        public void ChangeRoom(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);
            
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = monitor.Room;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeRoom(monitor, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            monitor = null;
        }
        public void ChangeRoom(string MonitorGuid, string NewRoom, DateTime Date, string ExtendInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGuid);
            ChangeRoom(monitor, NewRoom, Date, ExtendInfo);
        }
        public void ChangeRoom(Monitor monitor, string NewRoom, DateTime Date, string ExtendInfo)
        {
            if (monitor.Room != NewRoom)
            {
                monitor.Room = NewRoom;
                WriteEvent("Изменение кабинета компьютера", Date, monitor, ExtendInfo);
            }
        }

        public void ChangeMonitorModel(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeMonitorModel);
            D.ValuesList = DS.MonitorModel.Select();
            D.StartValue = monitor.MonitorModelID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                    ChangeMonitorModel(monitor.GUID, D.EndValue, D.Date, D.ExtendedInfo);
            }
            D = null;
            monitor = null;
        }
        public void ChangeMonitorModel(string MonitorGuid, int NewModelID, DateTime Date, string ExtendedInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGuid);
            ChangeMonitorModel(monitor, NewModelID, Date, ExtendedInfo);
        }
        public void ChangeMonitorModel(Monitor monitor, int NewModelID, DateTime Date, string ExtendInfo)
        {
            if (monitor.MonitorModelID != NewModelID)
            {
                monitor.MonitorModelID = NewModelID;
                WriteEvent("Изменение модели", Date, monitor, ExtendInfo);
            }
        }

        public void ChangeDepartment(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeDepartment);
            D.ValuesList = DS.Department.Select();
            D.StartValue = monitor.DepartmentID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                    ChangeDepartment(monitor, D.EndValue, D.Date, D.ExtendedInfo);
            }
            D = null;
            monitor = null;
        }
        public void ChangeDepartment(string MonitorGuid, int NewDepartmentID, DateTime Date, string ExtendedInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGuid);
            ChangeDepartment(monitor, NewDepartmentID, Date, ExtendedInfo);
        }
        public void ChangeDepartment(Monitor monitor, int NewDepartmentID, DateTime Date, string ExtendInfo)
        {
            if (monitor.DepartmentID != NewDepartmentID)
            {
                monitor.DepartmentID = NewDepartmentID;
                WriteEvent("Изменение отдела компьютера", Date, monitor, ExtendInfo);
            }
        }

        public void ShowInfo(BindingSource BS, Boolean ShowDelButton)
        {
            if (MonitorInfo != null)
            {
                int MonitorID = GetidCurrentMonitor(BS);
                DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
                Monitor monitor = new Monitor(DS, mr);
                DialogMonitor D = new DialogMonitor(monitor);
                D.ShowDelButton = ShowDelButton;
                MonitorInfo(this, D);
            }
        }
       
        public void Remove(DialogMonitor D)
        {
            DisconectComputer(D.monitor, D.Date, D.ExtendedInfo);
            D.monitor.Remove();
            WriteEvent("Списание монитора", D);
        }

        public void Move(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);
            DialogMove D = new DialogMove(monitor);
            if (MoveEvent != null)
            {
                MoveEvent(this, D);
                if (D.Changed)
                {
                    if (monitor.Room != D.Room)
                        DisconectComputer(monitor, D.Date, D.ExtendedInfo);
                    monitor.DepartmentID = D.DepartmentID;
                    monitor.Room = D.Room;
                    WriteEvent("Перемещение монитора", D.Date, monitor, D.ExtendedInfo);
                }
            }
            D = null;
            monitor = null;
        }

        public void ChangeComputer(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChahgeComputer);

            foreach (DS_NiheComputers.CompRow r in DS.Comp)
            {
                Console.Write(r.Room);
                Console.Write("  ");
                Console.WriteLine(r.MonitorGUID);
            }

            D.ValuesList = DS.Comp.Select(string.Format("room = '{0}' and monitorGuid = ''", monitor.Room));
            if(mr.CompRow != null)
                D.StartValue = mr.CompRow.ID;
            else
                D.StartValue = 0;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                    ChangeComputer(monitor.GUID, D.EndValue, D.Date, D.ExtendedInfo);
            }
            D = null;
            monitor = null;
        }
        public void ChangeComputer(string MonitorGuid, string NewComputerGuid, DateTime Date, string ExtendedInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGuid);
            string oldCompGuid = null; 
            if (monitor != null && monitor.ComputerGuid != NewComputerGuid)
            {
                oldCompGuid = monitor.ComputerGuid;
                ManagerMonitor MM = new ManagerMonitor(DS);
                MM.DisconectComputer(MonitorGuid, Date, ExtendedInfo);
                if (NewComputerGuid != "")
                {
                    Computer comp = Computer.FindByGUID(DS, NewComputerGuid);
                    ManagerComputer MC = new ManagerComputer(DS);
                    if (comp != null && comp.MonitorGUID != null && comp.MonitorGUID != "") //Проверяем есть ли у подключаемого системника моник и отключаем его еси есть
                    {
                        MC.DisconectMonitor(NewComputerGuid, Date, ExtendedInfo); //Отключаем новый системник от монитора
                        MC.ChangeMonitor(comp, MonitorGuid, Date, ExtendedInfo);
                    }
                    else if (comp.MonitorGUID == "" || comp.MonitorGUID == null)// Если моника нет, то устанавливаем новый системник
                        MC.SetMonitor(comp.GUID, monitor.GUID, Date, ExtendedInfo);
                    
                }
                monitor.ComputerGuid = NewComputerGuid;
                WriteEvent("Подключение компьютера", Date, monitor, ExtendedInfo);
            }
        }
        public void ChangeComputer(string MonitorGuid, int NewCompID, DateTime Date, string ExtendedInfo)
        {
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(NewCompID);
            ChangeComputer(MonitorGuid, cr.GUID, Date, ExtendedInfo);
        }



        public void DisconectComputer(string MonitorGUID, DateTime Date, string ExtendedInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGUID);
            DisconectComputer(monitor, Date, ExtendedInfo);
            if (monitor.ResultMessage != null)
            {
                WriteEvent("Отключение компьютера", Date, monitor, ExtendedInfo);
                monitor.ResetMessage();
            }
        }
        public void DisconectComputer(BindingSource BSTemp)
        {
            int MonitorID = GetidCurrentMonitor(BSTemp);
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(MonitorID);
            Monitor monitor = new Monitor(DS, mr);

            DialogStringValueEdit D = new DialogStringValueEdit();
            if (SimpleEditEvent != null)
                SimpleEditEvent(this, D);
            if (D.Changed)
            {
                DisconectComputer(monitor, D.Date, D.ExtendedInfo);
                WriteEvent("Отключение компьютера", D.Date, monitor, D.ExtendedInfo);
                monitor.ResetMessage();
            }

        }
        public void DisconectComputer(Monitor monitor, DateTime Date, string ExtendedInfo)
        {
            if (monitor != null)
            {
                if (monitor.ComputerGuid != null && monitor.ComputerGuid != "")
                {
                    string oldCompGuid = monitor.ComputerGuid;
                    monitor.ComputerGuid = "";
                    Computer comp = Computer.FindByGUID(DS, oldCompGuid);
                    ManagerComputer MC = new ManagerComputer(DS);
                    MC.DisconectMonitor(oldCompGuid, Date, ExtendedInfo);
                }
            }
        }


        public void SetComputer(string MonitorGuid, string NewComputerGuid, DateTime Date, string ExtendInfo)
        {
            Monitor monitor = Monitor.FindByGUID(DS, MonitorGuid);
            monitor.ComputerGuid = NewComputerGuid;
            WriteEvent("Подключение компьютера", Date, monitor, ExtendInfo);
        }

        private int GetidCurrentMonitor(BindingSource BSTemp)
        {
            DataRowView drv = BSTemp.Current as DataRowView;
            int i = (int)drv["id"];
            return i;
        }


        private void WriteEvent(string S1, DialogMonitor D)
        {
            WriteEvent(S1, D.Date, D.monitor, D.ExtendedInfo);
        }
        private void WriteEvent(string S1, DateTime D, Monitor M, string ExtendedInfo)
        {
            WriteEvent(S1, D, M.ResultMessage, M.GUID, ExtendedInfo);
        }
        private void WriteEvent(string S1, DateTime D, string Info, string MonitorGUID, string ExtendedInfo)
        {
            if (Info != "")
            {
                EventWriterMonitor ewm = new EventWriterMonitor(DS);
                ewm.GUID = MonitorGUID;
                ewm.Date = D;
                ewm.ExtendedInfo = ExtendedInfo;
                ewm.EventName = S1;
                ewm.Info = Info;
                ewm.Write();
            }
        }


        internal class EventWriterMonitor
        {
            public EventWriterMonitor(DS_NiheComputers DS)
            {
                this.DS = DS;
            }

            public EventWriterMonitor(DialogMonitor D)
            {
                this.DS = D.monitor.DS;
                this.GUID = D.monitor.GUID;
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
            }


            public string GUID { get; set; }
            public DateTime Date { get; set; }
            public string Info { get; set; }
            public string ExtendedInfo { get; set; }
            public string EventName { get; set; }
            private DS_NiheComputers DS = null;

            public void Write()
            {
                DS_NiheComputers.MonitorEventRow mer = DS.MonitorEvent.NewMonitorEventRow();
                mer.MonitorGUID = GUID;
                mer.Date = Date;
                mer.ExtendedInfo = ExtendedInfo;
                mer.Info = Info;
                mer.EventName = EventName;
                DS.MonitorEvent.AddMonitorEventRow(mer);
            }
        }

    }
}
