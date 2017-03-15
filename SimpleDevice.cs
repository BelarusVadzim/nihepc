using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace nihe_computers2
{
   public class SimpleDevice
    {
         public SimpleDevice(DS_NiheComputers DS)
        {
            this.DS = DS;
            DS_NiheComputers.SimpleDeviceRow newRow = DS.SimpleDevice.NewSimpleDeviceRow();
            DS.SimpleDevice.AddSimpleDeviceRow(newRow);
            this.SimpleDeviceRow = newRow;
        }
         public SimpleDevice(DS_NiheComputers DS, DS_NiheComputers.SimpleDeviceRow SimpleDeviceRow)
        {
            this.DS = DS;
            this.SimpleDeviceRow = SimpleDeviceRow;
        }

        [Browsable(false)] 
        public int ID
        {
            get { return SimpleDeviceRow.ID; }
        }

        [Browsable(false)] 
        public int DeviceTypeID
        {
            get { return SimpleDeviceRow.DeviceTypeID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (SimpleDeviceRow.DeviceTypeRow != null)
                ArgS.StartValue = SimpleDeviceRow.DeviceTypeRow.FullName;
                SimpleDeviceRow.DeviceTypeID = value;
                if (SimpleDeviceRow.DeviceTypeRow != null)
                    ArgS.EndValue = SimpleDeviceRow.DeviceTypeRow.FullName;
                if (SimpleDeviceRow.DeviceTypeRow != null)
                {
                    if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("Тип устройства", ArgS);
                    }
                }
            }
        }

        [Browsable(false)] 
        public int DepartmentID
        {
            get { return SimpleDeviceRow.DepartmentID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (SimpleDeviceRow.DepartmentRow != null)
                ArgS.StartValue = SimpleDeviceRow.DepartmentRow.FullName;
                SimpleDeviceRow.DepartmentID = value;
                if (SimpleDeviceRow.DepartmentRow != null)
                ArgS.EndValue = SimpleDeviceRow.DepartmentRow.FullName;
                if (SimpleDeviceRow.DepartmentRow != null)
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
        public int VendorID
        {
            get { return SimpleDeviceRow.VendorID; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                if (SimpleDeviceRow.VendorRow != null)
                    ArgS.StartValue = SimpleDeviceRow.VendorRow.FullName;
                SimpleDeviceRow.VendorID = value;
                if (SimpleDeviceRow.VendorRow != null)
                    ArgS.EndValue = SimpleDeviceRow.VendorRow.FullName;
                if (ArgS.StartValue != ArgS.EndValue)
                    {
                        addMessage("Производитель", ArgS);
                        if(VendorIDChanged != null)
                            VendorIDChanged(this, ArgS);
                    }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Структурное подразделение")]
        public string Department
        {
            get
            {
                if (SimpleDeviceRow.DepartmentRow != null)
                {
                    return SimpleDeviceRow.DepartmentRow.FullName;
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
                if (SimpleDeviceRow.VendorRow != null)
                {
                    return SimpleDeviceRow.VendorRow.FullName;
                }
                else
                    return "";
            }
        }

      
        [Category("Комплектующие")]
        [DisplayName("Модель")]
        [ReadOnly(true)]
        public string Name{
            get { return SimpleDeviceRow.Name; }
            set { 
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = SimpleDeviceRow.Name;
                ArgS.EndValue = value;
                SimpleDeviceRow.Name = value;
                if (ArgS.StartValue != ArgS.EndValue )
                {
                    addMessage("Модель", ArgS);
                    if(NameChanged != null)
                        NameChanged(this, ArgS);
                }
            }
        }

        [Category("РИВШ")]
        [DisplayName("Инвентарный номер")]
        [ReadOnly(true)]
        public string Number{
            get { return SimpleDeviceRow.Number; }
            set {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = SimpleDeviceRow.Number;
                ArgS.EndValue = value;
                SimpleDeviceRow.Number = value;
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
            get { return SimpleDeviceRow.UserName; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = SimpleDeviceRow.UserName;
                ArgS.EndValue = value;
                SimpleDeviceRow.UserName = value;
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
            get { return SimpleDeviceRow.Room; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = SimpleDeviceRow.Room;
                ArgS.EndValue = value;
                SimpleDeviceRow.Room = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Кабинет", ArgS);
                    if(RoomChanged != null)
                        RoomChanged(this, ArgS);
                }
            } 
        }

        [Category("РИВШ")]
        [DisplayName("Дата поступления")]
        [ReadOnly(true)]
        public DateTime PurchaseDate{
            get { return SimpleDeviceRow.PurchaseDate; }
            set {
                ArgD = new ChangeDateValueEventArgs();
                ArgD.StartValue = SimpleDeviceRow.PurchaseDate;
                ArgD.EndValue = value;
                SimpleDeviceRow.PurchaseDate = value;
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
            get { return SimpleDeviceRow.WarantyDate; }
            set
            {
                ArgD = new ChangeDateValueEventArgs();
                ArgD.StartValue = SimpleDeviceRow.WarantyDate;
                ArgD.EndValue = value;
                SimpleDeviceRow.WarantyDate = value;
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
            get { return SimpleDeviceRow.FullName; }
        }

        [Category("РИВШ")]
        [DisplayName("Списан")]
        public bool Deleted {
            get { return SimpleDeviceRow.Deleted; }
            private set { SimpleDeviceRow.Deleted = value; }
        }

        [Category("Комплектующие")]
        [DisplayName("Описание")]
        [ReadOnly(true)]
        public string Description
        {
            get { return SimpleDeviceRow.Description; }
            set
            {
                ArgS = new ChangeStringValueEventArgs();
                ArgS.StartValue = SimpleDeviceRow.Description;
                ArgS.EndValue = value;
                SimpleDeviceRow.Description = value;
                if (ArgS.StartValue != ArgS.EndValue)
                {
                    addMessage("Описание", ArgS);
                    if (DescriptionChanged != null)
                        DescriptionChanged(this, ArgS);
                }
            }
        }


        [Browsable(false)] 
        public DS_NiheComputers.SimpleDeviceRow SimpleDeviceRow { get; private set; }
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

        public event ComputerChangeStringValueDelegate NameChanged;
        public event ComputerChangeStringValueDelegate DescriptionChanged;
        public event ComputerChangeStringValueDelegate NumberChanged;
        public event ComputerChangeStringValueDelegate RoomChanged;
        public event ComputerChangeStringValueDelegate UsernameChanged;
        public event ComputerChangeStringValueDelegate VendorIDChanged;
        public event ComputerChangeStringValueDelegate DepartmentIDChanged;
        public event ComputerChangeDateValueDelegate PurchaseDateChanged;
        public event ComputerChangeDateValueDelegate WarantyDateChanges;

        public void Remove()
        {
            SimpleDeviceRow.Deleted = true;
            this.Username = "никого";
            this.DepartmentID = 19;
            this.Room = "нет";
        }
        public void ResetMessage()
        {
            this.ResultMessage = null;
        }

       


    }
}
