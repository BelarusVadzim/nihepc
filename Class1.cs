using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace nihe_computers2
{
   
    public class Class1
    {

        public Class1()
        {
            this.DS = new DS_NiheComputers();
            this.LoadData();
            IndexTables();
            this.BSComp = new BindingSource(DS, "Comp");
            this.BSCompEvent = new BindingSource(DS, "EventComp");
            this.BSProcessor = new BindingSource(DS, "Processor");
            this.BSVendor = new BindingSource(DS, "Vendor");
            this.BSSocket = new BindingSource(DS, "Socket");
            this.BSDepartment = new BindingSource(DS, "Department");
            this.BSPrinterType = new BindingSource(DS, "PrinterType");
            this.BSRAMType = new BindingSource(DS, "RAMType");
            this.BSRAM = new BindingSource(DS, "RAM");
            this.BSOSName = new BindingSource(DS, "OSName");
            this.BSArchitectureType = new BindingSource(DS, "ArchitectureType");
            this.BSOS = new BindingSource(DS, "OS");
            this.BSHDDType = new BindingSource(DS, "HDDType");
            this.BSHDD = new BindingSource(DS, "HDD");
            this.BSMonitorModel = new BindingSource(DS, "MonitorModel");
            this.BSMonitor = new BindingSource(DS, "Monitor");
            this.BSMonitorEvent = new BindingSource(DS, "MonitorEvent");
            this.BSSimpleDevice = new BindingSource(DS, "SimpleDevice");
            this.BSSimpleDeviceType = new BindingSource(DS, "DeviceType");
            this.BSSimpleDeviceEvent = new BindingSource(DS, "SimpleDeviceEvent");


            this.Computer = new ManagerComputer(DS);
            this.Vendor = new ManagerVendor(DS, BSVendor);
            this.Processor = new ManagerProcessor(DS, BSProcessor);
            this.Socket = new ManagerSocket(DS, BSSocket);
            this.Department = new ManagerDepartment(DS, BSDepartment);
            this.PrintType = new ManagerPrinterType(DS, BSPrinterType);
            this.RAMType = new ManagerRAMType(DS, BSRAMType);
            this.RAM = new ManagerRAM(DS, BSRAM);
            this.OSName = new ManagerOSName(DS, BSOSName);
            this.ArchitectureType = new ManagerArchitectureType(DS, BSArchitectureType);
            this.OS = new ManagerOS(DS, BSOS);
            this.HDDType = new ManagerHDDType(DS, BSHDDType);
            this.HDD = new ManagerHDD(DS, BSHDD);
            this.MonitorModel = new ManagerMonitorModel(DS, BSMonitorModel);
            this.Monitor = new ManagerMonitor(DS);
            this.SimpleDevice = new ManagerSimpleDevice(DS, BSSimpleDevice);
            this.DeviceType = new ManagerDeviceType(DS, BSSimpleDeviceType);

        }


        public DS_NiheComputers DS = null;
        public BindingSource BSComp = null;
        public BindingSource BSCompEvent = null;
        public BindingSource BSTest = null;
        public BindingSource BSProcessor = null;
        public BindingSource BSVendor = null;
        public BindingSource BSSocket = null;
        public BindingSource BSDepartment = null;
        public BindingSource BSPrinterType = null;
        public BindingSource BSRAMType = null;
        public BindingSource BSRAM = null;
        public BindingSource BSOSName = null;
        public BindingSource BSArchitectureType = null;
        public BindingSource BSOS = null;
        public BindingSource BSHDDType = null;
        public BindingSource BSHDD = null;
        public BindingSource BSMonitorModel = null;
        public BindingSource BSMonitor = null;
        public BindingSource BSMonitorEvent = null;
        public BindingSource BSSimpleDevice = null;
        public BindingSource BSSimpleDeviceType = null;
        public BindingSource BSSimpleDeviceEvent = null;


        public ManagerComputer Computer { get; set; }
        public ManagerProcessor Processor { get; set; }
        public ManagerVendor Vendor { get; set; }
        public ManagerSocket Socket { get; set; }
        public ManagerDepartment Department { get; set; }
        public ManagerPrinterType PrintType { get; set; }
        public ManagerRAMType RAMType { get; set; }
        public ManagerRAM RAM { get; set; }
        public ManagerOSName OSName { get; set; }
        public ManagerArchitectureType ArchitectureType { get; set; }
        public ManagerOS OS { get; set; }
        public ManagerHDDType HDDType { get; set; }
        public ManagerHDD HDD { get; set; }
        public ManagerMonitorModel MonitorModel { get; set; }
        public ManagerMonitor Monitor { get; set; }
        public ManagerSimpleDevice SimpleDevice { get; set; }
        public ManagerDeviceType DeviceType { get; set; }

        
        public void SaveData()
        {
            DS.AcceptChanges();
            DS.WriteXml(@".\data.xml");
        }
        public void LoadData()
        {
            try
            {
                DS.ReadXml(@".\data.xml");
                DS.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IndexTables()
        {
            foreach (DataTable T in DS.Tables)
            {
                IndexTable(T);
            }
            DS.AcceptChanges();
        }

        private void IndexTable(DataTable T)
        {
            if (T.Columns.Contains("sort") & T.Rows.Count>0)
            {
                DataRow[] tempRows = T.Select("", "sort");

                for (int i = 0; i < T.Rows.Count; i++)
                {
                    tempRows[i]["sort"] = i;
                }
            }
        }
     
    }
}
