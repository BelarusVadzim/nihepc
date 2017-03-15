using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace nihe_computers2
{

    public class Computer
    {

        public Computer(DS_NiheComputers DS)
        {
            this.DS = DS;
            DS_NiheComputers.CompRow newRow = DS.Comp.NewCompRow();
            newRow.GUID = Guid.NewGuid().ToString();
            DS.Comp.AddCompRow(newRow);
            this.ComputerRow = newRow;
        }
        public Computer(DS_NiheComputers DS, DS_NiheComputers.CompRow ComputerRow)
        {
            this.DS = DS;
            this.ComputerRow = ComputerRow;
            RatingCalculation();
        }

        [Browsable(false)] 
        public int ID
        {
            get { return ComputerRow.ID; }
        }

        [Browsable(false)] 
        public int ProcessorID
        {
            get { return ComputerRow.ProcessorID; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.ProcessorRow != null)
                ArgS.StartValue = ComputerRow.ProcessorRow.FullName;
                ComputerRow.ProcessorID = value;
                if (ComputerRow.ProcessorRow != null)
                ArgS.EndValue = ComputerRow.ProcessorRow.FullName;
                if (ComputerRow.ProcessorRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("ЦП", ArgS);
                        if(ProcessorIDChanged != null)
                            ProcessorIDChanged(this, ArgS);
                    }

                }
            }
        }

        [Browsable(false)] 
        public int RAMID
        {
            get { return ComputerRow.RAMID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.RAMRow != null)
                ArgS.StartValue = ComputerRow.RAMRow.FullName;
                ComputerRow.RAMID = value;
                if (ComputerRow.RAMRow != null)
                ArgS.EndValue = ComputerRow.RAMRow.FullName;
                if (ComputerRow.RAMRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("ОЗУ", ArgS);
                        if(RAMIDChanged != null)
                            RAMIDChanged(this, ArgS);
                    }
                    RatingCalculation();
                }
            }
        }

        [Browsable(false)] 
        public int HDDID
        {
            get { return ComputerRow.HDDID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.HDDRow != null)
                ArgS.StartValue = ComputerRow.HDDRow.FullName;
                ComputerRow.HDDID = value;
                if (ComputerRow.HDDRow != null)
                ArgS.EndValue = ComputerRow.HDDRow.FullName;
                if (ComputerRow.HDDRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("ЖД", ArgS);
                        if(HDDIDChanged != null)
                            HDDIDChanged(this, ArgS);
                    }
                    RatingCalculation();
                }
            }
        }

        [Browsable(false)] 
        public int DepartmentID
        {
            get { return ComputerRow.DepartmentID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.DepartmentRow != null)
                ArgS.StartValue = ComputerRow.DepartmentRow.FullName;
                ComputerRow.DepartmentID = value;
                if (ComputerRow.DepartmentRow != null)
                ArgS.EndValue = ComputerRow.DepartmentRow.FullName;
                if (ComputerRow.DepartmentRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("Отдел", ArgS);
                        if(DepartmentIDChanged != null)
                            DepartmentIDChanged(this, ArgS);
                    }
                }
            }
        }

        [Browsable(false)] 
        public int OSID
        {
            get { return ComputerRow.OSID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.OSRow != null)
                    ArgS.StartValue = ComputerRow.OSRow.FullName;
                ComputerRow.OSID = value;
                if (ComputerRow.OSRow != null)
                    ArgS.EndValue = ComputerRow.OSRow.FullName;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                     addMessage("ОС", ArgS);
                     if(OSIDChanged != null)
                        OSIDChanged(this, ArgS);
                }
            }
        }

        [Browsable(false)] 
        public int VendorID
        {
            get { return ComputerRow.VendorID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.VendorRow != null)
                    ArgS.StartValue = ComputerRow.VendorRow.FullName;
                ComputerRow.VendorID = value;
                if (ComputerRow.VendorRow != null)
                    ArgS.EndValue = ComputerRow.VendorRow.FullName;
                if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("Производитель", ArgS);
                        if(VendorIDChanged != null)
                            VendorIDChanged(this, ArgS);
                    }
            }
        }

        [Browsable(false)] 
        public string MonitorGUID
        {
            get { return ComputerRow.MonitorGUID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (ComputerRow.MonitorRow != null)
                    ArgS.StartValue = ComputerRow.MonitorRow.FullName;
                ComputerRow.MonitorGUID = value;
                if(ComputerRow.MonitorRow!= null)
                    ArgS.EndValue = ComputerRow.MonitorRow.FullName;

                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Монитор", ArgS);
                    if(MonitorGuidChanged != null)
                        MonitorGuidChanged(this, ArgS);
                }
                
            }
        }

        [DisplayName("Процессор")]
        [Category("Комплектующие")]
        public string Processor 
        {
            get
            {
                if (ComputerRow.ProcessorRow != null)
                {
                    return ComputerRow.ProcessorRow.FullName;
                }
                else
                    return "";
            }
        }

        [DisplayName("Оперативная память")]
        [Category("Комплектующие")]
        public string RAM 
        {
            get
            {
                if (ComputerRow.RAMRow != null)
                {
                    return ComputerRow.RAMRow.FullName;
                }
                else
                    return "";
            }
        }

        [DisplayName("Жесткий диск")]
        [Category("Комплектующие")]
        public string HDD
        {
            get
            {
                if (ComputerRow.HDDRow != null)
                {
                    return ComputerRow.HDDRow.FullName;
                }
                else
                    return "";
            }
        }

        [Category("РИВШ")]
        [DisplayName("Структурное подразделение")]
        public string Department
        {
            get
            {
                if (ComputerRow.DepartmentRow != null)
                {
                    return ComputerRow.DepartmentRow.FullName;
                }
                else
                    return "";
            }
        }

        [Category("Комплектующие")]
        [DisplayName("Операционная система")]
        public string OS
        {
            get
            {
                if (ComputerRow.OSRow != null)
                {
                    return ComputerRow.OSRow.FullName;
                }
                else
                    return "";
            }
        }

        [Category("Комплектующие")]
        [DisplayName("Производитель")]
        public string Vendor
        {
            get
            {
                if (ComputerRow.VendorRow != null)
                {
                    return ComputerRow.VendorRow.FullName;
                }
                else
                    return "";
            }
        }

        [Category("Комплектующие")]
        [DisplayName("Монитор")]
        public string Monitor{
            get {
                if (this.ComputerRow.MonitorRow != null)
                    return this.ComputerRow.MonitorRow.FullName;
                else
                    return "Нет подключенных мониторов";
            }
        }

        [Browsable(false)] 
        public int MonitorID
        {
            get
            {
                if (ComputerRow.MonitorRow != null)
                {
                    return ComputerRow.MonitorRow.ID;
                }
                else
                    return 1;
            }
        }

        [Category("Комплектующие")]
        [DisplayName("Имя компьютера")]
        [ReadOnly(true)]
        public string ComputerName{
            get { return ComputerRow.Name; }
            set { 
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = ComputerRow.Name;
                ArgS.EndValue = value;
                ComputerRow.Name = value;
                if (ArgS.StartValue != ArgS.EndValue )
                {
                    addMessage("Имя компьютера", ArgS);
                    if(ComputerNameChanged != null)
                        ComputerNameChanged(this, ArgS);
                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Инвентарный номер")]
        [ReadOnly(true)]
        public string Number{
            get { return ComputerRow.Num; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = ComputerRow.Num;
                ArgS.EndValue = value;
                ComputerRow.Num = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Инвент №", ArgS);
                    if (NumberChanged != null)
                        NumberChanged(this, ArgS);
                }
            } 
        }

        [Category("РИВШ")]
        [DisplayName("Пользователь")]
        [ReadOnly(true)]
        public string Username{
            get { return ComputerRow.User; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = ComputerRow.User;
                ArgS.EndValue = value;
                ComputerRow.User = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Пользователь", ArgS);
                    if(UsernameChanged != null)
                        UsernameChanged(this, ArgS);
                }
            } 
        }

        [Category("РИВШ")]
        [DisplayName("Кабинет")]
        [ReadOnly(true)]
        public string Room{
            get { return ComputerRow.Room; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = ComputerRow.Room;
                ArgS.EndValue = value;
                ComputerRow.Room = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Кабинет", ArgS);
                    if(RoomChanged != null)
                        RoomChanged(this, ArgS);
                }
            } 
        }

        [Browsable(false)] 
        public string GUID{
            get { return ComputerRow.GUID; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = ComputerRow.GUID;
                ArgS.EndValue = value;
                ComputerRow.GUID = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Guid", ArgS);
                    if(GuidChanged != null)
                        GuidChanged(this, ArgS);
                }
            } 
        }

        [Category("РИВШ")]
        [DisplayName("Дата поступления")]
        [ReadOnly(true)]
        public DateTime PurchaseDate{
            get { return ComputerRow.PurchaseDate; }
            set {
                ArgD = new ChangeDateValueEventArgs();
                ArgD.StartValue = ComputerRow.PurchaseDate;
                ArgD.EndValue = value;
                ComputerRow.PurchaseDate = value;
                if (ArgD.StartValue != ArgD.EndValue)
                {
                    addMessage("Дата закупки", ArgD);
                    if(PurchaseDateChanged != null)
                        PurchaseDateChanged(this, ArgD);
                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Гарантия до")]
        [ReadOnly(true)]
        public DateTime WarantyDate{
            get { return ComputerRow.WarantyDate; }
            set
            {
                ArgD = new ChangeDateValueEventArgs();
                ArgD.StartValue = ComputerRow.WarantyDate;
                ArgD.EndValue = value;
                ComputerRow.WarantyDate = value;
                if (ArgD.StartValue != ArgD.EndValue)
                {
                    addMessage("Дата истечения гарантии", ArgD);
                    if(WarantyDateChanges != null)
                        WarantyDateChanges(this, ArgD);
                }
            }
        }

        [Category("Комплектующие")]
        [DisplayName("Все характеристики")]
        public string FullName{
            get { return ComputerRow.FullName; }
        }

        [Category("РИВШ")]
        [DisplayName("Списан")]
        public bool Deleted {
            get { return ComputerRow.Deleted; }
            private set { ComputerRow.Deleted = value; }
        }

        [Category("Комплектующие")]
        [DisplayName("Рэйтинг")]
        public int Rating{
            get { return ComputerRow.Rating; }
            private set { ComputerRow.Rating= value; }
        }

        [Category("Комплектующие")]
        [DisplayName("Описание")]
        [ReadOnly(true)]
        public string Description
        {
            get { return ComputerRow.Description; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = ComputerRow.Description;
                ArgS.EndValue = value;
                ComputerRow.Description = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Описание", ArgS);
                    if (DescriptionChanged != null)
                        DescriptionChanged(this, ArgS);
                }
            }
        }


        [Browsable(false)] 
        public DS_NiheComputers.CompRow ComputerRow { get; private set; }
        [Browsable(false)] 
        public DS_NiheComputers DS { get; private set; }
        [Browsable(false)] 
        public string ResultMessage { get; private set; }
        private void addMessage(string S1, ChangeStringValueEventArgs Arg)
        {
            if (ResultMessage != null)
                ResultMessage = string.Format("{0}\n\r", ResultMessage);
            if (Arg.StartValue != "Нет ОС" &  Arg.StartValue != null & Arg.StartValue != "")
                ResultMessage = string.Format("{0}{1}: {2}--->{3}", ResultMessage, S1, Arg.StartValue, Arg.EndValue);
            else
                ResultMessage = string.Format("{0}{1}: {2}", ResultMessage, S1, Arg.EndValue);
        }
        private void addMessage(string S1, ChangeDateValueEventArgs Arg)
        {
            if (ResultMessage != null)
                ResultMessage = string.Format("{0}\n\r", ResultMessage);
            if(Arg.StartValue > DateTime.Parse("01.01.2000"))
                ResultMessage = string.Format("{0}{1}: {2}--->{3}", ResultMessage, S1, 
                    Arg.StartValue.ToShortDateString(), Arg.EndValue.ToShortDateString());
            else
                ResultMessage = string.Format("{0}{1}: {2}", ResultMessage, S1,  Arg.EndValue.ToShortDateString());
        }

        ChangeStringValueEventArgs ArgS = null;
        ChangeDateValueEventArgs ArgD = null;

        public event ComputerChangeStringValueDelegate ComputerNameChanged;
        public event ComputerChangeStringValueDelegate DescriptionChanged;
        public event ComputerChangeStringValueDelegate NumberChanged;
        public event ComputerChangeStringValueDelegate RoomChanged;
        public event ComputerChangeStringValueDelegate UsernameChanged;
        public event ComputerChangeStringValueDelegate GuidChanged;
        public event ComputerChangeStringValueDelegate MonitorGuidChanged;
        public event ComputerChangeStringValueDelegate ProcessorIDChanged;
        public event ComputerChangeStringValueDelegate RAMIDChanged;
        public event ComputerChangeStringValueDelegate HDDIDChanged;
        public event ComputerChangeStringValueDelegate OSIDChanged;
        public event ComputerChangeStringValueDelegate VendorIDChanged;
        public event ComputerChangeStringValueDelegate DepartmentIDChanged;
        public event ComputerChangeDateValueDelegate PurchaseDateChanged;
        public event ComputerChangeDateValueDelegate WarantyDateChanges;

        public static Computer FindByGUID(DS_NiheComputers DS, string GUID)
        {
            DS_NiheComputers.CompRow row = null;
            Computer comp = null;
            var selectedrows = DS.Comp.Select(string.Format(@"GUID = '{0}'", GUID));
            if (selectedrows.Length > 0)
            {
                DataRow r = selectedrows[0];
                int index = (int)r["ID"];
                row = DS.Comp.FindByID(index);
                comp = new Computer(DS, row);
            }
            
            return comp;
        }

        public void Remove()
        {
            ComputerRow.Deleted = true;
            this.Username = "никого";
            //this.MonitorGUID = "";
            this.DepartmentID = 19;
            this.Room = "нет";
        }
        public void ResetMessage()
        {
            this.ResultMessage = null;
        }

        private void RatingCalculation()
        {
            int result = 0;
            if (WarantyDate > DateTime.Now)
            {
                this.ComputerRow.Rating = 10;
            }
            else
            {

                if (this.ComputerRow.RAMRow != null)
                {
                    if (this.ComputerRow.RAMRow.Size >= 4)
                        result = result + 60;
                    else if (this.ComputerRow.RAMRow.Size >= 2)
                        result = result + 30;
                    if (this.ComputerRow.RAMRow.RAMTypeRow != null)
                    {
                        switch (this.ComputerRow.RAMRow.RAMTypeRow.Name)
                        {
                            case "DDR3":
                                result = result + 20;
                                break;
                            case "DDR2":
                                result = result + 10;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (this.ComputerRow.HDDRow != null)
                {
                    if (this.ComputerRow.HDDRow.Size >= 500)
                        result = result + 20;
                    else if (this.ComputerRow.HDDRow.Size > 250)
                        result = result + 10;
                }

                this.ComputerRow.Rating = result / 10;
            }
        }
    }


   
}
