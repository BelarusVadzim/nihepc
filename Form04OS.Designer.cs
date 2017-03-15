namespace nihe_computers2
{
    partial class Form04OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form04OS));
            this.dS_NiheComputers = new nihe_computers2.DS_NiheComputers();
            this.oSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oSDataGridView = new System.Windows.Forms.DataGridView();
            this.oSNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.architectureTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingNavigator)).BeginInit();
            this.oSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.architectureTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_NiheComputers
            // 
            this.dS_NiheComputers.DataSetName = "DS_NiheComputers";
            this.dS_NiheComputers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oSBindingSource
            // 
            this.oSBindingSource.DataMember = "OS";
            this.oSBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // oSBindingNavigator
            // 
            this.oSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oSBindingNavigator.BindingSource = this.oSBindingSource;
            this.oSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oSBindingNavigatorSaveItem});
            this.oSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oSBindingNavigator.Name = "oSBindingNavigator";
            this.oSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oSBindingNavigator.Size = new System.Drawing.Size(487, 25);
            this.oSBindingNavigator.TabIndex = 0;
            this.oSBindingNavigator.Text = "bindingNavigator1";
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
            // oSBindingNavigatorSaveItem
            // 
            this.oSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oSBindingNavigatorSaveItem.Enabled = false;
            this.oSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oSBindingNavigatorSaveItem.Image")));
            this.oSBindingNavigatorSaveItem.Name = "oSBindingNavigatorSaveItem";
            this.oSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oSBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // oSDataGridView
            // 
            this.oSDataGridView.AllowUserToAddRows = false;
            this.oSDataGridView.AutoGenerateColumns = false;
            this.oSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sort,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.FullName});
            this.oSDataGridView.DataSource = this.oSBindingSource;
            this.oSDataGridView.Location = new System.Drawing.Point(12, 28);
            this.oSDataGridView.Name = "oSDataGridView";
            this.oSDataGridView.RowHeadersVisible = false;
            this.oSDataGridView.RowTemplate.Height = 24;
            this.oSDataGridView.Size = new System.Drawing.Size(418, 216);
            this.oSDataGridView.TabIndex = 1;
            // 
            // oSNameBindingSource
            // 
            this.oSNameBindingSource.DataMember = "OSName";
            this.oSNameBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // architectureTypeBindingSource
            // 
            this.architectureTypeBindingSource.DataMember = "ArchitectureType";
            this.architectureTypeBindingSource.DataSource = this.dS_NiheComputers;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(436, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(436, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.Sort.DataPropertyName = "Sort";
            this.Sort.HeaderText = "Sort";
            this.Sort.Name = "Sort";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OSNameID";
            this.dataGridViewTextBoxColumn2.DataSource = this.oSNameBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип ОС";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ArchitectureTypeID";
            this.dataGridViewTextBoxColumn3.DataSource = this.architectureTypeBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn3.HeaderText = "Разрядность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Полное название";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Form04OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 290);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oSDataGridView);
            this.Controls.Add(this.oSBindingNavigator);
            this.Name = "Form04OS";
            this.Text = "Список операционных систем";
            ((System.ComponentModel.ISupportInitialize)(this.dS_NiheComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingNavigator)).EndInit();
            this.oSBindingNavigator.ResumeLayout(false);
            this.oSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.architectureTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_NiheComputers dS_NiheComputers;
    //    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource oSBindingSource;
        private System.Windows.Forms.BindingNavigator oSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView oSDataGridView;
        private System.Windows.Forms.BindingSource oSNameBindingSource;
        private System.Windows.Forms.BindingSource architectureTypeBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;

    }
}