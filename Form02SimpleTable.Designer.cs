namespace nihe_computers2
{
    partial class Form02SimpleTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form02SimpleTable));
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.AllowUserToAddRows = false;
            this.vendorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorDataGridView.AutoGenerateColumns = false;
            this.vendorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sort,
            this.nameDataGridViewTextBoxColumn,
            this.FullName});
            this.vendorDataGridView.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.vendorDataGridView.Location = new System.Drawing.Point(0, 28);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.RowHeadersVisible = false;
            this.vendorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorDataGridView.Size = new System.Drawing.Size(311, 175);
            this.vendorDataGridView.TabIndex = 1;
            // 
            // Sort
            // 
            this.Sort.DataPropertyName = "Sort";
            this.Sort.FillWeight = 20F;
            this.Sort.HeaderText = "Sort";
            this.Sort.Name = "Sort";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Полное наименование";
            this.FullName.Name = "FullName";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Department";
            this.bindingSource1.DataSource = this.dS_NiheComputers;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(0, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(61, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUP
            // 
            this.btnUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUP.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUP.Location = new System.Drawing.Point(317, 28);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(37, 32);
            this.btnUP.TabIndex = 7;
            this.btnUP.Text = "Up";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(317, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "Down";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(354, 25);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // Form02SimpleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 235);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vendorDataGridView);
            this.Name = "Form02SimpleTable";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2SimpleTable_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.DataGridView vendorDataGridView;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    }
}