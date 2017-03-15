namespace nihe_computers2
{
    partial class Form10HDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10HDD));
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.hDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hDDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hDDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hDDTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingNavigator)).BeginInit();
            this.hDDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDDBindingSource
            // 
            this.hDDBindingSource.DataMember = "HDD";
            this.hDDBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // hDDBindingNavigator
            // 
            this.hDDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hDDBindingNavigator.BindingSource = this.hDDBindingSource;
            this.hDDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hDDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hDDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hDDBindingNavigatorSaveItem});
            this.hDDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hDDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hDDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hDDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hDDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hDDBindingNavigator.Name = "hDDBindingNavigator";
            this.hDDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hDDBindingNavigator.Size = new System.Drawing.Size(611, 25);
            this.hDDBindingNavigator.TabIndex = 0;
            this.hDDBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // hDDBindingNavigatorSaveItem
            // 
            this.hDDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hDDBindingNavigatorSaveItem.Enabled = false;
            this.hDDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hDDBindingNavigatorSaveItem.Image")));
            this.hDDBindingNavigatorSaveItem.Name = "hDDBindingNavigatorSaveItem";
            this.hDDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hDDBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // hDDDataGridView
            // 
            this.hDDDataGridView.AllowUserToAddRows = false;
            this.hDDDataGridView.AutoGenerateColumns = false;
            this.hDDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hDDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hDDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.hDDDataGridView.DataSource = this.hDDBindingSource;
            this.hDDDataGridView.Location = new System.Drawing.Point(12, 28);
            this.hDDDataGridView.Name = "hDDDataGridView";
            this.hDDDataGridView.RowHeadersVisible = false;
            this.hDDDataGridView.RowTemplate.Height = 24;
            this.hDDDataGridView.Size = new System.Drawing.Size(519, 214);
            this.hDDDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VendorID";
            this.dataGridViewTextBoxColumn5.DataSource = this.vendorBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn5.HeaderText = "VendorID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HDDTypeID";
            this.dataGridViewTextBoxColumn2.DataSource = this.hDDTypeBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "HDDTypeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            // 
            // hDDTypeBindingSource
            // 
            this.hDDTypeBindingSource.DataMember = "HDDType";
            this.hDDTypeBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn4.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(90, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form10HDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 283);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hDDDataGridView);
            this.Controls.Add(this.hDDBindingNavigator);
            this.Name = "Form10HDD";
            this.Text = "Типы жестких дисков";
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingNavigator)).EndInit();
            this.hDDBindingNavigator.ResumeLayout(false);
            this.hDDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.BindingSource hDDBindingSource;
        private System.Windows.Forms.BindingNavigator hDDBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hDDBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hDDDataGridView;
        private System.Windows.Forms.BindingSource hDDTypeBindingSource;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}