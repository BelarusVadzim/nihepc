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
    public partial class Form10HDD : Form
    {
        public Form10HDD(DS_NiheComputers DS, BindingSource BSHDD)
        {
            this.DS = DS;
            this.BSHDD = BSHDD;
            InitializeComponent();
            hDDDataGridView.DataSource = BSHDD;
            hDDBindingNavigator.BindingSource = BSHDD;
            dataGridViewTextBoxColumn2.DataSource = DS.HDDType;
            dataGridViewTextBoxColumn5.DataSource = DS.Vendor;
        }
        BindingSource BSHDD = null;
        DS_NiheComputers DS = null;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DS.AcceptChanges();
        }
    }
}
