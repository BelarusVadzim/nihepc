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
    public partial class Form04OS : Form
    {
        public Form04OS(DS_NiheComputers DS, BindingSource BSOS)
        {
            this.BSOS = BSOS;
            BSOS.Sort = "Sort";
            InitializeComponent();
            oSDataGridView.DataSource = BSOS;
            dataGridViewTextBoxColumn2.DataSource = DS.OSName;
            dataGridViewTextBoxColumn3.DataSource = DS.ArchitectureType;
            oSBindingNavigator.BindingSource = BSOS;
        }

        BindingSource BSOS = null;

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    EventTypeBindingSource.AddNew();
        //    DataRowView drw = EventTypeBindingSource.Current as DataRowView;
        //    drw["Name"] = nameTextBox.Text;
        //    drw["GUID"] = Guid.NewGuid();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView drv1 = BSOS.Current as DataRowView;
            int sort1 = (int)drv1["sort"];
            int sort2 = 0;
            int index = BSOS.Position;
            if (sort1 > 0)
            {
                if (index > 0)
                {
                    sort2 = (int)(BSOS[index - 1] as DataRowView)["sort"];
                    if (sort1 - 1 <= sort2)
                        (BSOS[index - 1] as DataRowView)["sort"] = sort2 + 1;
                }
                (BSOS.Current as DataRowView)["sort"] = sort1 - 1;

                BSOS.EndEdit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRowView drv1 = BSOS.Current as DataRowView;
            int sort1 = (int)drv1["sort"];
            int sort2 = 0;
            int index = BSOS.Position;

            if (index + 1 < BSOS.Count)
            {
                sort2 = (int)(BSOS[index + 1] as DataRowView)["sort"];
                (BSOS[index + 1] as DataRowView)["sort"] = sort2 - 1;
                (BSOS.Current as DataRowView)["sort"] = sort1 + 1;
            }
            BSOS.EndEdit();
        }

        
    }
}
