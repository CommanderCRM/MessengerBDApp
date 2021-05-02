namespace MessengerBDApp
{
    partial class FormNotificationSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotificationSettings));
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.параметры_уведомленийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.параметры_уведомленийTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.Параметры_уведомленийTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.параметры_уведомленийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.параметры_уведомленийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.параметры_уведомленийDataGridView = new System.Windows.Forms.DataGridView();
            this.чатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.чатTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.ЧатTableAdapter();
            this.идентификаторчатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиезвукауведомленияDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.типоповещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаивремявключенияоповещенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.О_чате = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийBindingNavigator)).BeginInit();
            this.параметры_уведомленийBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // параметры_уведомленийBindingSource
            // 
            this.параметры_уведомленийBindingSource.DataMember = "Параметры_уведомлений";
            this.параметры_уведомленийBindingSource.DataSource = this.messengerDataSet;
            // 
            // параметры_уведомленийTableAdapter
            // 
            this.параметры_уведомленийTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БеседаTableAdapter = null;
            this.tableAdapterManager.КаналTableAdapter = null;
            this.tableAdapterManager.Параметры_уведомленийTableAdapter = this.параметры_уведомленийTableAdapter;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Секретный_чатTableAdapter = null;
            this.tableAdapterManager.СообщениеTableAdapter = null;
            this.tableAdapterManager.Тип_чатаTableAdapter = null;
            this.tableAdapterManager.ЧатTableAdapter = null;
            // 
            // параметры_уведомленийBindingNavigator
            // 
            this.параметры_уведомленийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.параметры_уведомленийBindingNavigator.BindingSource = this.параметры_уведомленийBindingSource;
            this.параметры_уведомленийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.параметры_уведомленийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.параметры_уведомленийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.параметры_уведомленийBindingNavigatorSaveItem});
            this.параметры_уведомленийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.параметры_уведомленийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.параметры_уведомленийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.параметры_уведомленийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.параметры_уведомленийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.параметры_уведомленийBindingNavigator.Name = "параметры_уведомленийBindingNavigator";
            this.параметры_уведомленийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.параметры_уведомленийBindingNavigator.Size = new System.Drawing.Size(994, 25);
            this.параметры_уведомленийBindingNavigator.TabIndex = 0;
            this.параметры_уведомленийBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // параметры_уведомленийBindingNavigatorSaveItem
            // 
            this.параметры_уведомленийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.параметры_уведомленийBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("параметры_уведомленийBindingNavigatorSaveItem.Image")));
            this.параметры_уведомленийBindingNavigatorSaveItem.Name = "параметры_уведомленийBindingNavigatorSaveItem";
            this.параметры_уведомленийBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.параметры_уведомленийBindingNavigatorSaveItem.Text = "Save Data";
            this.параметры_уведомленийBindingNavigatorSaveItem.Click += new System.EventHandler(this.параметры_уведомленийBindingNavigatorSaveItem_Click);
            // 
            // параметры_уведомленийDataGridView
            // 
            this.параметры_уведомленийDataGridView.AutoGenerateColumns = false;
            this.параметры_уведомленийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.параметры_уведомленийDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.идентификаторчатаDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.наличиезвукауведомленияDataGridViewCheckBoxColumn,
            this.типоповещенияDataGridViewTextBoxColumn,
            this.датаивремявключенияоповещенийDataGridViewTextBoxColumn,
            this.О_чате});
            this.параметры_уведомленийDataGridView.DataSource = this.параметры_уведомленийBindingSource;
            this.параметры_уведомленийDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.параметры_уведомленийDataGridView.Location = new System.Drawing.Point(0, 25);
            this.параметры_уведомленийDataGridView.Name = "параметры_уведомленийDataGridView";
            this.параметры_уведомленийDataGridView.Size = new System.Drawing.Size(994, 454);
            this.параметры_уведомленийDataGridView.TabIndex = 1;
            this.параметры_уведомленийDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.параметры_уведомленийDataGridView_CellContentClick);
            // 
            // чатBindingSource
            // 
            this.чатBindingSource.DataMember = "Чат";
            this.чатBindingSource.DataSource = this.messengerDataSet;
            // 
            // чатTableAdapter
            // 
            this.чатTableAdapter.ClearBeforeFill = true;
            // 
            // идентификаторчатаDataGridViewTextBoxColumn
            // 
            this.идентификаторчатаDataGridViewTextBoxColumn.DataPropertyName = "Идентификатор_чата";
            this.идентификаторчатаDataGridViewTextBoxColumn.HeaderText = "Идентификатор_чата";
            this.идентификаторчатаDataGridViewTextBoxColumn.Name = "идентификаторчатаDataGridViewTextBoxColumn";
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            // 
            // наличиезвукауведомленияDataGridViewCheckBoxColumn
            // 
            this.наличиезвукауведомленияDataGridViewCheckBoxColumn.DataPropertyName = "Наличие_звука_уведомления";
            this.наличиезвукауведомленияDataGridViewCheckBoxColumn.HeaderText = "Наличие_звука_уведомления";
            this.наличиезвукауведомленияDataGridViewCheckBoxColumn.Name = "наличиезвукауведомленияDataGridViewCheckBoxColumn";
            // 
            // типоповещенияDataGridViewTextBoxColumn
            // 
            this.типоповещенияDataGridViewTextBoxColumn.DataPropertyName = "Тип_оповещения";
            this.типоповещенияDataGridViewTextBoxColumn.HeaderText = "Тип_оповещения";
            this.типоповещенияDataGridViewTextBoxColumn.Name = "типоповещенияDataGridViewTextBoxColumn";
            // 
            // датаивремявключенияоповещенийDataGridViewTextBoxColumn
            // 
            this.датаивремявключенияоповещенийDataGridViewTextBoxColumn.DataPropertyName = "Дата_и_время_включения_оповещений";
            this.датаивремявключенияоповещенийDataGridViewTextBoxColumn.HeaderText = "Дата_и_время_включения_оповещений";
            this.датаивремявключенияоповещенийDataGridViewTextBoxColumn.Name = "датаивремявключенияоповещенийDataGridViewTextBoxColumn";
            // 
            // О_чате
            // 
            this.О_чате.DataPropertyName = "О_чате";
            this.О_чате.HeaderText = "О_чате";
            this.О_чате.Name = "О_чате";
            this.О_чате.ReadOnly = true;
            this.О_чате.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.О_чате.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormNotificationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 479);
            this.Controls.Add(this.параметры_уведомленийDataGridView);
            this.Controls.Add(this.параметры_уведомленийBindingNavigator);
            this.Name = "FormNotificationSettings";
            this.Text = "Параметры уведомлений";
            this.Load += new System.EventHandler(this.FormNotificationSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийBindingNavigator)).EndInit();
            this.параметры_уведомленийBindingNavigator.ResumeLayout(false);
            this.параметры_уведомленийBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource параметры_уведомленийBindingSource;
        private MessengerDataSetTableAdapters.Параметры_уведомленийTableAdapter параметры_уведомленийTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator параметры_уведомленийBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton параметры_уведомленийBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView параметры_уведомленийDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource чатBindingSource;
        private MessengerDataSetTableAdapters.ЧатTableAdapter чатTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn идентификаторчатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиезвукауведомленияDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типоповещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаивремявключенияоповещенийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn О_чате;
    }
}