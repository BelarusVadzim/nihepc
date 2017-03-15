namespace nihe_computers2
{
    partial class Form08Processor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form08Processor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.processorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.processorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.processorDataGridView = new System.Windows.Forms.DataGridView();
            this.Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.socketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingNavigator)).BeginInit();
            this.processorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processorBindingNavigator
            // 
            this.processorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.processorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.processorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.processorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.processorBindingNavigatorSaveItem});
            this.processorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.processorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.processorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.processorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.processorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.processorBindingNavigator.Name = "processorBindingNavigator";
            this.processorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.processorBindingNavigator.Size = new System.Drawing.Size(718, 25);
            this.processorBindingNavigator.TabIndex = 0;
            this.processorBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
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
            // processorBindingNavigatorSaveItem
            // 
            this.processorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.processorBindingNavigatorSaveItem.Enabled = false;
            this.processorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("processorBindingNavigatorSaveItem.Image")));
            this.processorBindingNavigatorSaveItem.Name = "processorBindingNavigatorSaveItem";
            this.processorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.processorBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // processorDataGridView
            // 
            this.processorDataGridView.AllowUserToAddRows = false;
            this.processorDataGridView.AutoGenerateColumns = false;
            this.processorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.processorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sort,
            this.nameDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.socketIDDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.FullName});
            this.processorDataGridView.DataSource = this.processorBindingSource;
            this.processorDataGridView.Location = new System.Drawing.Point(12, 28);
            this.processorDataGridView.Name = "processorDataGridView";
            this.processorDataGridView.RowHeadersVisible = false;
            this.processorDataGridView.RowTemplate.Height = 24;
            this.processorDataGridView.Size = new System.Drawing.Size(651, 220);
            this.processorDataGridView.TabIndex = 1;
            this.processorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processorDataGridView_CellContentClick);
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.nameDataGridViewTextBoxColumn.FillWeight = 40F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.frequencyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.frequencyDataGridViewTextBoxColumn.FillWeight = 30F;
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Частота (ГГЦ)";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            // 
            // socketIDDataGridViewTextBoxColumn
            // 
            this.socketIDDataGridViewTextBoxColumn.DataPropertyName = "SocketID";
            this.socketIDDataGridViewTextBoxColumn.DataSource = this.socketBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.socketIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.socketIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.socketIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.socketIDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.socketIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socketIDDataGridViewTextBoxColumn.HeaderText = "Тип сокета";
            this.socketIDDataGridViewTextBoxColumn.Name = "socketIDDataGridViewTextBoxColumn";
            this.socketIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.socketIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.socketIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // socketBindingSource
            // 
            this.socketBindingSource.DataMember = "Socket";
            this.socketBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.DataSource = this.vendorBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.vendorIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.vendorIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.vendorIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vendorIDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.vendorIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "Произв.";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vendorIDDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Полное название";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // processorBindingSource
            // 
            this.processorBindingSource.DataMember = "Processor";
            this.processorBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(78, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(667, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form08Processor
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(718, 285);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.processorDataGridView);
            this.Controls.Add(this.processorBindingNavigator);
            this.Name = "Form08Processor";
            this.Text = "Типы процессоров";
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingNavigator)).EndInit();
            this.processorBindingNavigator.ResumeLayout(false);
            this.processorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
        private System.Windows.Forms.BindingNavigator processorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton processorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView processorDataGridView;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.BindingSource socketBindingSource;
        private System.Windows.Forms.BindingSource processorBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn socketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}