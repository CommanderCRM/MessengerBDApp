namespace MessengerBDApp
{
    partial class FormChannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChannel));
            System.Windows.Forms.Label идентификатор_чатаLabel;
            System.Windows.Forms.Label количество_подписчиковLabel;
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.каналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каналTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.КаналTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.каналBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.каналBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.идентификатор_чатаTextBox = new System.Windows.Forms.TextBox();
            this.количество_подписчиковTextBox = new System.Windows.Forms.TextBox();
            идентификатор_чатаLabel = new System.Windows.Forms.Label();
            количество_подписчиковLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каналBindingNavigator)).BeginInit();
            this.каналBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каналBindingSource
            // 
            this.каналBindingSource.DataMember = "Канал";
            this.каналBindingSource.DataSource = this.messengerDataSet;
            // 
            // каналTableAdapter
            // 
            this.каналTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БеседаTableAdapter = null;
            this.tableAdapterManager.КаналTableAdapter = this.каналTableAdapter;
            this.tableAdapterManager.Параметры_уведомленийTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Секретный_чатTableAdapter = null;
            this.tableAdapterManager.СообщениеTableAdapter = null;
            this.tableAdapterManager.Тип_чатаTableAdapter = null;
            this.tableAdapterManager.ЧатTableAdapter = null;
            // 
            // каналBindingNavigator
            // 
            this.каналBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.каналBindingNavigator.BindingSource = this.каналBindingSource;
            this.каналBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.каналBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.каналBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.каналBindingNavigatorSaveItem});
            this.каналBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.каналBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.каналBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.каналBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.каналBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.каналBindingNavigator.Name = "каналBindingNavigator";
            this.каналBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.каналBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.каналBindingNavigator.TabIndex = 0;
            this.каналBindingNavigator.Text = "bindingNavigator1";
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
            // каналBindingNavigatorSaveItem
            // 
            this.каналBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.каналBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("каналBindingNavigatorSaveItem.Image")));
            this.каналBindingNavigatorSaveItem.Name = "каналBindingNavigatorSaveItem";
            this.каналBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.каналBindingNavigatorSaveItem.Text = "Save Data";
            this.каналBindingNavigatorSaveItem.Click += new System.EventHandler(this.каналBindingNavigatorSaveItem_Click);
            // 
            // идентификатор_чатаLabel
            // 
            идентификатор_чатаLabel.AutoSize = true;
            идентификатор_чатаLabel.Location = new System.Drawing.Point(12, 35);
            идентификатор_чатаLabel.Name = "идентификатор_чатаLabel";
            идентификатор_чатаLabel.Size = new System.Drawing.Size(115, 13);
            идентификатор_чатаLabel.TabIndex = 1;
            идентификатор_чатаLabel.Text = "Идентификатор чата:";
            // 
            // идентификатор_чатаTextBox
            // 
            this.идентификатор_чатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каналBindingSource, "Идентификатор_чата", true));
            this.идентификатор_чатаTextBox.Location = new System.Drawing.Point(155, 32);
            this.идентификатор_чатаTextBox.Name = "идентификатор_чатаTextBox";
            this.идентификатор_чатаTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_чатаTextBox.TabIndex = 2;
            // 
            // количество_подписчиковLabel
            // 
            количество_подписчиковLabel.AutoSize = true;
            количество_подписчиковLabel.Location = new System.Drawing.Point(12, 61);
            количество_подписчиковLabel.Name = "количество_подписчиковLabel";
            количество_подписчиковLabel.Size = new System.Drawing.Size(137, 13);
            количество_подписчиковLabel.TabIndex = 3;
            количество_подписчиковLabel.Text = "Количество подписчиков:";
            // 
            // количество_подписчиковTextBox
            // 
            this.количество_подписчиковTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.каналBindingSource, "Количество_пользователей", true));
            this.количество_подписчиковTextBox.Location = new System.Drawing.Point(155, 58);
            this.количество_подписчиковTextBox.Name = "количество_подписчиковTextBox";
            this.количество_подписчиковTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_подписчиковTextBox.TabIndex = 4;
            // 
            // FormChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 82);
            this.Controls.Add(идентификатор_чатаLabel);
            this.Controls.Add(this.идентификатор_чатаTextBox);
            this.Controls.Add(количество_подписчиковLabel);
            this.Controls.Add(this.количество_подписчиковTextBox);
            this.Controls.Add(this.каналBindingNavigator);
            this.Name = "FormChannel";
            this.Text = "Каналы";
            this.Load += new System.EventHandler(this.FormChannel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каналBindingNavigator)).EndInit();
            this.каналBindingNavigator.ResumeLayout(false);
            this.каналBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource каналBindingSource;
        private MessengerDataSetTableAdapters.КаналTableAdapter каналTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator каналBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton каналBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox идентификатор_чатаTextBox;
        private System.Windows.Forms.TextBox количество_подписчиковTextBox;
    }
}