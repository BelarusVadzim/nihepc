using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace nihe_computers2
{
    public abstract class Dialog
    {
        public Dialog()
        {
            this.Changed = false;
        }
        public bool Changed { get; private set; }
        public DateTime Date { get; set; }
        public string ExtendedInfo { get; set; }
        public void AcceptChanges()
        {
            Changed = true;
        }
        public string DialogQuest { get; set; }
        public Operation OperationName { get; set; }
        public string Description { get; set; }
    }

    public class DialogComputer : Dialog
    {
        public DialogComputer()
        {
        }
        public DialogComputer(Computer Comp)
        {
            this.Comp = Comp;
            this.DS = Comp.DS;
        }
    
        public DS_NiheComputers DS { get; set; }
        public bool ShowDelButton { get; set; }
        public String Operation { get; set; }
        public Computer Comp { get; set; }

    }


    public class DialogSimpleDeviceAdd : Dialog
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int SimpleDeviceTypeID { get; set; }
        public string Username { get; set; }
        public string Room { get; set; }
        public int DepartmentID { get; set; }
        public int VendorID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Decimal WarantyDate { get; set; }

        public DS_NiheComputers DS { get; set; }
        public bool ShowDelButton { get; set; }
        public String Operation { get; set; }
       // public SimpleDevice SDevice { get; set; }


    }

    public class DialogSimpleDevice : Dialog
    {
        public DialogSimpleDevice()
        {
        }
        public DialogSimpleDevice(SimpleDevice SDevice)
        {
            this.SDevice = SDevice;
            this.DS = SDevice.DS;
        }

        public DS_NiheComputers DS { get; set; }
        public bool ShowDelButton { get; set; }
        public String Operation { get; set; }
        public SimpleDevice SDevice { get; set; }

    }





    public class DialogValueEdit : Dialog
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public DataTable tblValues { get; set; }
    }

    public class DialogStringValueEdit : Dialog
    {
        public string StartText { get; set; }
        public string EndText { get; set; }
    }

    public class DialogListValueEdit : Dialog
    {
        public DialogListValueEdit(Operation OperationName)
        {
            this.OperationName = OperationName;
        }
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public DataRow[] ValuesList { get; set; }
        
    }

    public class DialogComputerAdd : Dialog
    {
        public string ComputerName { get; set; }
        public string Number { get; set; }
        public int ProcessorID { get; set; }
        public int RAMID { get; set; }
        public int HDD { get; set; }
        public string Username { get; set; }
        public string Room { get; set; }
        public string GUID { get; set; }
        public int DepartmentID { get; set; }
        public int OSID { get; set; }
        public int VendorID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Decimal WarantyDate { get; set; }


    }
    public class DialogComputerRemove : Dialog
    {
        public bool Deleted { get; set; }
    }
    public class DialogMonitorAdd : Dialog
    {
        public string Number { get; set; }
        public int MonitorModelID { get; set; }
        public string Username { get; set; }
        public string Room { get; set; }
        public string GUID { get; set; }
        public int DepartmentID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Decimal WarantyDate { get; set; }

    }
    public class DialogMonitor : Dialog
    {
        public DialogMonitor(DS_NiheComputers DS, DS_NiheComputers.MonitorRow mr)
        {
            this.mr = mr;
            this.Number = mr.Number;
            this.Department = mr.DepartmentRow.FullName;
            this.Room = mr.Room;
            this.Date = mr.PurchaseDate;
            this.WarantyDate = mr.WarantyDate.ToShortDateString();
            this.GUID = mr.GUID.ToString();
            this.Deleted = mr.Deleted;
            this.FullName = mr.FullName;
            this.Vendor = mr.MonitorModelRow.VendorRow.Name;
            // this.EventTable = DS.EventComp;
        }
        public DialogMonitor(Monitor monitor)
        {
            this.monitor = monitor;
            this.mr = monitor.MonitorRow;
            this.Number = mr.Number;
            this.Department = mr.DepartmentRow.FullName;
            this.Room = mr.Room;
            this.Date = mr.PurchaseDate;
            this.WarantyDate = mr.WarantyDate.ToShortDateString();
            this.GUID = mr.GUID.ToString();
            this.Deleted = mr.Deleted;
            this.FullName = mr.FullName;
            this.Vendor = mr.MonitorModelRow.VendorRow.Name;
        }
        public string Number { get; set; }
        public string Room { get; private set; }
        public string GUID { get; private set; }
        public string Department { get; set; }
        public string Vendor { get; private set; }
        public string WarantyDate { get; set; }
        public string FullName { get; set; }
        public bool Deleted { get; set; }
        public DataTable EventTable { get; set; }
        private DS_NiheComputers.MonitorRow mr { get; set; }
        public bool ShowDelButton{ get; set; }
        public Monitor monitor { get; set; }
    }
    public class DialogConnectComputerMonitor : Dialog
    {
        public DialogConnectComputerMonitor(DS_NiheComputers DS, BindingSource BSComputer, BindingSource BSMonitor)
        {
            this.DS = DS;
            this.BSComputer = BSComputer;
            this.BSMonitor = BSMonitor;
        }
        public DS_NiheComputers DS { get; set; }
        public BindingSource BSComputer { get; set; }
        public BindingSource BSMonitor { get; set; }
        public string CompGUID { get; set; }
        public string MonitorGUID { get; set; }
        public string ComputerFullName { get; set; }
    }
    public class DialogMove : Dialog
    {

        public DialogMove(Computer computer)
        {
            this.computer = computer;
            this.DepartmentID = computer.DepartmentID;
            this.Room = computer.Room;
            this.Username = computer.Username;
        }

        public DialogMove(Monitor monitor)
        {
            this.monitor = monitor;
            this.DepartmentID = monitor.DepartmentID;
            this.Room = monitor.Room;
            if(monitor.MonitorRow.CompRow != null)
            this.Username = monitor.MonitorRow.CompRow.User;
        }

        private Computer computer = null;
        private Monitor monitor = null;

        public Monitor Monic
        {
            get { return monitor; }
            set { monitor = value; }
        }

        public Computer Comp
        {
            get { return computer; }
            set { computer = value; }
        }

        public int DepartmentID { get; set; }
        public string Room { get; set; }
        public string Username { get; set; }
        public string MonitorGUID { get; set; }
        public string CompGUID { get; set; }
    }

    public enum Operation
    {
        ChahgeComputer,
        ChangeMonitor,
        ChangeRoom,
        ChangeUserName,
        ChangeDepartment,
        ChangeNumber,
        ChangeMonitorModel,
        ChangeProcessor,
        ChangeRAM,
        ChangeHDD,
        ChangeOS
    }
}
