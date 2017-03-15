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
    public partial class Form14Disconect : Form
    {
        public Form14Disconect(DialogStringValueEdit D)
        {
            InitializeComponent();
            this.D = D;
        }

        private DialogStringValueEdit D = null;
        private void button1_Click(object sender, EventArgs e)
        {
            D.Date = dateTimePicker1.Value;
            D.ExtendedInfo = textBox1.Text;
            D.AcceptChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
