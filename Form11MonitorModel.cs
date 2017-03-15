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
    public partial class Form11MonitorModel : Form
    {
        public Form11MonitorModel(DS_NiheComputers DS, BindingSource BSMonitorModel)
        {
            InitializeComponent();
            this.BSMonitorModel = BSMonitorModel;
            this.monitorModelDataGridView.DataSource = BSMonitorModel;
            this.monitorModelBindingNavigator.BindingSource = BSMonitorModel;
            this.dataGridViewTextBoxColumn3.DataSource = DS.Vendor;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
        }

        BindingSource BSMonitorModel = null;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
