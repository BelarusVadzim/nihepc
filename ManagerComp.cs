using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace nihe_computers2
{
    public class ManagerComputer
    {

        public ManagerComputer(DS_NiheComputers DS)
        {
            this.DS = DS;
        }
        public event ComputerAddDelegate_new ComputerAddEvent_New;
        public event ComputerAddDelegate ComputerAddEvent;
        public event ComputerDelegate ComputerShowInfo;
        public event MoveDelegate MoveEvent;
        public event ManagerChangeStringValueDelegate ChangeStringValueEvent;
        public event ManagerChangeListValueDelegate ChangeListValueEvent;
        public event ManagerChangeStringValueDelegate SimpleEditEvent;

        private DS_NiheComputers DS = null;

        public void Add_new()
        {
            Computer comp = new Computer(DS);
            DialogComputer D = new DialogComputer(comp);
            string infoString = null;
            if (ComputerAddEvent_New != null)
            {
                ComputerAddEvent_New(this, D);
                if (D.Changed)
                {
                    comp.ComputerName = D.Comp.ComputerName;
                    comp.DepartmentID = D.Comp.DepartmentID;
                    comp.HDDID = D.Comp.HDDID;
                    comp.Number = D.Comp.Number;
                    comp.OSID = D.Comp.OSID;
                    comp.ProcessorID = D.Comp.ProcessorID;
                    comp.PurchaseDate = D.Comp.PurchaseDate;
                    comp.WarantyDate = D.Comp.WarantyDate;
                    comp.Room = D.Comp.Room;
                    comp.Username = D.Comp.Username;
                    comp.RAMID = D.Comp.RAMID;
                    infoString = comp.FullName;
                    EventWriterComp ewc = new EventWriterComp(D);
                    ewc.EventName = "Поступление компьютера";
                    ewc.Info = comp.FullName;
                    if (comp.Number != null & comp.Number != "")
                        ewc.Info = string.Format("{0}\r\nИнв. №: {1}", ewc.Info, comp.Number);
                    if (comp.Vendor != null & comp.Vendor != " ")
                        ewc.Info = string.Format("{0}\r\nПроизвод.: {1}", ewc.Info, comp.Vendor);
                    if (comp.Department != null & comp.Department != "")
                        ewc.Info = string.Format("{0}\r\nСтрукт подразд.: {1}", ewc.Info, comp.Department);
                    if (comp.ComputerName != null & comp.ComputerName != "")
                        ewc.Info = string.Format("{0}\r\nИмя комп.: {1}", ewc.Info, comp.ComputerName);
                    if (comp.Room != null & comp.Room != "")
                        ewc.Info = string.Format("{0}\r\nКабинет: {1}", ewc.Info, comp.Room);
                    if (comp.Username != null & comp.Username != "")
                        ewc.Info = string.Format("{0}\r\nИмя польз.: {1}", ewc.Info, comp.Username);
                    ewc.Write();
                }

            }
            D = null;
            comp = null;

        }


        public void Add()
        {
            
            DS_NiheComputers.CompRow cr = null;
            DialogComputerAdd D = new DialogComputerAdd();
            string infoString = null;
            if (ComputerAddEvent != null)
            {
                ComputerAddEvent(this, D);
                if (D.Changed)
                {
                    cr = DS.Comp.NewCompRow();
                    cr.Name = D.ComputerName;
                    cr.DepartmentID = D.DepartmentID;
                    cr.HDDID = D.HDD;
                    cr.Num = D.Number;
                    cr.OSID = D.OSID;
                    cr.ProcessorID = D.ProcessorID;
                    cr.PurchaseDate = D.PurchaseDate;
                    cr.WarantyDate = D.PurchaseDate.AddYears((int)D.WarantyDate);
                    cr.Room = D.Room;
                    cr.User = D.Username;
                    cr.RAMID = D.RAMID;
                    cr.GUID = D.GUID;
                    DS.Comp.AddCompRow(cr);
                    Computer comp = new Computer(DS, cr);
                    infoString = comp.FullName;
                    EventWriterComp ewc = new EventWriterComp(DS, D);
                    ewc.EventName = "Поступление компьютера";
                    ewc.Info = comp.FullName;
                    if (comp.Number != null & comp.Number != "")
                        ewc.Info = string.Format("{0}\r\nИнв. №: {1}", ewc.Info, comp.Number);
                    if (comp.Vendor != null & comp.Vendor != " ")
                        ewc.Info = string.Format("{0}\r\nПроизвод.: {1}", ewc.Info, comp.Vendor);
                    if (comp.Department != null & comp.Department != "")
                        ewc.Info = string.Format("{0}\r\nСтрукт подразд.: {1}", ewc.Info, comp.Department);
                    if (comp.ComputerName != null & comp.ComputerName != "")
                        ewc.Info = string.Format("{0}\r\nИмя комп.: {1}", ewc.Info, comp.ComputerName);
                    if (comp.Room != null & comp.Room != "")
                        ewc.Info = string.Format("{0}\r\nКабинет: {1}", ewc.Info, comp.Room);
                    if (comp.Username != null & comp.Username != "")
                        ewc.Info = string.Format("{0}\r\nИмя польз.: {1}", ewc.Info, comp.Username);
                    ewc.Write();
                    comp = null;
                }
            }
            D = null;
        }

        public void ChangeName(BindingSource BSTemp)
        {
            string s = GetGUIDCurrentComputer(BSTemp);
            Computer comp = Computer.FindByGUID(DS, s);
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = comp.ComputerName;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeName(comp, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }
        public void ChangeName(Computer comp, string NewName, DateTime Date, string ExtendInfo)
        {
            if (comp.ComputerName != NewName)
            {
                comp.ComputerName = NewName;
                WriteEvent("Изменение имени компьютера", Date, comp, ExtendInfo);
            }
        }
        public void ChangeName(string CompGuid, string NewName, DateTime Date, string ExtendedInfo)
        {
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            ChangeName(comp, NewName, Date, ExtendedInfo);
        }

        public void ChangeNumber(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = comp.Number;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeNumber(comp, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }
        public void ChangeNumber(Computer comp, string NewNumber, DateTime Date, string ExtendInfo)
        {
            if (comp.Number != NewNumber)
            {
                comp.Number = NewNumber;
                WriteEvent("Изменение инвентарника компьютера", Date, comp, ExtendInfo);
            }
        }
        public void ChangeNumber(string CompGuid, string NewNumber, DateTime Date, string ExtendedInfo)
        {
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            ChangeNumber(comp, NewNumber, Date, ExtendedInfo);
        }

        public void ChangeRoom(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = comp.Room;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeRoom(comp.GUID, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }
        public void ChangeRoom(string CompGuid, string NewRoom, DateTime Date, string ExtendInfo)
        {
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            ChangeRoom(comp, NewRoom, Date, ExtendInfo);
        }
        public void ChangeRoom(Computer comp, string NewRoom, DateTime Date, string ExtendInfo)
        {
            if (comp.Room != NewRoom)
            {
                comp.Room = NewRoom;
                WriteEvent("Изменение кабинета компьютера", Date, comp, ExtendInfo);
            }
        }

        public void ChangeUsername(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = comp.Username;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    ChangeUsername(comp, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }
        public void ChangeUsername(string CompGuid, string NewUsername, DateTime Date, string ExtendedInfo)
        {
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            ChangeUsername(comp.GUID, NewUsername, Date, ExtendedInfo);

        }
        public void ChangeUsername(Computer comp, string NewUsername, DateTime Date, string ExtendInfo)
        {
            if (comp.Username != NewUsername)
            {
                comp.Username = NewUsername;
                WriteEvent("Изменение поьзоватяеля", Date, comp, ExtendInfo);
            }
        }

        public void ChangeDepartment(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeDepartment);
            D.ValuesList = DS.Department.Select("name <> 'списан'", "Sort");
            D.StartValue = comp.DepartmentID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                    ChangeDepartment(comp.GUID, D.EndValue, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }
        public void ChangeDepartment(string CompGuid, int NewDepartmentID, DateTime Date, string ExtendedInfo)
        {
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            ChangeDepartment(comp.GUID, NewDepartmentID, Date, ExtendedInfo);
        }
        public void ChangeDepartment(Computer comp, int NewDepartmentID, DateTime Date, string ExtendInfo)
        {
            if (comp.DepartmentID != NewDepartmentID)
            {
                comp.DepartmentID = NewDepartmentID;
                WriteEvent("Изменение отдела компьютера", Date, comp, ExtendInfo);
            }
        }

        public void ChangeMonitor(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeMonitor);
            D.ValuesList = DS.Monitor.Select(string.Format("room = '{0}'", comp.Room));

            D.StartValue = comp.MonitorID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                    ChangeMonitor(comp.GUID, D.EndValue, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }
        public void ChangeMonitor(Computer comp, string NewMonitorGuid, DateTime Date, string ExtendedInfo)
        {
            string OldMonitorGUID = null; 
            if (comp != null && comp.MonitorGUID != NewMonitorGuid)
            {
                OldMonitorGUID = comp.MonitorGUID;
                ManagerComputer MC = new ManagerComputer(DS);
                MC.DisconectMonitor(comp.GUID, Date, ExtendedInfo);
                if (NewMonitorGuid != "")
                {
                    Monitor monitor = Monitor.FindByGUID(DS, NewMonitorGuid); // подключаемый монитор
                    ManagerMonitor MM = new ManagerMonitor(DS);
                    if (monitor != null && monitor.ComputerGuid != null && monitor.ComputerGuid != "") //Проверяем есть ли у подключаемого монитора системник и отключаем его если есть
                    {
                        MM.DisconectComputer(NewMonitorGuid, Date, ExtendedInfo);
                        MM.ChangeComputer(NewMonitorGuid, comp.GUID, Date, ExtendedInfo);
                    }
                    else if (monitor.ComputerGuid == "" || monitor.ComputerGuid == null)
                        MM.SetComputer(NewMonitorGuid, comp.GUID, Date, ExtendedInfo);
                }
                comp.MonitorGUID = NewMonitorGuid;
                WriteEvent("Подключение монитора", Date, comp, ExtendedInfo);
               
            }
        }
        public void ChangeMonitor(string CompGuid, int NewMonitorID, DateTime Date, string ExtendedInfo)
        {
            DS_NiheComputers.MonitorRow mr = DS.Monitor.FindByID(NewMonitorID);
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            ChangeMonitor(comp, mr.GUID, Date, ExtendedInfo);
        }

        public void SimpleEdit(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer computer = new Computer(DS, cr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            if (SimpleEditEvent != null)
                SimpleEditEvent(this, D);
            if (D.Changed)
                SimpleEdit(computer, D.Date, D.ExtendedInfo);
        }
        public void SimpleEdit(Computer comp, DateTime Date, string ExtendedInfo)
        {
            if (comp != null)
            {
                    WriteEvent("Простое событие", Date, comp, ExtendedInfo);
                    comp.ResetMessage();
            }
        }

        public void EditDescription(Computer comp, string NewDescription, DateTime Date, string ExtendInfo)
        {
            if (comp.Description != NewDescription)
            {
                comp.Description = NewDescription;
                WriteEvent("Изменение описания", Date, comp, ExtendInfo);
            }
        }
        public void EditDescription(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            D.StartText = comp.Description;
            if (ChangeStringValueEvent != null)
            {
                ChangeStringValueEvent(this, D);
                if (D.Changed)
                    EditDescription(comp, D.EndText, D.Date, D.ExtendedInfo);
            }
            D = null;
            comp = null;
        }


        public void SetMonitor(string CompGuid, string NewMonitorGuid, DateTime Date, string ExtendedInfo)
        {
            Computer comp = Computer.FindByGUID(DS, CompGuid);
            comp.MonitorGUID = NewMonitorGuid;
            WriteEvent("Подключение монитора", Date, comp, ExtendedInfo);
        }

        public void DisconectMonitor(string CompGUID, DateTime Date, string ExtendedInfo)
        {
            Computer computer = Computer.FindByGUID(DS, CompGUID);
            DisconectMonitor(computer, Date, ExtendedInfo);
            if (computer.ResultMessage != null)
            {
                WriteEvent("Отключение монитора", Date, computer, ExtendedInfo);
                computer.ResetMessage();
            }
        }
        public void DisconectMonitor(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer computer = new Computer(DS, cr);
            DialogStringValueEdit D = new DialogStringValueEdit();
            if (SimpleEditEvent != null)
                SimpleEditEvent(this, D);
            if (D.Changed)
            {
                DisconectMonitor(computer, D.Date, D.ExtendedInfo);
                WriteEvent("Отключение монитора", D.Date, computer, D.ExtendedInfo);
                computer.ResetMessage();
            }
        }
        public void DisconectMonitor(Computer comp, DateTime Date, string ExtendedInfo)
        {
            if (comp != null)
            {
                if (comp.MonitorGUID != null && comp.MonitorGUID != "")
                {
                    string MonitorGUID = comp.MonitorGUID;
                    comp.MonitorGUID = "";
                    Monitor monitor = Monitor.FindByGUID(DS, MonitorGUID);
                    ManagerMonitor MM = new ManagerMonitor(DS);
                    MM.DisconectComputer(MonitorGUID, Date, ExtendedInfo);
                }
            }
        }
       

        public void ChangeProcessor(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeProcessor);
            D.ValuesList = DS.Processor.Select();
            D.StartValue = comp.ProcessorID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                
                if (D.Changed)
                {
                    comp.ProcessorID = D.EndValue;
                    WriteEvent("Изменение процессора компьютера", D.Date, comp, D.ExtendedInfo);
                }
            }
            D = null;
            comp = null;
        }
        public void ChangeRAM(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeRAM);
            D.ValuesList = DS.RAM.Select();
            D.StartValue = comp.RAMID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                
                if (D.Changed)
                {
                    comp.RAMID = D.EndValue;
                    WriteEvent("Изменение ОЗУ компьютера", D.Date, comp, D.ExtendedInfo);
                }
            }
            D = null;
            comp = null;
        }
        public void ChangeHDD(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeHDD);
            D.ValuesList = DS.HDD.Select();
            D.StartValue = comp.HDDID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                {
                    comp.HDDID = D.EndValue;
                    WriteEvent("Изменение жесткого диска компьютера", D.Date, comp, D.ExtendedInfo);
                }
            }
            D = null;
            comp = null;
        }
        public void ChangeOS(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogListValueEdit D = new DialogListValueEdit(Operation.ChangeOS);
            D.ValuesList = DS.OS.Select();
            D.StartValue = comp.OSID;
            if (ChangeListValueEvent != null)
            {
                ChangeListValueEvent(this, D);
                if (D.Changed)
                {
                    comp.OSID = D.EndValue;
                    WriteEvent("Изменение операционной системы компьютера", D.Date, comp, D.ExtendedInfo);
                }
            }
            D = null;
            comp = null;
        }
        public void ShowInfo(BindingSource BSTemp, bool ShowDelButton)
        {
            if (ComputerShowInfo != null)
            {
                int ComputerID = GetidCurrentComputer(BSTemp);
                DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
                Computer Comp = new Computer(DS, cr);
                DialogComputer D = new DialogComputer(Comp);
                D.ShowDelButton = ShowDelButton;
                ComputerShowInfo(this, D);
            }
        }
        public void Move(BindingSource BSTemp)
        {
            int ComputerID = GetidCurrentComputer(BSTemp);
            DS_NiheComputers.CompRow cr = DS.Comp.FindByID(ComputerID);
            Computer comp = new Computer(DS, cr);
            DialogMove D = new DialogMove(comp);
            if (MoveEvent != null)
            {
                MoveEvent(this, D);
                if (D.Changed)
                {
                 if(comp.Room != D.Room)
                    DisconectMonitor(comp, D.Date, D.ExtendedInfo);
                    comp.DepartmentID = D.DepartmentID;
                    comp.Username = D.Username;
                    comp.Room = D.Room;
                    WriteEvent("Перемещение клмпьютера", D.Date, comp, D.ExtendedInfo);
                }
            }
            D = null;
            comp = null;
        }
        public void Remove(DialogComputer D)
        {
            DisconectMonitor(D.Comp, D.Date, D.ExtendedInfo);
            D.Comp.Remove();
            WriteEvent("Списание компьютера", D);
        }

        private int GetidCurrentComputer(BindingSource BS)
        {
            DataRowView drv = BS.Current as DataRowView;
            int i = (int)drv["id"];
            return i;
        }
        private String GetGUIDCurrentComputer(BindingSource BS)
        {
            DataRowView drv = BS.Current as DataRowView;
            string s = drv["GUID"] as string;
            return s;
        }

        private void WriteEvent(string S1, DialogComputer D)
        {
            WriteEvent(S1, D.Date, D.Comp, D.ExtendedInfo);
        }
        private void WriteEvent(string S1, DateTime D, Computer C, string ExtendedInfo)
        {
            WriteEvent(S1, D, C.ResultMessage, C.GUID, ExtendedInfo);
        }
        private void WriteEvent(string S1, DateTime D, string Info, string CompGUID, string ExtendedInfo)
        {
                EventWriterComp ewc = new EventWriterComp(DS);
                ewc.ComputerGUID = CompGUID;
                ewc.Date = D;
                ewc.ExtendedInfo = ExtendedInfo;
                ewc.EventName = S1;
                if (Info != null)
                     ewc.Info = Info;
                else
                    ewc.Info = "Простое событие";
                ewc.Write();
        }

        internal class EventWriterComp
        {
            public EventWriterComp(DS_NiheComputers DS)
            {
                this.DS = DS;
            }

            public EventWriterComp(DialogComputer D)
            {
                this.DS = D.Comp.DS;
                this.ComputerGUID = D.Comp.GUID;
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
            }

            public EventWriterComp(DS_NiheComputers DS, DialogComputerAdd D)
            {
                this.DS = DS;
                this.ComputerGUID = D.GUID;
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
            }


            public string ComputerGUID { get; set; }
            public DateTime Date { get; set; }
            public string Info { get; set; }
            public string ExtendedInfo { get; set; }
            public string EventName { get; set; }
            private DS_NiheComputers DS = null;

            public void Write()
            {
                DS_NiheComputers.EventCompRow ecr = DS.EventComp.NewEventCompRow();
                ecr.CompGUID = ComputerGUID;
                ecr.Date = Date;
                ecr.ExtendedInfo = ExtendedInfo;
                ecr.Info = Info;
                ecr.EventName = EventName;
                DS.EventComp.AddEventCompRow(ecr);
            }
        }
    }
}
