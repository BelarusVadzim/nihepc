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
    public partial class Form08Processor : Form
    {
        public Form08Processor(DS_NiheComputers DS, BindingSource BSProcessor)
        {
            this.BSProcessor = BSProcessor;
            this.BSProcessor.Sort = "Sort";
            InitializeComponent();
            processorDataGridView.DataSource = BSProcessor;
            processorBindingNavigator.BindingSource = BSProcessor;

            socketIDDataGridViewTextBoxColumn.DataSource = DS.Socket.Select("", "sort");
            vendorIDDataGridViewTextBoxColumn.DataSource = DS.Vendor;
        }

        private BindingSource BSProcessor = null;

        private void processorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
