using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nihe_computers2
{
    public partial class Form12MonitorAdd : Form
    {
        public Form12MonitorAdd(DS_NiheComputers DS, DialogMonitorAdd Dialog)
        {
            this.DS = DS;
            this.Dialog = Dialog;
            InitializeComponent();
            Init();
        }

        DialogMonitorAdd Dialog = null;
        DS_NiheComputers DS = null;


        private void Init()
        {
            cbDepartment.DataSource = DS.Department.Select("name <> 'списан'", "sort");
            cbDepartment.ValueMember = "id";
            cbDepartment.DisplayMember = "FullName";
            cbDepartment.SelectedIndex = 0;

            cbMonitorModel.DataSource = DS.MonitorModel;
            cbMonitorModel.ValueMember = "id";
            cbMonitorModel.DisplayMember = "FullName";
            cbDepartment.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog.PurchaseDate = dateTimePicker1.Value;
            Dialog.WarantyDate = numericUpDown1.Value;
            Dialog.Number = tbNumber.Text;
            Dialog.Room = tbRoom.Text;
            Dialog.DepartmentID = (int)cbDepartment.SelectedValue;
            Dialog.MonitorModelID = (int)cbMonitorModel.SelectedValue;
            Dialog.ExtendedInfo = tbExtendedInfo.Text;
            Dialog.AcceptChanges();
            this.Close();
        }
    }
}
