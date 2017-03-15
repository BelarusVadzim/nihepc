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
    public partial class Form16MonitorInfo : Form
    {
        public Form16MonitorInfo(Class1 C1, DialogMonitor D)
        {
            InitializeComponent();
            string filterString = string.Format(@"monitorGuid = '{0}'", D.GUID);
            this.BS = C1.BSMonitorEvent;
            BS.Filter = filterString;
            monitorEventDataGridView.DataSource = BS;
            this.C1 = C1;
            this.D = D;
            this.panel1.Visible = D.ShowDelButton;
            this.panel1.Enabled = !D.Deleted;
            this.propertyGrid1.SelectedObject = D.monitor;
        }

        Class1 C1 = null;
        DialogMonitor D = null;
        BindingSource BS = null;
        private void button1_Click(object sender, EventArgs e)
        {
            D.ExtendedInfo = textBox1.Text;
            D.Date = dateTimePicker1.Value;
            DialogResult dr = MessageBox.Show("Точно списать?", "Списание", MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                C1.Monitor.Remove(D);
                this.panel1.Enabled = false;
            }
        }

        private void Form16MonitorInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            BS.RemoveFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
