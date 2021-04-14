namespace MessengerBDApp
{
    partial class FormDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialog));
            System.Windows.Forms.Label идентификатор_чатаLabel;
            System.Windows.Forms.Label количество_участниковLabel;
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.беседаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.беседаTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.БеседаTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.беседаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.беседаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.идентификатор_чатаTextBox = new System.Windows.Forms.TextBox();
            this.количество_участниковTextBox = new System.Windows.Forms.TextBox();
            идентификатор_чатаLabel = new System.Windows.Forms.Label();
            количество_участниковLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.беседаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.беседаBindingNavigator)).BeginInit();
            this.беседаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // беседаBindingSource
            // 
            this.беседаBindingSource.DataMember = "Беседа";
            this.беседаBindingSource.DataSource = this.messengerDataSet;
            // 
            // беседаTableAdapter
            // 
            this.беседаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БеседаTableAdapter = this.беседаTableAdapter;
            this.tableAdapterManager.КаналTableAdapter = null;
            this.tableAdapterManager.Параметры_уведомленийTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Секретный_чатTableAdapter = null;
            this.tableAdapterManager.СообщениеTableAdapter = null;
            this.tableAdapterManager.Тип_чатаTableAdapter = null;
            this.tableAdapterManager.ЧатTableAdapter = null;
            // 
            // беседаBindingNavigator
            // 
            this.беседаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.беседаBindingNavigator.BindingSource = this.беседаBindingSource;
            this.беседаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.беседаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.беседаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.беседаBindingNavigatorSaveItem});
            this.беседаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.беседаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.беседаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.беседаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.беседаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.беседаBindingNavigator.Name = "беседаBindingNavigator";
            this.беседаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.беседаBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.беседаBindingNavigator.TabIndex = 0;
            this.беседаBindingNavigator.Text = "bindingNavigator1";
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
            // беседаBindingNavigatorSaveItem
            // 
            this.беседаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.беседаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("беседаBindingNavigatorSaveItem.Image")));
            this.беседаBindingNavigatorSaveItem.Name = "беседаBindingNavigatorSaveItem";
            this.беседаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.беседаBindingNavigatorSaveItem.Text = "Save Data";
            this.беседаBindingNavigatorSaveItem.Click += new System.EventHandler(this.беседаBindingNavigatorSaveItem_Click);
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
            this.идентификатор_чатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.беседаBindingSource, "Идентификатор_чата", true));
            this.идентификатор_чатаTextBox.Location = new System.Drawing.Point(147, 32);
            this.идентификатор_чатаTextBox.Name = "идентификатор_чатаTextBox";
            this.идентификатор_чатаTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_чатаTextBox.TabIndex = 2;
            // 
            // количество_участниковLabel
            // 
            количество_участниковLabel.AutoSize = true;
            количество_участниковLabel.Location = new System.Drawing.Point(12, 61);
            количество_участниковLabel.Name = "количество_участниковLabel";
            количество_участниковLabel.Size = new System.Drawing.Size(129, 13);
            количество_участниковLabel.TabIndex = 3;
            количество_участниковLabel.Text = "Количество участников:";
            // 
            // количество_участниковTextBox
            // 
            this.количество_участниковTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.беседаBindingSource, "Количество_участников", true));
            this.количество_участниковTextBox.Location = new System.Drawing.Point(147, 58);
            this.количество_участниковTextBox.Name = "количество_участниковTextBox";
            this.количество_участниковTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_участниковTextBox.TabIndex = 4;
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 81);
            this.Controls.Add(идентификатор_чатаLabel);
            this.Controls.Add(this.идентификатор_чатаTextBox);
            this.Controls.Add(количество_участниковLabel);
            this.Controls.Add(this.количество_участниковTextBox);
            this.Controls.Add(this.беседаBindingNavigator);
            this.Name = "FormDialog";
            this.Text = "Беседы";
            this.Load += new System.EventHandler(this.FormDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.беседаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.беседаBindingNavigator)).EndInit();
            this.беседаBindingNavigator.ResumeLayout(false);
            this.беседаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource беседаBindingSource;
        private MessengerDataSetTableAdapters.БеседаTableAdapter беседаTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator беседаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton беседаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox идентификатор_чатаTextBox;
        private System.Windows.Forms.TextBox количество_участниковTextBox;
    }
}