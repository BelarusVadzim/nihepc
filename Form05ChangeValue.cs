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
    public partial class Form05ChangeValue : Form
    {
        
        public Form05ChangeValue(DialogComputer D)
        {
            InitializeComponent();
            this.D = D;
            this.comboBox1.Visible = false;
        }

        public Form05ChangeValue(DialogStringValueEdit D)
        {
            InitializeComponent();
            this.DialogString = D;
            this.comboBox1.Visible = false;
            this.textBox1.Text = D.StartText;
            this.label2.Text = D.StartText;
        }

        public Form05ChangeValue(DialogListValueEdit D)
        {
            InitializeComponent();
            this.DialogList = D;
            this.comboBox1.Visible = true;
            this.textBox1.Visible = false;
           
            this.comboBox1.DataSource = DialogList.ValuesList;

            this.comboBox1.ValueMember = "id";
            //this.comboBox1.SelectedValue = DialogList.StartValue;
            this.label2.Visible = false;
            this.label1.Visible = false;
            initForm(D);
        }

        DialogComputer D = null;
        DialogStringValueEdit DialogString = null;
        DialogListValueEdit DialogList = null;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Width = 434;
                this.textBox2.Visible = true;
            }
            else
            {
                this.Width = 285;
                this.textBox2.Visible = false;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (textBox1.Visible == true)
            {
                this.DialogString.EndText = textBox1.Text;
                this.DialogString.Date = dateTimePicker1.Value;
                this.DialogString.ExtendedInfo = textBox2.Text;
                this.DialogString.AcceptChanges();
            }
            else
            {
                if (comboBox1.SelectedValue != null)
                {
                    this.DialogList.EndValue = (int)comboBox1.SelectedValue;
                    this.DialogList.Date = dateTimePicker1.Value;
                    this.DialogList.ExtendedInfo = textBox2.Text;
                    this.DialogList.AcceptChanges();
                }
            }

            this.Close();
        }

        private void initForm(DialogListValueEdit D)
        {
            this.comboBox1.DisplayMember = "FullName";
            switch (D.OperationName)
            {
                case Operation.ChahgeComputer:
                    this.comboBox1.DisplayMember = "FullName2";
                    this.Text = "Выбор компьютера";
                    break;
                case Operation.ChangeDepartment:
                    this.Text = "Выбор структурного подразделения";
                    break;
                case Operation.ChangeHDD:
                    this.Text = "Выбор жесткого диска";
                    break;
                case Operation.ChangeMonitor:
                    this.Text = "Выбор монитора";
                    break;
                case Operation.ChangeMonitorModel:
                    this.Text = "Выбор модели монитора";
                    break;
                case Operation.ChangeOS:
                    this.Text = "Выбор операционной системы";
                    break;
                case Operation.ChangeProcessor:
                    this.Text = "Выбор процессора";
                    break;
                default:
                    this.comboBox1.DisplayMember = "FullName";
                    break;
            }
        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            checkBox2.Visible = (textBox1.Visible != false);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = checkBox2.Checked;
            if (textBox1.Multiline)
                textBox1.Height = 50;
        }


    }
}
