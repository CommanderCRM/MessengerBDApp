namespace MessengerBDApp
{
    partial class FormSecretChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretChat));
            System.Windows.Forms.Label идентификатор_чатаLabel;
            System.Windows.Forms.Label тип_шифрованияLabel;
            System.Windows.Forms.Label ключ_шифрованияLabel;
            System.Windows.Forms.Label время_до_удаления_сообщенияLabel;
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.секретный_чатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.секретный_чатTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.Секретный_чатTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.секретный_чатBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.секретный_чатBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.идентификатор_чатаTextBox = new System.Windows.Forms.TextBox();
            this.тип_шифрованияComboBox = new System.Windows.Forms.ComboBox();
            this.ключ_шифрованияTextBox = new System.Windows.Forms.TextBox();
            this.время_до_удаления_сообщенияTextBox = new System.Windows.Forms.TextBox();
            идентификатор_чатаLabel = new System.Windows.Forms.Label();
            тип_шифрованияLabel = new System.Windows.Forms.Label();
            ключ_шифрованияLabel = new System.Windows.Forms.Label();
            время_до_удаления_сообщенияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.секретный_чатBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.секретный_чатBindingNavigator)).BeginInit();
            this.секретный_чатBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // секретный_чатBindingSource
            // 
            this.секретный_чатBindingSource.DataMember = "Секретный чат";
            this.секретный_чатBindingSource.DataSource = this.messengerDataSet;
            // 
            // секретный_чатTableAdapter
            // 
            this.секретный_чатTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БеседаTableAdapter = null;
            this.tableAdapterManager.КаналTableAdapter = null;
            this.tableAdapterManager.Параметры_уведомленийTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.Секретный_чатTableAdapter = this.секретный_чатTableAdapter;
            this.tableAdapterManager.СообщениеTableAdapter = null;
            this.tableAdapterManager.Тип_чатаTableAdapter = null;
            this.tableAdapterManager.ЧатTableAdapter = null;
            // 
            // секретный_чатBindingNavigator
            // 
            this.секретный_чатBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.секретный_чатBindingNavigator.BindingSource = this.секретный_чатBindingSource;
            this.секретный_чатBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.секретный_чатBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.секретный_чатBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.секретный_чатBindingNavigatorSaveItem});
            this.секретный_чатBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.секретный_чатBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.секретный_чатBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.секретный_чатBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.секретный_чатBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.секретный_чатBindingNavigator.Name = "секретный_чатBindingNavigator";
            this.секретный_чатBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.секретный_чатBindingNavigator.Size = new System.Drawing.Size(316, 25);
            this.секретный_чатBindingNavigator.TabIndex = 0;
            this.секретный_чатBindingNavigator.Text = "bindingNavigator1";
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
            // секретный_чатBindingNavigatorSaveItem
            // 
            this.секретный_чатBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.секретный_чатBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("секретный_чатBindingNavigatorSaveItem.Image")));
            this.секретный_чатBindingNavigatorSaveItem.Name = "секретный_чатBindingNavigatorSaveItem";
            this.секретный_чатBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.секретный_чатBindingNavigatorSaveItem.Text = "Save Data";
            this.секретный_чатBindingNavigatorSaveItem.Click += new System.EventHandler(this.секретный_чатBindingNavigatorSaveItem_Click);
            // 
            // идентификатор_чатаLabel
            // 
            идентификатор_чатаLabel.AutoSize = true;
            идентификатор_чатаLabel.Location = new System.Drawing.Point(12, 36);
            идентификатор_чатаLabel.Name = "идентификатор_чатаLabel";
            идентификатор_чатаLabel.Size = new System.Drawing.Size(115, 13);
            идентификатор_чатаLabel.TabIndex = 1;
            идентификатор_чатаLabel.Text = "Идентификатор чата:";
            // 
            // идентификатор_чатаTextBox
            // 
            this.идентификатор_чатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.секретный_чатBindingSource, "Идентификатор_чата", true));
            this.идентификатор_чатаTextBox.Location = new System.Drawing.Point(186, 33);
            this.идентификатор_чатаTextBox.Name = "идентификатор_чатаTextBox";
            this.идентификатор_чатаTextBox.Size = new System.Drawing.Size(121, 20);
            this.идентификатор_чатаTextBox.TabIndex = 2;
            // 
            // тип_шифрованияLabel
            // 
            тип_шифрованияLabel.AutoSize = true;
            тип_шифрованияLabel.Location = new System.Drawing.Point(12, 62);
            тип_шифрованияLabel.Name = "тип_шифрованияLabel";
            тип_шифрованияLabel.Size = new System.Drawing.Size(96, 13);
            тип_шифрованияLabel.TabIndex = 3;
            тип_шифрованияLabel.Text = "Тип шифрования:";
            // 
            // тип_шифрованияComboBox
            // 
            this.тип_шифрованияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.секретный_чатBindingSource, "Тип_шифрования", true));
            this.тип_шифрованияComboBox.FormattingEnabled = true;
            this.тип_шифрованияComboBox.Items.AddRange(new object[] {
            "OTR",
            "RSA",
            "AES"});
            this.тип_шифрованияComboBox.Location = new System.Drawing.Point(186, 59);
            this.тип_шифрованияComboBox.Name = "тип_шифрованияComboBox";
            this.тип_шифрованияComboBox.Size = new System.Drawing.Size(121, 21);
            this.тип_шифрованияComboBox.TabIndex = 4;
            // 
            // ключ_шифрованияLabel
            // 
            ключ_шифрованияLabel.AutoSize = true;
            ключ_шифрованияLabel.Location = new System.Drawing.Point(12, 89);
            ключ_шифрованияLabel.Name = "ключ_шифрованияLabel";
            ключ_шифрованияLabel.Size = new System.Drawing.Size(103, 13);
            ключ_шифрованияLabel.TabIndex = 5;
            ключ_шифрованияLabel.Text = "Ключ шифрования:";
            // 
            // ключ_шифрованияTextBox
            // 
            this.ключ_шифрованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.секретный_чатBindingSource, "Ключ_шифрования", true));
            this.ключ_шифрованияTextBox.Location = new System.Drawing.Point(186, 86);
            this.ключ_шифрованияTextBox.Name = "ключ_шифрованияTextBox";
            this.ключ_шифрованияTextBox.Size = new System.Drawing.Size(121, 20);
            this.ключ_шифрованияTextBox.TabIndex = 6;
            // 
            // время_до_удаления_сообщенияLabel
            // 
            время_до_удаления_сообщенияLabel.AutoSize = true;
            время_до_удаления_сообщенияLabel.Location = new System.Drawing.Point(12, 115);
            время_до_удаления_сообщенияLabel.Name = "время_до_удаления_сообщенияLabel";
            время_до_удаления_сообщенияLabel.Size = new System.Drawing.Size(168, 13);
            время_до_удаления_сообщенияLabel.TabIndex = 7;
            время_до_удаления_сообщенияLabel.Text = "Время до удаления сообщения:";
            // 
            // время_до_удаления_сообщенияTextBox
            // 
            this.время_до_удаления_сообщенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.секретный_чатBindingSource, "Время_до_удаления_сообщения", true));
            this.время_до_удаления_сообщенияTextBox.Location = new System.Drawing.Point(186, 112);
            this.время_до_удаления_сообщенияTextBox.Name = "время_до_удаления_сообщенияTextBox";
            this.время_до_удаления_сообщенияTextBox.Size = new System.Drawing.Size(121, 20);
            this.время_до_удаления_сообщенияTextBox.TabIndex = 8;
            // 
            // FormSecretChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 153);
            this.Controls.Add(идентификатор_чатаLabel);
            this.Controls.Add(this.идентификатор_чатаTextBox);
            this.Controls.Add(тип_шифрованияLabel);
            this.Controls.Add(this.тип_шифрованияComboBox);
            this.Controls.Add(ключ_шифрованияLabel);
            this.Controls.Add(this.ключ_шифрованияTextBox);
            this.Controls.Add(время_до_удаления_сообщенияLabel);
            this.Controls.Add(this.время_до_удаления_сообщенияTextBox);
            this.Controls.Add(this.секретный_чатBindingNavigator);
            this.Name = "FormSecretChat";
            this.Text = "Секретные чаты";
            this.Load += new System.EventHandler(this.FormSecretChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.секретный_чатBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.секретный_чатBindingNavigator)).EndInit();
            this.секретный_чатBindingNavigator.ResumeLayout(false);
            this.секретный_чатBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource секретный_чатBindingSource;
        private MessengerDataSetTableAdapters.Секретный_чатTableAdapter секретный_чатTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator секретный_чатBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton секретный_чатBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox идентификатор_чатаTextBox;
        private System.Windows.Forms.ComboBox тип_шифрованияComboBox;
        private System.Windows.Forms.TextBox ключ_шифрованияTextBox;
        private System.Windows.Forms.TextBox время_до_удаления_сообщенияTextBox;
    }
}