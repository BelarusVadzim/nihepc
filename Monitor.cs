using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace nihe_computers2
{
    public class Monitor
    {
        public Monitor(DS_NiheComputers DS, DS_NiheComputers.MonitorRow MonitorRow)
        {
            this.DS = DS;
            this.MonitorRow = MonitorRow;
        }
        public Monitor(DS_NiheComputers DS)
        {
            this.DS = DS;
            this.MonitorRow = DS.Monitor.NewMonitorRow();
            this.MonitorRow.GUID = Guid.NewGuid().ToString();
            this.DS.Monitor.AddMonitorRow(this.MonitorRow);
        }

        private ChangeStringValueEventArgs ArgS = null;
        private ChangeDateValueEventArgs ArgD = null;

        [Browsable(false)] 
        public string ResultMessage { get; private set; }
        [Browsable(false)] 
        public DS_NiheComputers DS { get; private set; }
        [Browsable(false)] 
        public DS_NiheComputers.MonitorRow MonitorRow { get; private set; }

        [Browsable(false)] 
        public int ID
        {
            get { return MonitorRow.ID; }
        }

        [Category("РИВШ")]
        [DisplayName("Пользователь")]
        [ReadOnly(true)]
        public string Username
        {
            get {
                if (MonitorRow.CompRow != null)
                    return MonitorRow.CompRow.User;
                else
                    return null;
            }
        }

        [Browsable(false)] 
        public string GUID
        {
            get { return MonitorRow.GUID; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = MonitorRow.GUID;
                ArgS.EndValue = value;
                MonitorRow.GUID = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Guid", ArgS);
                    //if (GuidChanged != null)
                    //    GuidChanged(this, ArgS);
                }
            }
        }

        [Browsable(false)] 
        public int DepartmentID
        {
            get { return MonitorRow.DepartmentID; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                if (MonitorRow.DepartmentRow != null)
                    ArgS.StartValue = MonitorRow.DepartmentRow.FullName;
                MonitorRow.DepartmentID = value;
                if (MonitorRow.DepartmentRow != null)
                    ArgS.EndValue = MonitorRow.DepartmentRow.FullName;
                if (MonitorRow.DepartmentRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("Отдел", ArgS);
                        //if (DepartmentIDChanged != null)
                        //    DepartmentIDChanged(this, ArgS);
                    }
                }
            }
        }

        [Category("Технические характеристики")]
        [DisplayName("Модель")]
        [ReadOnly(true)]
        public string MonitorModel
        {
            get
            {
                if (MonitorRow.MonitorModelRow != null)
                {
                    return MonitorRow.MonitorModelRow.FullName;
                }
                else
                    return null;
            }
        }


        [Browsable(false)] 
        public int MonitorModelID
        {
            get { return MonitorRow.MonitorModelID; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                if (MonitorRow.MonitorModelRow != null)
                    ArgS.StartValue = MonitorRow.MonitorModelRow.FullName;
                MonitorRow.MonitorModelID = value;
                if (MonitorRow.MonitorModelRow != null)
                    ArgS.EndValue = MonitorRow.MonitorModelRow.FullName;
                if (MonitorRow.MonitorModelRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("Модель", ArgS);
                        //if (ProcessorIDChanged != null)
                        //    ProcessorIDChanged(this, ArgS);
                    }

                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Кабинет")]
        [ReadOnly(true)]
        public string Room
        {
            get { return MonitorRow.Room; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = MonitorRow.Room;
                ArgS.EndValue = value;
                MonitorRow.Room = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Кабинет", ArgS);
                    //if (RoomChanged != null)
                    //    RoomChanged(this, ArgS);
                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Списан")]
        public bool Deleted
        {
            get { return MonitorRow.Deleted; }
            private set { MonitorRow.Deleted = value; }
        }

        [Category("РИВШ")]
        [DisplayName("Дата поступления")]
        [ReadOnly(true)]
        public DateTime PurchaseDate
        {
            get { return MonitorRow.PurchaseDate; }
            set
            {
                ArgD = new ChangeDateValueEventArgs();
                ArgD.StartValue = MonitorRow.PurchaseDate;
                ArgD.EndValue = value;
                MonitorRow.PurchaseDate = value;
                if (ArgD.StartValue != ArgD.EndValue)
                {
                    addMessage("Дата закупки", ArgD);
                    //if (PurchaseDateChanged != null)
                    //    PurchaseDateChanged(this, ArgD);
                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Гарантия до")]
        [ReadOnly(true)]
        public DateTime WarantyDate
        {
            get { return MonitorRow.WarantyDate; }
            set
            {
                ArgD = new ChangeDateValueEventArgs();
                ArgD.StartValue = MonitorRow.WarantyDate;
                ArgD.EndValue = value;
                MonitorRow.WarantyDate = value;
                if (ArgD.StartValue != ArgD.EndValue)
                {
                    addMessage("Дата истечения гарантии", ArgD);
                    //if (WarantyDateChanges != null)
                    //    WarantyDateChanges(this, ArgD);
                }
            }
        }

        [Browsable(false)] 
        public string ComputerGuid
        {
            get { return MonitorRow.ComputerGUID; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                if (MonitorRow.CompRow != null)
                    ArgS.StartValue = MonitorRow.ComputerFullName2;
                MonitorRow.ComputerGUID = value;
                if (MonitorRow.CompRow != null)
                    ArgS.EndValue = MonitorRow.ComputerFullName2;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Компьютер", ArgS);
                    //if (MonitorGuidChanged != null)
                    //    MonitorGuidChanged(this, ArgS);
                }

            }
        }

        [Category("РИВШ")]
        [DisplayName("Инвентарный номер")]
        [ReadOnly(true)]
        public string Number
        {
            get { return  MonitorRow.Number; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = MonitorRow.Number;
                ArgS.EndValue = value;
                MonitorRow.Number = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Инвент №", ArgS);
                    //if (NumberChanged != null)
                    //    NumberChanged(this, ArgS);
                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Структурное подразделение")]
        public string Department
        {
            get
            {
                if (MonitorRow.DepartmentRow != null)
                {
                    return MonitorRow.DepartmentRow.FullName;
                }
                else
                    return "";
            }
        }

        public void Remove()
        {
            this.MonitorRow.Deleted = true;
            this.ComputerGuid = null;
            this.DepartmentID = 19;
            this.Room = null;
        }
        private void addMessage(string S1, ChangeStringValueEventArgs Arg){
            if (ResultMessage != null)
                ResultMessage = string.Format("{0}\n\r", ResultMessage);
            if (Arg.StartValue != null & Arg.StartValue != "")
                ResultMessage = string.Format("{0}{1}: {2}--->{3}", ResultMessage, S1, Arg.StartValue, Arg.EndValue);
            else
                ResultMessage = string.Format("{0}{1}: {2}", ResultMessage, S1, Arg.EndValue);
        }
        private void addMessage(string S1, ChangeDateValueEventArgs Arg)
        {
            if (ResultMessage != null)
                ResultMessage = string.Format("{0}\n\r", ResultMessage);
            if (Arg.StartValue > DateTime.Parse("01.01.2000"))
                ResultMessage = string.Format("{0}{1}: {2}--->{3}", ResultMessage, S1,
                    Arg.StartValue.ToShortDateString(), Arg.EndValue.ToShortDateString());
            else
                ResultMessage = string.Format("{0}{1}: {2}", ResultMessage, S1, Arg.EndValue.ToShortDateString());
        }



        public static Monitor FindByGUID(DS_NiheComputers DS, string GUID)
        {
            DS_NiheComputers.MonitorRow row = null;
            var selectedrows = DS.Monitor.Select(string.Format(@"GUID = '{0}'", GUID));
            if (selectedrows.Length > 0)
            {
                DataRow r = selectedrows[0];
                int index = (int)r["ID"];
                row = DS.Monitor.FindByID(index);
            }
            Monitor monitor = new Monitor(DS, row);
            return monitor;
        }
        public void ResetMessage()
        {
            this.ResultMessage = null;
        }
    }
}
