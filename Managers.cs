using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace nihe_computers2
{



    public class ManagerProcessor
    {
        public ManagerProcessor(DS_NiheComputers DS, BindingSource BSProcessor)
        {
            this.DS = DS;
            this.BSProcessor = BSProcessor;
        }
        private BindingSource BSProcessor = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditProcessorTable;
        public void Edit()
        {
            if (StartEditProcessorTable != null)
                StartEditProcessorTable(this, BSProcessor);
        }
    }
    public class ManagerVendor
    {
        public ManagerVendor(DS_NiheComputers DS, BindingSource BSVendor)
        {
            this.DS = DS;
            this.BSVendor = BSVendor;

        }
        private BindingSource BSVendor = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditVendorTable;

        public void Edit()
        {
            if (StartEditVendorTable != null)
                StartEditVendorTable(this, BSVendor);
        }
    }
    public class ManagerSocket
    {
        public ManagerSocket(DS_NiheComputers DS, BindingSource BSSocket)
        {
            this.DS = DS;
            this.BSSocket = BSSocket;
        }

        private BindingSource BSSocket = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditSocketTable;
        public void Edit()
        {
            if (StartEditSocketTable != null)
                StartEditSocketTable(this, BSSocket);
        }
    }




    public class ManagerDepartment
    {
        public ManagerDepartment(DS_NiheComputers DS, BindingSource BSDepartment)
        {
            this.DS = DS;
            this.BSDepartment = BSDepartment;
        }
        private BindingSource BSDepartment = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditDepartmentTable;

        public void Edit()
        {
            if (StartEditDepartmentTable != null)
                StartEditDepartmentTable(this, BSDepartment);
        }
    }
    public class ManagerPrinterType
    {
        public ManagerPrinterType(DS_NiheComputers DS, BindingSource BSPrinterType)
        {
            this.DS = DS;
            this.BSPrinterType = BSPrinterType;
        }
        private BindingSource BSPrinterType = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditPrinterTypeTable;
        public void Edit()
        {
            if (StartEditPrinterTypeTable != null)
                StartEditPrinterTypeTable(this, BSPrinterType);
        }
    }
    public class ManagerRAMType
    {
        public ManagerRAMType(DS_NiheComputers DS, BindingSource BSRAMType)
        {
            this.DS = DS;
            this.BSRAMType = BSRAMType;
        }
        private BindingSource BSRAMType = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditRAMTypeTable;
        public void Edit()
        {
            if (StartEditRAMTypeTable != null)
                StartEditRAMTypeTable(this, BSRAMType);
        }
    }
    public class ManagerRAM
    {
        public ManagerRAM(DS_NiheComputers DS, BindingSource BSRAM)
        {
            this.DS = DS;
            this.BSRAM = BSRAM;
        }
        private BindingSource BSRAM = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditRAMTable;

        public void Edit()
        {
            if (StartEditRAMTable != null)
                StartEditRAMTable(this, BSRAM);
        }
    }
    public class ManagerOSName
    {
        public ManagerOSName(DS_NiheComputers DS, BindingSource BSOSName)
        {
            this.DS = DS;
            this.BSOSName = BSOSName;
        }
        private BindingSource BSOSName = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditOSNameTable;

        public void Edit()
        {
            if (StartEditOSNameTable != null)
                StartEditOSNameTable(this, BSOSName);
        }
    }
    public class ManagerArchitectureType
    {
        public ManagerArchitectureType(DS_NiheComputers DS, BindingSource BSArchitectureType)
        {
            this.DS = DS;
            this.BSArchitectureType = BSArchitectureType;
        }
        private BindingSource BSArchitectureType = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditArchitectureTypeTable;

        public void Edit()
        {
            if (StartEditArchitectureTypeTable != null)
                StartEditArchitectureTypeTable(this, BSArchitectureType);
        }
    }
    public class ManagerOS
    {
        public ManagerOS(DS_NiheComputers DS, BindingSource BSOS)
        {
            this.DS = DS;
            this.BSOS = BSOS;
        }
        private BindingSource BSOS = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditOSTable;
        public void Edit()
        {
            if (StartEditOSTable != null)
                StartEditOSTable(this, BSOS);
        }
    }
    public class ManagerHDDType
    {
        public ManagerHDDType(DS_NiheComputers DS, BindingSource BSHDDType)
        {
            this.DS = DS;
            this.BSHDDType = BSHDDType;
        }
        private BindingSource BSHDDType = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditHDDTypeTable;

        public void Edit()
        {
            if (StartEditHDDTypeTable != null)
                StartEditHDDTypeTable(this, BSHDDType);
        }
    }
    public class ManagerMonitorModel
    {
        public ManagerMonitorModel(DS_NiheComputers DS, BindingSource BSMonitorModel)
        {
            this.DS = DS;
            this.BSMonitorModel = BSMonitorModel;
        }
        private BindingSource BSMonitorModel = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditMonitorModelTable;

        public void Edit()
        {
            if (StartEditMonitorModelTable != null)
                StartEditMonitorModelTable(this, BSMonitorModel);
        }
    }
    public class ManagerHDD
    {
        public ManagerHDD(DS_NiheComputers DS, BindingSource BSHDD)
        {
            this.DS = DS;
            this.BSHDD = BSHDD;
        }
        private BindingSource BSHDD = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditHDDTable;

        public void Edit()
        {
            if (StartEditHDDTable != null)
                StartEditHDDTable(this, BSHDD);
        }
    }



    public class ManagerDeviceType
    {
        public ManagerDeviceType(DS_NiheComputers DS, BindingSource BSSimpleDeviceType)
        {
            this.DS = DS;
            this.BSSimpleDeviceType = BSSimpleDeviceType;
        }
        private BindingSource BSSimpleDeviceType = null;
        private DS_NiheComputers DS = null;
        public event TableEditDelegate StartEditDeviceType;

        public void Edit()
        {
            if (StartEditDeviceType != null)
                StartEditDeviceType(this, BSSimpleDeviceType);
        }
    }
}
