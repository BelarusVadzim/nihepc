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
    public partial class Form9SimpleObject : Form
    {
        public Form9SimpleObject(BindingSource BSVendor)
        {
            InitializeComponent();
            this.BSVendor = BSVendor;
        }
        BindingSource BSVendor = null;

    }
}
