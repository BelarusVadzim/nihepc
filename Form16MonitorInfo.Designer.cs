namespace nihe_computers2
{
    partial class Form16MonitorInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.monitorEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitorEventDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorEventDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monitorEventBindingSource
            // 
            this.monitorEventBindingSource.DataMember = "MonitorEvent";
            this.monitorEventBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // monitorEventDataGridView
            // 
            this.monitorEventDataGridView.AllowUserToAddRows = false;
            this.monitorEventDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorEventDataGridView.AutoGenerateColumns = false;
            this.monitorEventDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monitorEventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitorEventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.EventName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.monitorEventDataGridView.DataSource = this.monitorEventBindingSource;
            this.monitorEventDataGridView.Location = new System.Drawing.Point(3, 35);
            this.monitorEventDataGridView.Name = "monitorEventDataGridView";
            this.monitorEventDataGridView.ReadOnly = true;
            this.monitorEventDataGridView.RowHeadersVisible = false;
            this.monitorEventDataGridView.RowTemplate.Height = 24;
            this.monitorEventDataGridView.Size = new System.Drawing.Size(823, 95);
            this.monitorEventDataGridView.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Информация о мониторе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Списать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 91);
            this.textBox1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(523, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 179);
            this.panel1.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid1.Size = new System.Drawing.Size(514, 179);
            this.propertyGrid1.TabIndex = 23;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.monitorEventDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(831, 370);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(3, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "EventName";
            this.EventName.FillWeight = 60F;
            this.EventName.HeaderText = "Тип события";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Info";
            this.dataGridViewTextBoxColumn3.HeaderText = "Информация о событии";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExtendedInfo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дополнительная информация";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Form16MonitorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 370);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form16MonitorInfo";
            this.Text = "Информация о мониторе";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form16MonitorInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorEventDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.BindingSource monitorEventBindingSource;
        private System.Windows.Forms.DataGridView monitorEventDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}