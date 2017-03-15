namespace nihe_computers2
{
    partial class Form09RAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form09RAM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.rAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rAMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rAMDataGridView = new System.Windows.Forms.DataGridView();
            this.Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rAMTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingNavigator)).BeginInit();
            this.rAMBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rAMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAMBindingSource
            // 
            this.rAMBindingSource.DataMember = "RAM";
            this.rAMBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // rAMBindingNavigator
            // 
            this.rAMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rAMBindingNavigator.BindingSource = this.rAMBindingSource;
            this.rAMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rAMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rAMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rAMBindingNavigatorSaveItem});
            this.rAMBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rAMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rAMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rAMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rAMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rAMBindingNavigator.Name = "rAMBindingNavigator";
            this.rAMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rAMBindingNavigator.Size = new System.Drawing.Size(653, 25);
            this.rAMBindingNavigator.TabIndex = 0;
            this.rAMBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rAMBindingNavigatorSaveItem
            // 
            this.rAMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rAMBindingNavigatorSaveItem.Enabled = false;
            this.rAMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rAMBindingNavigatorSaveItem.Image")));
            this.rAMBindingNavigatorSaveItem.Name = "rAMBindingNavigatorSaveItem";
            this.rAMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rAMBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // rAMDataGridView
            // 
            this.rAMDataGridView.AllowUserToAddRows = false;
            this.rAMDataGridView.AutoGenerateColumns = false;
            this.rAMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rAMDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sort,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.FullName});
            this.rAMDataGridView.DataSource = this.rAMBindingSource;
            this.rAMDataGridView.Location = new System.Drawing.Point(12, 39);
            this.rAMDataGridView.Name = "rAMDataGridView";
            this.rAMDataGridView.RowHeadersVisible = false;
            this.rAMDataGridView.Size = new System.Drawing.Size(573, 234);
            this.rAMDataGridView.TabIndex = 1;
            // 
            // Sort
            // 
            this.Sort.DataPropertyName = "Sort";
            this.Sort.FillWeight = 10F;
            this.Sort.HeaderText = "№";
            this.Sort.Name = "Sort";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Объм (Гб)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RAMTypeID";
            this.dataGridViewTextBoxColumn3.DataSource = this.rAMTypeBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип памяти";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            // 
            // rAMTypeBindingSource
            // 
            this.rAMTypeBindingSource.DataMember = "RAMType";
            this.rAMTypeBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Полное наименование";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form09RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 312);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rAMDataGridView);
            this.Controls.Add(this.rAMBindingNavigator);
            this.Name = "Form09RAM";
            this.Text = "Тпы оперативной памяти";
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingNavigator)).EndInit();
            this.rAMBindingNavigator.ResumeLayout(false);
            this.rAMBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rAMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.BindingSource rAMBindingSource;
        private System.Windows.Forms.BindingNavigator rAMBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rAMBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rAMDataGridView;
        private System.Windows.Forms.BindingSource rAMTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}