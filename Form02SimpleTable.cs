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
    public partial class Form02SimpleTable : Form
    {
        public Form02SimpleTable(BindingSource BS)
        {
            InitializeComponent();
            this.BS = BS;
            vendorDataGridView.DataSource = BS;
            bindingNavigator1.BindingSource = BS;
            BS.Sort = "sort";
            if (BS.DataMember != "Department")
                vendorDataGridView.Columns.Remove("FullName");
            else
            {
                vendorDataGridView.Columns["FullName"].HeaderCell.Value = "Краткое опиание";
                vendorDataGridView.Columns["nameDataGridViewTextBoxColumn"].HeaderCell.Value = "Полное название для отчетов";
            }
        }

        BindingSource BS = null;
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView drv = BS.AddNew() as DataRowView;
        }

        private void Form2SimpleTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            BS.Sort = "sort";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BS.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            DataRowView drv1 = BS.Current as DataRowView;
            int sort1 = (int)drv1["sort"];
            int sort2 =0;
            int index = BS.Position;
            if (sort1 > 0)
            {
                if (index > 0)
                {
                    sort2 = (int)(BS[index - 1] as DataRowView)["sort"];
                    if (sort1 - 1 <= sort2)
                    (BS[index - 1] as DataRowView)["sort"] = sort2 + 1;
                }
                (BS.Current as DataRowView)["sort"] = sort1 - 1;
                
                BS.EndEdit();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DataRowView drv1 = BS.Current as DataRowView;
            int sort1 = (int)drv1["sort"];
            int sort2 = 0;
            int index = BS.Position;
           
                if (index+1 < BS.Count)
                {
                    sort2 = (int)(BS[index + 1] as DataRowView)["sort"];
                    (BS[index + 1] as DataRowView)["sort"] = sort2 - 1;
                    (BS.Current as DataRowView)["sort"] = sort1 + 1;
                }
                BS.EndEdit();
        }


        

    }
}
