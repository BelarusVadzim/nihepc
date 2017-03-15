using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace nihe_computers2
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
            this.C1 = new Class1();
            this.C1.BSComp.Filter = "Deleted = 'false'";
            this.compDataGridView.DataSource =                         C1.BSComp;
            this.departmentIDDataGridViewTextBoxColumn.DataSource =    C1.BSDepartment;
            this.C1.BSDepartment.Sort =                                "Sort";
            this.C1.BSCompEvent.Sort =                                 "Date";
            this.rAMIDDataGridViewTextBoxColumn.DataSource =           C1.BSRAM;
            this.hDDIDDataGridViewTextBoxColumn.DataSource =           C1.BSHDD;
            this.oSIDDataGridViewTextBoxColumn.DataSource =            C1.BSOS;
            this.processorIDDataGridViewTextBoxColumn.DataSource =     C1.BSProcessor;
            this.compEventDataGridView.DataSource =                    C1.BSCompEvent;
            this.processorIDDataGridViewTextBoxColumn.DataSource =     C1.BSProcessor;
            this.MonitorGUID.DataSource =                              C1.BSMonitor;
            this.simpleDeviceDataGridView.DataSource =                 C1.BSSimpleDevice;
            this.dataGridViewTextBoxColumn11.DataSource =              C1.DS.Department;
            this.dataGridViewTextBoxColumn11.ValueMember =             "ID";
            this.dataGridViewTextBoxColumn11.DisplayMember =           "FullName";
            this.simpleDeviceEventDataGridView.DataSource =            C1.BSSimpleDeviceEvent;



            //MonitorPageInit
            this.monitorDataGridView.DataSource = C1.BSMonitor;
            this.dataGridViewComboBoxColumn1.DataSource = C1.BSMonitorModel;
            this.dataGridViewTextBoxColumn6.DataSource = C1.BSDepartment;
            this.monitorEventDataGridView.DataSource = C1.BSMonitorEvent;

            //Computer
            this.C1.Computer.MoveEvent += new MoveDelegate(DeviceMoveEvent);
            this.C1.Computer.ComputerShowInfo += new ComputerDelegate(Computer_ComputerShowInfo);
            this.C1.Computer.SimpleEditEvent += new ManagerChangeStringValueDelegate(DeviceSimpleEditEvent);
            this.C1.Computer.ComputerAddEvent_New += new ComputerAddDelegate_new(Computer_ComputerAddEvent_New);
            this.C1.Computer.ComputerAddEvent += new ComputerAddDelegate(Computer_ComputerAddEvent);
            this.C1.Computer.ChangeStringValueEvent += new ManagerChangeStringValueDelegate(ChangeStringValue);
            this.C1.Computer.ChangeListValueEvent += new ManagerChangeListValueDelegate(ChangeListValue);

            //Monitor
            this.C1.Monitor.MoveEvent += new MoveDelegate(DeviceMoveEvent);
            this.C1.Monitor.MonitorAddEvent += new MonitorAddDelegate(Monitor_MonitorAddEvent);
            this.C1.Monitor.MonitorInfo += new MonitorDelegate(Monitor_MonitorInfo);
            this.C1.Monitor.ChangeListValueEvent += new ManagerChangeListValueDelegate(ChangeListValue);
            this.C1.Monitor.ChangeStringValueEvent += new ManagerChangeStringValueDelegate(ChangeStringValue);
            this.C1.Monitor.SimpleEditEvent += new ManagerChangeStringValueDelegate(DeviceSimpleEditEvent);

            this.C1.Vendor.StartEditVendorTable += new TableEditDelegate(Vendor_StartEditVendorTable);
            this.C1.Processor.StartEditProcessorTable += new TableEditDelegate(Processor_StartEditProcessorTable);
            this.C1.Socket.StartEditSocketTable += new TableEditDelegate(Socket_StartEditSocketTable);
            this.C1.Department.StartEditDepartmentTable += new TableEditDelegate(Department_StartEditDepartmentTable);
            this.C1.PrintType.StartEditPrinterTypeTable += new TableEditDelegate(PrintType_StartEditPrintTypeTable);
            this.C1.RAMType.StartEditRAMTypeTable += new TableEditDelegate(RAMType_StartEditRAMTypeTable);
            this.C1.RAM.StartEditRAMTable += new TableEditDelegate(RAM_StartEditRAMTable);
            this.C1.OSName.StartEditOSNameTable += new TableEditDelegate(OSName_StartEditOSNameTable);
            this.C1.ArchitectureType.StartEditArchitectureTypeTable += new TableEditDelegate(ArchitectureType_StartEditArchitectureTypeTable);
            this.C1.OS.StartEditOSTable += new TableEditDelegate(OS_StartEditOSTable);
            this.C1.HDDType.StartEditHDDTypeTable += new TableEditDelegate(HDDType_StartEditHDDTypeTable);
            this.C1.HDD.StartEditHDDTable += new TableEditDelegate(HDD_StartEditHDDTypeTable);

            this.C1.MonitorModel.StartEditMonitorModelTable += new TableEditDelegate(MonitorModel_StartEditMonitorModelTable);
            //this.C1.SimpleDevice.StartEditSimpleDeviceTable += new TableEditDelegate(SimpleDevice_StartEditSimpleDeviceTable);
            this.C1.SimpleDevice.SimpleDeviceAddEvent += new SimpleDeviceAddDelegate(SimpleDevice_SimpleDeviceAddEvent);
            this.C1.DeviceType.StartEditDeviceType += new TableEditDelegate(DeviceType_StartEditDeviceType);

        }

        void Computer_ComputerAddEvent(object sender, DialogComputerAdd D)
        {
            Form03NewComp F = new Form03NewComp(C1,  D);
            F.ShowDialog();
        }

        void SimpleDevice_SimpleDeviceAddEvent(object sender, DialogSimpleDeviceAdd D)
        {
            Form06DeviceAdd F = new Form06DeviceAdd(C1, D);
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }

        void DeviceType_StartEditDeviceType(object sender, BindingSource BS)
        {
            Form02SimpleTable F = new Form02SimpleTable(BS);
            F.Text = "Типы устройств";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }

        void SimpleDevice_StartEditSimpleDeviceTable(object sender, BindingSource BS)
        {
           
        }

        void DeviceSimpleEditEvent(object sender, DialogStringValueEdit D)
        {
            try
            {
                Form14Disconect F = new Form14Disconect(D);
                F.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        void ChangeListValue(object sender, DialogListValueEdit D)
        {
            Form05ChangeValue F = new Form05ChangeValue(D);
            F.ShowDialog();
        }

        void ChangeStringValue(object sender, DialogStringValueEdit D)
        {
            Form05ChangeValue F = new Form05ChangeValue(D);
            F.ShowDialog();
        }



        void Computer_ComputerAddEvent_New(object sender, DialogComputer D)
        {
             Form03NewComp F = new Form03NewComp(D);
             F.ShowDialog();
        }
        

        void Monitor_MonitorInfo(object sender, DialogMonitor Dialog)
        {
            Form16MonitorInfo F = new Form16MonitorInfo(C1, Dialog);
            F.ShowDialog();
        }

        void DeviceMoveEvent(object sender, DialogMove Dialog)
        {
            Form15Move F = new Form15Move(C1.DS, Dialog);
            F.ShowDialog();
        }

        void Monitor_MonitorRemoveEvent(object sender, DialogMonitor Dialog)
        {
            Form13MonitorRemove F = new Form13MonitorRemove(Dialog);
            F.ShowDialog();
        }

        void Monitor_MonitorAddEvent(object sender, DialogMonitorAdd Dialog)
        {
            Form12MonitorAdd F = new Form12MonitorAdd(C1.DS, Dialog);
            F.ShowDialog();
        }

        void MonitorModel_StartEditMonitorModelTable(object sender, BindingSource BS)
        {
            Form11MonitorModel F = new Form11MonitorModel(C1.DS, BS);
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }

      
        void Computer_ComputerShowInfo(object sender, DialogComputer Dialog)
        {
            Form07CompInfo F = new Form07CompInfo(C1, Dialog);
            F.ShowDialog();
        }
        void HDD_StartEditHDDTypeTable(object sender, BindingSource BSHDD)
        {
            Form10HDD F = new Form10HDD(C1.DS, BSHDD);
            F.ShowDialog();
        }
        void HDDType_StartEditHDDTypeTable(object sender, BindingSource BSHDDType)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSHDDType);
            F.Text = "Типы жестких дисков";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void OS_StartEditOSTable(object sender, BindingSource BSOS)
        {
            Form04OS F = new Form04OS(C1.DS, BSOS);
            F.ShowDialog();
        }
        void ArchitectureType_StartEditArchitectureTypeTable(object sender, BindingSource BSArchitectureType)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSArchitectureType);
            F.Text = "Разрядность операционной системы";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void OSName_StartEditOSNameTable(object sender, BindingSource BSOSName)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSOSName);
            F.Text = "Тип операционной системы";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void RAM_StartEditRAMTable(object sender, BindingSource BSRAM)
        {
            Form09RAM F = new Form09RAM(C1.DS, BSRAM);
            F.ShowDialog();
        }
        void RAMType_StartEditRAMTypeTable(object sender, BindingSource BSRAMType)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSRAMType);
            F.Text = "Типы оперативной памяти";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void PrintType_StartEditPrintTypeTable(object sender, BindingSource BSPrintType)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSPrintType);
            F.Text = "Типы оргтехники";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void EventType_StartEditEventTypeTable(object sender, BindingSource BSEventType)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSEventType);
            F.Text = "Типы событий";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void Department_StartEditDepartmentTable(object sender, BindingSource BSDepartment)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSDepartment);
            F.Text = "Структурные подразделения";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void Socket_StartEditSocketTable(object sender, BindingSource BSSocket)
        {
            Form02SimpleTable F = new Form02SimpleTable(BSSocket);
            F.Text = "Типы разъёмов";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void Processor_StartEditProcessorTable(object sender, BindingSource BSProcessor)
        {
            Form08Processor F = new Form08Processor(C1.DS, C1.BSProcessor);
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                C1.DS.AcceptChanges();
            else
                C1.DS.RejectChanges();
        }
        void Vendor_StartEditVendorTable(object sender, BindingSource BSVendor)
        {
            
            Form02SimpleTable F = new Form02SimpleTable(BSVendor);
            F.Text = "Производители";
            F.ShowDialog();
            if (F.DialogResult == System.Windows.Forms.DialogResult.OK)
                try
                {
                    C1.DS.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
                C1.DS.RejectChanges();
        }
       

        void Computer_ComputerAddedEvent(object sender, DialogComputerAdd Dialog)
        {
            Form03NewComp F = new Form03NewComp(C1, Dialog);
            F.ShowDialog();
        }
       
        private Class1 C1 = null; 
      
        private void ChangeCompNumber(object sender, EventArgs e)
        {
            C1.Computer.ChangeNumber(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompRoom(object sender, EventArgs e)
        {
            C1.Computer.ChangeRoom(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompName(object sender, EventArgs e)
        {
            C1.Computer.ChangeName(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompUserName(object sender, EventArgs e)
        {
            C1.Computer.ChangeUsername(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompDepartment(object sender, EventArgs e)
        {
            C1.Computer.ChangeDepartment(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompProcessor(object sender, EventArgs e)
        {
            C1.Computer.ChangeProcessor(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompRAM(object sender, EventArgs e)
        {
            C1.Computer.ChangeRAM(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompHDD(object sender, EventArgs e)
        {
            C1.Computer.ChangeHDD(compDataGridView.DataSource as BindingSource);
        }
        private void ChangeCompOS(object sender, EventArgs e)
        {
            C1.Computer.ChangeOS(compDataGridView.DataSource as BindingSource);
        }

        private void CreateNewComp(object sender, EventArgs e)
        {
            try
            {
                C1.Computer.Add();
                compDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не заполнены справочники!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void RemoveComp(object sender, EventArgs e)
        {
            C1.Computer.ShowInfo(compDataGridView.DataSource as BindingSource, true);
        }
        private void ShowCompInfo(object sender, EventArgs e)
        {
            C1.Computer.ShowInfo(compDataGridView.DataSource as BindingSource, false);
        }
       
        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Department.Edit();
        }
        private void типыЖДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.HDDType.Edit();
        }
        private void жесткиеДискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.HDD.Edit();
        }
        private void процессорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Processor.Edit();
            compDataGridView.Refresh();
        }
        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Vendor.Edit();
        }
        private void сокетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Socket.Edit();
        }
        private void типыОЗУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.RAMType.Edit();
        }
        private void оЗУToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            C1.RAM.Edit();
        }
        private void разрядностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.ArchitectureType.Edit();
        }
        private void версияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.OSName.Edit();
        }
        private void операционнаяСистемаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            C1.OS.Edit();
        }
     
        private void типыПринтеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.PrintType.Edit();
        }
        private void сохрнаитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.SaveData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            C1.SaveData();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                BindingSource BSComp_Department = new BindingSource(C1.BSDepartment, "FK_Department_Comp");
                BindingSource BSMonitor_Department = new BindingSource(C1.BSDepartment, "FK_Department_Monitor");
                this.cbDepartment.DataSource = C1.BSDepartment;
                C1.BSDepartment.Filter = "name <> 'списан'";
                this.cbDepartment.Enabled = true;
                compDataGridView.DataSource = BSComp_Department;
                monitorDataGridView.DataSource = BSMonitor_Department;
            }
            else
            {
                compDataGridView.DataSource = C1.BSComp;
                monitorDataGridView.DataSource = C1.BSMonitor;

                C1.BSDepartment.RemoveFilter();
                this.cbDepartment.Enabled = false;
            }

            BindingSource BSTemp = compDataGridView.DataSource as BindingSource;
            if (checkBox1.Checked != true)
            {
                BSTemp.Filter = "Deleted = 'false'";
                deletedDataGridViewCheckBoxColumn.Visible = false;
            }
            else
            {
                BSTemp.Filter = "Deleted = 'true' or Deleted = 'false'";
                deletedDataGridViewCheckBoxColumn.Visible = true;
            }

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                rAMIDDataGridViewTextBoxColumn.Visible = true;
                processorIDDataGridViewTextBoxColumn.Visible = true;
                hDDIDDataGridViewTextBoxColumn.Visible = true;
                PurchaseDate.Visible = true;
                WarantyDate.Visible = true;

                dataGridViewTextBoxColumn3.Visible = true;
                dataGridViewTextBoxColumn4.Visible = true;


            }
            else
            {
                rAMIDDataGridViewTextBoxColumn.Visible = false;
                processorIDDataGridViewTextBoxColumn.Visible = false;
                hDDIDDataGridViewTextBoxColumn.Visible = false;
                PurchaseDate.Visible = false;
                WarantyDate.Visible = false;

                dataGridViewTextBoxColumn3.Visible = false;
                dataGridViewTextBoxColumn4.Visible = false;
            }
        }

        private void compDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var hti = compDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex > -1)
                {
                    compDataGridView.ClearSelection();
                    compDataGridView.Rows[hti.RowIndex].Selected = true;
                    C1.BSComp.Position = hti.RowIndex;
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BindingSource BSComputerTemp = compDataGridView.DataSource as BindingSource;
            BindingSource BSMonitorTemp = monitorDataGridView.DataSource as BindingSource;
            if (checkBox1.Checked != true)
            {
                BSComputerTemp.Filter = "Deleted = 'false'";
                BSMonitorTemp.Filter = "Deleted = 'false'";
                deletedDataGridViewCheckBoxColumn.Visible = false;
                Deleted.Visible = false;

            }
            else
            {
                BSComputerTemp.Filter = "Deleted = 'true' or Deleted = 'false'";
                BSMonitorTemp.Filter = "Deleted = 'true' or Deleted = 'false'";
                deletedDataGridViewCheckBoxColumn.Visible = true;
                Deleted.Visible = true;
            }
        }


        private void allouEditEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compEventDataGridView.ReadOnly = (compEventDataGridView.ReadOnly == false);
            
            if (compEventDataGridView.ReadOnly)
                AlloouEditEventsToolStripMenuItem.Text = "Разрешить редактировать список событий";
            else
                AlloouEditEventsToolStripMenuItem.Text = "Запретить редактировать список событий";
        }



        private void моделиМониторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.MonitorModel.Edit();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            C1.SaveData();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.Add();
        }



        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.ChangeNumber(monitorDataGridView.DataSource as BindingSource);
        }

        private void RoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.ChangeRoom(monitorDataGridView.DataSource as BindingSource);
        }

        private void DepartmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            C1.Monitor.ChangeDepartment(monitorDataGridView.DataSource as BindingSource);
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.ChangeMonitorModel(monitorDataGridView.DataSource as BindingSource);
        }

        private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            C1.Monitor.ShowInfo(monitorDataGridView.DataSource as BindingSource, true);
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Computer.ChangeMonitor(compDataGridView.DataSource as BindingSource);
        }

        private void ComputerMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Computer.Move(compDataGridView.DataSource as BindingSource);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.ShowInfo(monitorDataGridView.DataSource as BindingSource, false);
        }

       

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Computer.DisconectMonitor(compDataGridView.DataSource as BindingSource);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1.SimpleDevice.Add();
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.ChangeComputer(monitorDataGridView.DataSource as BindingSource);
        }

      

        private void monitorDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void monitorEventDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void compDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void disconnectMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                C1.Computer.DisconectMonitor(compDataGridView.DataSource as BindingSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void отключитьОтКомпьютераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                C1.Monitor.DisconectComputer(monitorDataGridView.DataSource as BindingSource);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void monitorDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var hti = monitorDataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex > -1)
                {
                    monitorDataGridView.ClearSelection();
                    monitorDataGridView.Rows[hti.RowIndex].Selected = true;
                    C1.BSMonitor.Position = hti.RowIndex;
                }
            }
        }

        private void compDatagridView_formatting(int RowIndex, int ColumnIndex, List<string> SelectedUser, List<string> SelectedNumbers)
        {
            DataGridViewCell cell = compDataGridView.Rows[RowIndex].Cells[ColumnIndex];
            Color cellColor = cell.Style.BackColor;
            if ((DateTime)compDataGridView.Rows[RowIndex].Cells[15].Value > DateTime.Now)
            {
                cell.Style.BackColor = Color.LightGreen;
            }

            switch (ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    if (SelectedNumbers.Contains(cell.Value as string))
                    {
                        cell.ErrorText = "Повторяющийся инвентарный номер!";
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                    break;
                case 4:
                    int r = 0;
                    if (compDataGridView.Rows[RowIndex].Cells[17].Value is Int32)
                    {
                        r = (int)compDataGridView.Rows[RowIndex].Cells[17].Value;
                        switch (r)
                        {
                            case 0:
                            case 1:
                            case 2:
                                cell.Style.BackColor = Color.Red;
                                break;
                            case 3:
                            case 4:
                                cell.Style.BackColor = Color.OrangeRed;
                                break;
                            case 5:
                            case 6:
                                cell.Style.BackColor = Color.Orange;
                                break;
                            case 7:
                            case 8:
                                cell.Style.BackColor = Color.Yellow;
                                break;
                            case 9:
                            case 10:
                                cell.Style.BackColor = Color.LightGreen;
                                break;
                            default:
                                break;
                        }
                    }
                    
                    
                    break;
                case 5:
                    break;
                case 6:
                    if (SelectedUser.Contains(cell.Value as string))
                    {
                        cell.ErrorText = "Больше одного компьютера";
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    if (cell.Value as string == "" | cell.Value as string == null)
                    {
                        cell.ErrorText = "Нет монитора!!!";
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                    break;
                case 14:
                    break;
                case 15:
                    break;
                default:
                    break;
            }
        }

        private void monitorDatagridView_formatting(int RowIndex, int ColumnIndex, List<string> SelectedNumbers)
        {
            DataGridViewCell cell = monitorDataGridView.Rows[RowIndex].Cells[ColumnIndex];

            if ((DateTime)monitorDataGridView.Rows[RowIndex].Cells[6].Value > DateTime.Now)
            {
                cell.Style.BackColor = Color.LightGreen;
            }

            switch (ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    if (SelectedNumbers.Contains(cell.Value as string))
                    {
                        cell.ErrorText = "Повторяющийся инвентарный номер!";
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                    break;
                case 4:

                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    if (cell.Value as string == null)
                    {
                        cell.ErrorText = "Нет компьютера";
                    }
                    else
                    {
                        cell.ErrorText = string.Empty;
                    }
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                default:
                    break;
            }
        }





        private List<string> FindDoublecatedUsers()
        {
            List<string> Users = new List<string>();
            List<string> SelectedUser = new List<string>();
            string user = null;
            foreach (DS_NiheComputers.CompRow r in C1.DS.Comp)
            {
                if (r.User != null && r.User != "")
                    Users.Add(r.User);
            }
            for (int i = 0; i < Users.Count;)
            {
                user = Users[i];
                Users.RemoveAt(i);
                if (Users.Contains(user))
                    SelectedUser.Add(user);
            }

            return SelectedUser;
        }
        private List<string> FindDoublecatedCompNumbers()
        {
            List<string> Numbers = new List<string>();
            List<string> SelectedNumbers = new List<string>();
            string Number = null;
            foreach (DS_NiheComputers.CompRow r in C1.DS.Comp)
            {
                if (r.Num != null && r.Num != "")
                    Numbers.Add(r.Num);
            }
            for (int i = 0; i < Numbers.Count;)
            {
                Number = Numbers[i];
                Numbers.RemoveAt(i);
                if (Numbers.Contains(Number))
                    SelectedNumbers.Add(Number);
            }
            return SelectedNumbers;
        }
        private List<string> FindDoublecatedMonitorNumbers()
        {
            List<string> Numbers = new List<string>();
            List<string> SelectedNumbers = new List<string>();
            string Number = null;
            foreach (DS_NiheComputers.MonitorRow r in C1.DS.Monitor)
            {
                if (r.Number != null && r.Number != "")
                    Numbers.Add(r.Number);
            }
            for (int i = 0; i < Numbers.Count; )
            {
                Number = Numbers[i];
                Numbers.RemoveAt(i);
                if (Numbers.Contains(Number))
                    SelectedNumbers.Add(Number);
            }
            return SelectedNumbers;
        }

        private void compDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            List<string> SelectedUser = FindDoublecatedUsers();
            List<string> SelectedNumbers = FindDoublecatedCompNumbers();
            if(e.RowIndex >=0)
                compDatagridView_formatting(e.RowIndex, e.ColumnIndex, SelectedUser, SelectedNumbers);
        }
        private void monitorDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            List<string> SelectedNumbers = FindDoublecatedMonitorNumbers();
            if (e.RowIndex >= 0)
                monitorDatagridView_formatting(e.RowIndex, e.ColumnIndex, SelectedNumbers);
        }




        private void simpleEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                C1.Computer.SimpleEdit(compDataGridView.DataSource as BindingSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStripComputer_Opening(object sender, CancelEventArgs e)
        {
            if (compDataGridView.SelectedRows.Count < 1)
            {
                foreach (ToolStripItem  i in contextMenuStripComputer.Items)
                {
                    i.Enabled = false;
                }
                contextMenuStripComputer.Items["изменитьToolStripMenuItem"].Enabled = true;
            }
        }

        private void moveMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Monitor.Move(monitorDataGridView.DataSource as BindingSource);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.compDataGridView
            .GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    String HTData = compDataGridView.GetClipboardContent().GetText(TextDataFormat.Html);
                    int StartLen = HTData.Length;
                    byte[] UTF8Data=Encoding.UTF8.GetBytes(HTData);
                    HTData = Encoding.Default.GetString(UTF8Data);
                    int LenAdd = HTData.Length - StartLen;
                    String HTMLLenData = HTData.Substring(HTData.IndexOf("EndHTML") + 8, 8);
                    String FragmentLenData = HTData.Substring(HTData.IndexOf("EndFragment") + 12, 8);
                    String NewHTMLLenData = (int.Parse(HTMLLenData) + LenAdd).ToString("D8");
                    String NewFragmentLenData = (int.Parse(FragmentLenData) + LenAdd).ToString("D8");
                    HTData = HTData.Replace("EndHTML:" + HTMLLenData, "EndHTML:" + NewHTMLLenData);
                    HTData = HTData.Replace("EndFragment:" + FragmentLenData, "EndFragment:" + NewFragmentLenData);
                    byte[] DataToStream = Encoding.Default.GetBytes(HTData);
                    MemoryStream DataToClipBoard = new MemoryStream(DataToStream);
                    Clipboard.SetData(DataFormats.Html, DataToClipBoard);
                    DataToClipBoard.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void compDataGridView_Enter(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = C1.BSComp;
        }

        private void compEventDataGridView_Enter(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = C1.BSCompEvent;
        }

        private void monitorDataGridView_Enter(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = C1.BSMonitor;
        }

        private void monitorEventDataGridView_Enter(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = C1.BSMonitorEvent;
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.Computer.EditDescription(compDataGridView.DataSource as BindingSource);
        }

        private void AddSimpleDeviceMenuItem_Click(object sender, EventArgs e)
        {
            C1.SimpleDevice.Add();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1.SaveData();
        }
    }


    //Класс для ускорения отображения Датагридвью
    public class DataGridViewEx : DataGridView
    {
        public DataGridViewEx()
            : base()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
