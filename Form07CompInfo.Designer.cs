namespace nihe_computers2
{
    partial class Form07CompInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form07CompInfo));
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.eventCompDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendedInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventCompBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbHistory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCompDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCompBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
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
            // eventCompDataGridView
            // 
            this.eventCompDataGridView.AllowUserToAddRows = false;
            this.eventCompDataGridView.AllowUserToDeleteRows = false;
            this.eventCompDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.eventCompDataGridView.AutoGenerateColumns = false;
            this.eventCompDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventCompDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.eventCompDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventCompDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.extendedInfoDataGridViewTextBoxColumn});
            this.eventCompDataGridView.DataSource = this.eventCompBindingSource;
            this.eventCompDataGridView.Location = new System.Drawing.Point(3, 39);
            this.eventCompDataGridView.MultiSelect = false;
            this.eventCompDataGridView.Name = "eventCompDataGridView";
            this.eventCompDataGridView.ReadOnly = true;
            this.eventCompDataGridView.RowHeadersVisible = false;
            this.eventCompDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventCompDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eventCompDataGridView.Size = new System.Drawing.Size(833, 119);
            this.eventCompDataGridView.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 20F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 70F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "Тип события";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Инфо";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extendedInfoDataGridViewTextBoxColumn
            // 
            this.extendedInfoDataGridViewTextBoxColumn.DataPropertyName = "ExtendedInfo";
            this.extendedInfoDataGridViewTextBoxColumn.HeaderText = "Дополнительно";
            this.extendedInfoDataGridViewTextBoxColumn.Name = "extendedInfoDataGridViewTextBoxColumn";
            this.extendedInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventCompBindingSource
            // 
            this.eventCompBindingSource.DataMember = "EventComp";
            this.eventCompBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHistory.Location = new System.Drawing.Point(3, 11);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(187, 25);
            this.lbHistory.TabIndex = 4;
            this.lbHistory.Text = "История изменений";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(540, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 191);
            this.panel2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 26);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 80);
            this.textBox1.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(88, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Списать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 11);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid1.Size = new System.Drawing.Size(534, 191);
            this.propertyGrid1.TabIndex = 28;
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
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbHistory);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.eventCompDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(837, 419);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 30;
            // 
            // Form07CompInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 419);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form07CompInfo";
            this.Text = "Информация о компьютере";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form07CompInfo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCompDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCompBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.DataGridView eventCompDataGridView;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource eventCompBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extendedInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}