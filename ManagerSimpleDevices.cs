using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nihe_computers2
{
    public class ManagerSimpleDevice
    {
        public ManagerSimpleDevice(DS_NiheComputers DS, BindingSource BSSimpleDevice)
        {
            this.DS = DS;
            this.BSSimpleDevice = BSSimpleDevice;
        }
        private BindingSource BSSimpleDevice = null;
        private DS_NiheComputers DS = null;
        public event SimpleDeviceAddDelegate SimpleDeviceAddEvent;

        public void Add()
        {
            DS_NiheComputers.SimpleDeviceRow sr = null;
            DialogSimpleDeviceAdd D = new DialogSimpleDeviceAdd();
            string infoString = null;
            if (SimpleDeviceAddEvent != null)
            {
                SimpleDeviceAddEvent(this, D);
                if (D.Changed)
                {
                    sr = DS.SimpleDevice.NewSimpleDeviceRow();
                    sr.Name = D.Name;
                    sr.DepartmentID = D.DepartmentID;
                    sr.Number = D.Number;
                    sr.PurchaseDate = D.PurchaseDate;
                    sr.WarantyDate = D.PurchaseDate.AddYears((int)D.WarantyDate);
                    sr.Room = D.Room;
                    sr.UserName = D.Username;
                    sr.VendorID = D.VendorID;
                    sr.Description = D.Description;
                    sr.DeviceTypeID = D.SimpleDeviceTypeID;
                    DS.SimpleDevice.AddSimpleDeviceRow(sr);
                    infoString = sr.FullName;
                    EventWriterSimpleDevice ewc = new EventWriterSimpleDevice(D);
                    ewc.SimpleDeviceID = sr.ID;
                    ewc.SimpleDeviceText = sr.FullName;
                    ewc.DS = DS;
                    SimpleDevice SDevice = new SimpleDevice(DS, sr);
                    ewc.EventName = "Поступление оборудования";
                    ewc.Info = SDevice.FullName;
                    if (SDevice.Number != null & SDevice.Number != "")
                        ewc.Info = string.Format("{0}\r\nИнв. №: {1}", ewc.Info, SDevice.Number);
                    if (SDevice.Vendor != null & SDevice.Vendor != " ")
                        ewc.Info = string.Format("{0}\r\nПроизвод.: {1}", ewc.Info, SDevice.Vendor);
                    if (SDevice.Department != null & SDevice.Department != "")
                        ewc.Info = string.Format("{0}\r\nСтрукт подразд.: {1}", ewc.Info, SDevice.Department);
                    if (SDevice.Name != null & SDevice.Name != "")
                        ewc.Info = string.Format("{0}\r\nМодель.: {1}", ewc.Info, SDevice.Name);
                    if (SDevice.Room != null & SDevice.Room != "")
                        ewc.Info = string.Format("{0}\r\nКабинет: {1}", ewc.Info, SDevice.Room);
                    if (SDevice.Username != null & SDevice.Username != "")
                        ewc.Info = string.Format("{0}\r\nИмя польз.: {1}", ewc.Info, SDevice.Username);
                    ewc.Write();
                    SDevice = null;
                }
            }
            D = null;
        }

        internal class EventWriterSimpleDevice
        {
            public EventWriterSimpleDevice(DS_NiheComputers DS)
            {
                this.DS = DS;
            }

            public EventWriterSimpleDevice(DialogSimpleDeviceAdd D)
            {
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
               // this.SimpleDeviceID = D.SDevice.ID;
            }


            public EventWriterSimpleDevice(DialogSimpleDevice D)
            {
                this.DS = D.DS;
                this.Date = D.Date;
                this.ExtendedInfo = D.ExtendedInfo;
                this.SimpleDeviceID = D.SDevice.ID;
            }

            public DateTime Date { get; set; }
            public string Info { get; set; }
            public int SimpleDeviceID { get; set; }
            public string ExtendedInfo { get; set; }
            public string SimpleDeviceText { get; set; }
            public string EventName { get; set; }
            public DS_NiheComputers DS { get; set; }

            public void Write()
            {
                DS_NiheComputers.SimpleDeviceEventRow sder = DS.SimpleDeviceEvent.NewSimpleDeviceEventRow();
                sder.Date = Date;
                sder.Info = Info;
                sder.SimpleDeviceID = SimpleDeviceID;
                sder.ExtendedInfo = ExtendedInfo;
                sder.SimpleDeviceText = SimpleDeviceText;
                sder.EventName = EventName;
                DS.SimpleDeviceEvent.AddSimpleDeviceEventRow(sder);
            }
        }
    }
}
