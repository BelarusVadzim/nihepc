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
    public partial class Form09RAM : Form
    {
        public Form09RAM(DS_NiheComputers DS, BindingSource BSRAM)
        {
            this.BSRAM = BSRAM;
            InitializeComponent();
            rAMDataGridView.DataSource = BSRAM;
            dataGridViewTextBoxColumn3.DataSource = DS.RAMType;
            rAMBindingNavigator.BindingSource = BSRAM;
            //dataGridViewTextBoxColumn3.ValueMember = "ID";
            //dataGridViewTextBoxColumn3.DisplayMember = "Name";
        }
        BindingSource BSRAM = null;
    }
}
