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
    public partial class Form06DeviceAdd : Form
    {

        public Form06DeviceAdd(Class1 C1, DialogSimpleDeviceAdd D)
        {
            InitializeComponent();
            this.C1 = C1;
            this.D = D;
            comboBox2.DataSource = C1.BSVendor;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";

            comboBox1.DataSource = C1.BSSimpleDeviceType;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

            comboBox3.DataSource = C1.BSDepartment;
            comboBox3.DisplayMember = "FullName";
            comboBox3.ValueMember = "ID";
        }


       private Class1  C1 = null;
       private DialogSimpleDeviceAdd D = null;


        private void button2_Click(object sender, EventArgs e)
        {
            C1.Vendor.Edit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1.DeviceType.Edit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            D.Date = dateTimePicker1.Value;
            D.PurchaseDate = dateTimePicker1.Value;
            D.WarantyDate = numericUpDown1.Value;
            D.Number = textBox2.Text;
            D.Room = textBox3.Text;
            D.DepartmentID = (int)comboBox3.SelectedValue;
            D.Username = textBox6.Text;
            D.VendorID = (int)comboBox2.SelectedValue;
            D.Description = textBox4.Text;
            D.ExtendedInfo = textBox5.Text;
            D.Name = textBox1.Text;
            D.SimpleDeviceTypeID = (int)comboBox1.SelectedValue;
            D.AcceptChanges();
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
