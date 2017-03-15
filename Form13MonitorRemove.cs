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
    public partial class Form13MonitorRemove : Form
    {
        public Form13MonitorRemove()
        {
            InitializeComponent();
        }

        public Form13MonitorRemove(DialogMonitor monitorDialog)
        {
            this.monitorDialog = monitorDialog;
            InitializeComponent();
            //this.Room.Text = monitorDialog.Room;
            //this.Department.Text = monitorDialog.Department;
            //this.Number.Text = monitorDialog.Number;
            //this.CompName.Text = monitorDialog.ComputerName;
            //this.FullName.Text = monitorDialog.FullName;
        }


        DialogMonitor monitorDialog = null;



        private void button1_Click(object sender, EventArgs e)
        {
            this.monitorDialog.Deleted = true;
            this.monitorDialog.AcceptChanges();
         //   this.monitorDialog.ExtendedInfo = textBox1.Text;
            this.Close();
        }
    }
}
