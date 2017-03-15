using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nihe_computers2
{
    public delegate void ComputerAddDelegate(object sender, DialogComputerAdd Dialog); //
    public delegate void ValueEditDelegate(object sender, DialogValueEdit Dialog); //
    public delegate void ComputerDelegate(object sender, DialogComputer Dialog); //
    public delegate void TableEditDelegate(object sender, BindingSource BS);

    public delegate void MonitorAddDelegate(object sender, DialogMonitorAdd Dialog); //
    public delegate void MonitorDelegate(object sender, DialogMonitor Dialog); //

    public delegate void ConnectComputerMonitorDelegate(object sender, DialogConnectComputerMonitor Dialog); //
    public delegate void MoveDelegate(object sender, DialogMove Dialog); //
    public delegate void ComputerChangeStringValueDelegate(object sender, ChangeStringValueEventArgs D);
    public delegate void ManagerChangeStringValueDelegate(object sender, DialogStringValueEdit D);
    public delegate void ManagerChangeListValueDelegate(object sender, DialogListValueEdit D);
    public delegate void ComputerChangeDateValueDelegate(object sender, ChangeDateValueEventArgs D);
    public delegate void ComputerAddDelegate_new(object sender, DialogComputer D); //
    public delegate void SimpleDeviceAddDelegate(object sender, DialogSimpleDeviceAdd D); //

    public class ChangeStringValueEventArgs : EventArgs
    {
        private string startValue = null;
        private string endValue = null;
        public string StartValue 
        {
            get {
                if (startValue != null && startValue != "")
                    return startValue;
                else
                    return "no";
            }
            set { startValue = value; }
        }

        public string EndValue
        {
            get
            {
                if (endValue != null && endValue != "")
                    return endValue;
                else
                    return "no";
            }
            set { endValue = value; }
        }
    }

    //public class ChangeIntValueEventArgs : EventArgs
    //{
    //    public int StartValue { get; set; }
    //    public int EndValue { get; set; }
    //}

    public class ChangeDateValueEventArgs : EventArgs
    {
        public DateTime StartValue { get; set; }
        public DateTime EndValue { get; set; }
    }
}
