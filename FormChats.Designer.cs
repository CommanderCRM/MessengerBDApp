namespace MessengerBDApp
{
    partial class FormChats
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
            System.Windows.Forms.Label названиеLabel1;
            System.Windows.Forms.Label идентификатор_чатаLabel1;
            System.Windows.Forms.Label аватар_чатаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChats));
            System.Windows.Forms.Label инфоLabel;
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.чатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.чатTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.ЧатTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.чатBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.чатBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.названиеTextBox1 = new System.Windows.Forms.TextBox();
            this.идентификатор_чатаTextBox1 = new System.Windows.Forms.TextBox();
            this.аватар_чатаPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.инфоTextBox = new System.Windows.Forms.TextBox();
            названиеLabel1 = new System.Windows.Forms.Label();
            идентификатор_чатаLabel1 = new System.Windows.Forms.Label();
            аватар_чатаLabel = new System.Windows.Forms.Label();
            инфоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingNavigator)).BeginInit();
            this.чатBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.аватар_чатаPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel1
            // 
            названиеLabel1.AutoSize = true;
            названиеLabel1.Location = new System.Drawing.Point(12, 36);
            названиеLabel1.Name = "названиеLabel1";
            названиеLabel1.Size = new System.Drawing.Size(60, 13);
            названиеLabel1.TabIndex = 5;
            названиеLabel1.Text = "Название:";
            // 
            // идентификатор_чатаLabel1
            // 
            идентификатор_чатаLabel1.AutoSize = true;
            идентификатор_чатаLabel1.Location = new System.Drawing.Point(12, 62);
            идентификатор_чатаLabel1.Name = "идентификатор_чатаLabel1";
            идентификатор_чатаLabel1.Size = new System.Drawing.Size(115, 13);
            идентификатор_чатаLabel1.TabIndex = 7;
            идентификатор_чатаLabel1.Text = "Идентификатор чата:";
            // 
            // аватар_чатаLabel
            // 
            аватар_чатаLabel.AutoSize = true;
            аватар_чатаLabel.Location = new System.Drawing.Point(12, 85);
            аватар_чатаLabel.Name = "аватар_чатаLabel";
            аватар_чатаLabel.Size = new System.Drawing.Size(71, 13);
            аватар_чатаLabel.TabIndex = 9;
            аватар_чатаLabel.Text = "Аватар чата:";
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.Тип_чатаTableAdapter = null;
            this.tableAdapterManager.ЧатTableAdapter = this.чатTableAdapter;
            // 
            // чатBindingNavigator
            // 
            this.чатBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.чатBindingNavigator.BindingSource = this.чатBindingSource;
            this.чатBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.чатBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.чатBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.чатBindingNavigatorSaveItem});
            this.чатBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.чатBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.чатBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.чатBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.чатBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.чатBindingNavigator.Name = "чатBindingNavigator";
            this.чатBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.чатBindingNavigator.Size = new System.Drawing.Size(283, 25);
            this.чатBindingNavigator.TabIndex = 0;
            this.чатBindingNavigator.Text = "bindingNavigator1";
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
            // чатBindingNavigatorSaveItem
            // 
            this.чатBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.чатBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("чатBindingNavigatorSaveItem.Image")));
            this.чатBindingNavigatorSaveItem.Name = "чатBindingNavigatorSaveItem";
            this.чатBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.чатBindingNavigatorSaveItem.Text = "Save Data";
            this.чатBindingNavigatorSaveItem.Click += new System.EventHandler(this.чатBindingNavigatorSaveItem_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // названиеTextBox1
            // 
            this.названиеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чатBindingSource, "Название", true));
            this.названиеTextBox1.Location = new System.Drawing.Point(133, 33);
            this.названиеTextBox1.Name = "названиеTextBox1";
            this.названиеTextBox1.Size = new System.Drawing.Size(100, 20);
            this.названиеTextBox1.TabIndex = 6;
            // 
            // идентификатор_чатаTextBox1
            // 
            this.идентификатор_чатаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чатBindingSource, "Идентификатор_чата", true));
            this.идентификатор_чатаTextBox1.Location = new System.Drawing.Point(133, 59);
            this.идентификатор_чатаTextBox1.Name = "идентификатор_чатаTextBox1";
            this.идентификатор_чатаTextBox1.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_чатаTextBox1.TabIndex = 8;
            // 
            // аватар_чатаPictureBox
            // 
            this.аватар_чатаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.чатBindingSource, "Аватар_чата", true));
            this.аватар_чатаPictureBox.Location = new System.Drawing.Point(133, 85);
            this.аватар_чатаPictureBox.Name = "аватар_чатаPictureBox";
            this.аватар_чатаPictureBox.Size = new System.Drawing.Size(100, 50);
            this.аватар_чатаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.аватар_чатаPictureBox.TabIndex = 10;
            this.аватар_чатаPictureBox.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(12, 101);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenPhoto.TabIndex = 13;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            // 
            // инфоLabel
            // 
            инфоLabel.AutoSize = true;
            инфоLabel.Location = new System.Drawing.Point(12, 150);
            инфоLabel.Name = "инфоLabel";
            инфоLabel.Size = new System.Drawing.Size(38, 13);
            инфоLabel.TabIndex = 13;
            инфоLabel.Text = "Инфо:";
            // 
            // инфоTextBox
            // 
            this.инфоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чатBindingSource, "Инфо", true));
            this.инфоTextBox.Location = new System.Drawing.Point(133, 147);
            this.инфоTextBox.Name = "инфоTextBox";
            this.инфоTextBox.Size = new System.Drawing.Size(100, 20);
            this.инфоTextBox.TabIndex = 14;
            // 
            // FormChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 190);
            this.Controls.Add(инфоLabel);
            this.Controls.Add(this.инфоTextBox);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(названиеLabel1);
            this.Controls.Add(this.названиеTextBox1);
            this.Controls.Add(идентификатор_чатаLabel1);
            this.Controls.Add(this.идентификатор_чатаTextBox1);
            this.Controls.Add(аватар_чатаLabel);
            this.Controls.Add(this.аватар_чатаPictureBox);
            this.Controls.Add(this.чатBindingNavigator);
            this.Name = "FormChats";
            this.Text = "Чаты";
            this.Load += new System.EventHandler(this.FormChats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingNavigator)).EndInit();
            this.чатBindingNavigator.ResumeLayout(false);
            this.чатBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.аватар_чатаPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource чатBindingSource;
        private MessengerDataSetTableAdapters.ЧатTableAdapter чатTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator чатBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton чатBindingNavigatorSaveItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.TextBox названиеTextBox1;
        private System.Windows.Forms.TextBox идентификатор_чатаTextBox1;
        private System.Windows.Forms.PictureBox аватар_чатаPictureBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.TextBox инфоTextBox;
    }
}