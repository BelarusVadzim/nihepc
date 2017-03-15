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
    public partial class Form07CompInfo : Form
    {
        

        public Form07CompInfo(Class1 C1, DialogComputer D)
        {
            this.D = D;
            InitializeComponent();
            string filterString = string.Format("CompGUID = '{0}'", D.Comp.GUID);
            this.BS = C1.BSCompEvent;
            this.BS.Filter = filterString;
            this.C1 = C1;

            this.panel2.Visible = D.ShowDelButton;
            this.eventCompDataGridView.DataSource = BS;
            this.panel2.Enabled = !D.Comp.Deleted;
            this.propertyGrid1.SelectedObject = D.Comp;
            if (D.ShowDelButton)
            {
                this.Text = "Списание компьютера";
                this.Width = 850;
            }
            else
            {
                this.Text = "Информация о компьютере";
                this.Width = 450;
                this.propertyGrid1.Dock = DockStyle.Fill;
            }
        }

        DialogComputer D = null;
        Class1 C1 = null;
        BindingSource BS = null;

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult DR = MessageBox.Show("Точно списать этот компьютер?", "Списание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DR == System.Windows.Forms.DialogResult.OK)
            {
                D.Date = dateTimePicker1.Value;
                C1.Computer.Remove(D);
                this.panel2.Enabled = false;
            }
        }

        private void Form07CompInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            BS.RemoveFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D.AcceptChanges();
            this.Close();
        }

      
    }
}
