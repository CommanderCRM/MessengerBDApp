namespace MessengerBDApp
{
    partial class FormChatType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatType));
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.тип_чатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_чатаTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.Тип_чатаTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.тип_чатаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.тип_чатаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.тип_чатаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_чатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_чатаBindingNavigator)).BeginInit();
            this.тип_чатаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тип_чатаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тип_чатаBindingSource
            // 
            this.тип_чатаBindingSource.DataMember = "Тип_чата";
            this.тип_чатаBindingSource.DataSource = this.messengerDataSet;
            // 
            // тип_чатаTableAdapter
            // 
            this.тип_чатаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БеседаTableAdapter = null;
            this.tableAdapterManager.КаналTableAdapter = null;
            this.tableAdapterManager.Параметры_уведомленийTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Секретный_чатTableAdapter = null;
            this.tableAdapterManager.СообщениеTableAdapter = null;
            this.tableAdapterManager.Тип_чатаTableAdapter = this.тип_чатаTableAdapter;
            this.tableAdapterManager.ЧатTableAdapter = null;
            // 
            // тип_чатаBindingNavigator
            // 
            this.тип_чатаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тип_чатаBindingNavigator.BindingSource = this.тип_чатаBindingSource;
            this.тип_чатаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тип_чатаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тип_чатаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тип_чатаBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.тип_чатаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тип_чатаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тип_чатаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тип_чатаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тип_чатаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тип_чатаBindingNavigator.Name = "тип_чатаBindingNavigator";
            this.тип_чатаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тип_чатаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.тип_чатаBindingNavigator.TabIndex = 0;
            this.тип_чатаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // тип_чатаDataGridView
            // 
            this.тип_чатаDataGridView.AutoGenerateColumns = false;
            this.тип_чатаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.тип_чатаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.тип_чатаDataGridView.DataSource = this.тип_чатаBindingSource;
            this.тип_чатаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.тип_чатаDataGridView.Location = new System.Drawing.Point(0, 25);
            this.тип_чатаDataGridView.Name = "тип_чатаDataGridView";
            this.тип_чатаDataGridView.Size = new System.Drawing.Size(800, 425);
            this.тип_чатаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Идентификатор_чата";
            this.dataGridViewTextBoxColumn3.HeaderText = "Идентификатор_чата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Тип_сущности";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип_сущности";
            this.dataGridViewTextBoxColumn4.Items.AddRange(new object[] {
            "Беседа",
            "Канал",
            "Секретный чат"});
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // тип_чатаBindingNavigatorSaveItem
            // 
            this.тип_чатаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тип_чатаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тип_чатаBindingNavigatorSaveItem.Image")));
            this.тип_чатаBindingNavigatorSaveItem.Name = "тип_чатаBindingNavigatorSaveItem";
            this.тип_чатаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.тип_чатаBindingNavigatorSaveItem.Text = "Save Data";
            this.тип_чатаBindingNavigatorSaveItem.Click += new System.EventHandler(this.тип_чатаBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Image = global::MessengerBDApp.Properties.Resources.icons8_поиск_32;
            this.toolStripButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(445, 4);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(66, 17);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // FormChatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.тип_чатаDataGridView);
            this.Controls.Add(this.тип_чатаBindingNavigator);
            this.Name = "FormChatType";
            this.Text = "Тип чата";
            this.Load += new System.EventHandler(this.FormChatType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_чатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_чатаBindingNavigator)).EndInit();
            this.тип_чатаBindingNavigator.ResumeLayout(false);
            this.тип_чатаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тип_чатаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource тип_чатаBindingSource;
        private MessengerDataSetTableAdapters.Тип_чатаTableAdapter тип_чатаTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тип_чатаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тип_чатаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView тип_чатаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
    }
}