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
    public partial class Form15Move : Form
    {
        public Form15Move(DS_NiheComputers DS, DialogMove D)
        {
            InitializeComponent();
            this.D = D;
            if (D.Comp != null)
            {
                lbDepartmentName.Text = D.Comp.Department;
            }
            else
            {
                lbDepartmentName.Text = D.Monic.Department;
                lbUsername.Visible = false;
                tbUsername.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                checkBox1.Visible = false;
            }
            lbRoom.Text = D.Room;
            lbUsername.Text = D.Username;
            tbUsername.Text = D.Username;
            tbRoom.Text = D.Room;
            cbDepartment.DataSource = DS.Department;
            cbDepartment.ValueMember = "id";
            cbDepartment.DisplayMember = "FullName";
            cbDepartment.SelectedValue = D.DepartmentID;
        }

        DialogMove D = null;
        private void button1_Click(object sender, EventArgs e)
        {
            D.Date = dateTimePicker1.Value;
            D.DepartmentID = (int)cbDepartment.SelectedValue;
            if (D.Room != tbRoom.Text)
            {
                D.Room = tbRoom.Text;
                D.Username = tbUsername.Text;
                D.ExtendedInfo = textBox1.Text;
                D.AcceptChanges();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbRoom_TextChanged(object sender, EventArgs e)
        {
            if (tbRoom.Text != D.Room)
            {
                cbDepartment.Enabled = true;
                tbUsername.Enabled = true;
            }
            else
            {
                cbDepartment.Enabled = false;
                tbUsername.Enabled = false;
                cbDepartment.SelectedValue = D.DepartmentID;
                tbUsername.Text = D.Username;
            }
        }
    }
}
