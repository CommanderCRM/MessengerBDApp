namespace MessengerBDApp
{
    partial class FormUsersForUser
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
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label дата_регистрацииLabel;
            System.Windows.Forms.Label аватар_пользователяLabel;
            System.Windows.Forms.Label время_последнего_появления_в_сетиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsersForUser));
            this.messengerDataSet = new MessengerBDApp.MessengerDataSet();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.ПользовательTableAdapter();
            this.tableAdapterManager = new MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager();
            this.пользовательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пользовательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.дата_регистрацииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.время_последнего_появления_в_сетиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.параметры_уведомленийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.параметры_уведомленийTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.Параметры_уведомленийTableAdapter();
            this.аватар_пользователяPictureBox = new System.Windows.Forms.PictureBox();
            this.сообщениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сообщениеTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.СообщениеTableAdapter();
            this.чатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.чатTableAdapter = new MessengerBDApp.MessengerDataSetTableAdapters.ЧатTableAdapter();
            логинLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            дата_регистрацииLabel = new System.Windows.Forms.Label();
            аватар_пользователяLabel = new System.Windows.Forms.Label();
            время_последнего_появления_в_сетиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).BeginInit();
            this.пользовательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аватар_пользователяPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(14, 39);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(41, 13);
            логинLabel.TabIndex = 1;
            логинLabel.Text = "Логин:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(14, 65);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 3;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // дата_регистрацииLabel
            // 
            дата_регистрацииLabel.AutoSize = true;
            дата_регистрацииLabel.Location = new System.Drawing.Point(14, 92);
            дата_регистрацииLabel.Name = "дата_регистрацииLabel";
            дата_регистрацииLabel.Size = new System.Drawing.Size(103, 13);
            дата_регистрацииLabel.TabIndex = 5;
            дата_регистрацииLabel.Text = "Дата регистрации:";
            // 
            // аватар_пользователяLabel
            // 
            аватар_пользователяLabel.AutoSize = true;
            аватар_пользователяLabel.Location = new System.Drawing.Point(14, 114);
            аватар_пользователяLabel.Name = "аватар_пользователяLabel";
            аватар_пользователяLabel.Size = new System.Drawing.Size(120, 13);
            аватар_пользователяLabel.TabIndex = 7;
            аватар_пользователяLabel.Text = "Аватар пользователя:";
            // 
            // время_последнего_появления_в_сетиLabel
            // 
            время_последнего_появления_в_сетиLabel.AutoSize = true;
            время_последнего_появления_в_сетиLabel.Location = new System.Drawing.Point(14, 174);
            время_последнего_появления_в_сетиLabel.Name = "время_последнего_появления_в_сетиLabel";
            время_последнего_появления_в_сетиLabel.Size = new System.Drawing.Size(197, 13);
            время_последнего_появления_в_сетиLabel.TabIndex = 9;
            время_последнего_появления_в_сетиLabel.Text = "Время последнего появления в сети:";
            // 
            // messengerDataSet
            // 
            this.messengerDataSet.DataSetName = "MessengerDataSet";
            this.messengerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.messengerDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MessengerBDApp.MessengerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БеседаTableAdapter = null;
            this.tableAdapterManager.КаналTableAdapter = null;
            this.tableAdapterManager.Параметры_уведомленийTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = this.пользовательTableAdapter;
            this.tableAdapterManager.Секретный_чатTableAdapter = null;
            this.tableAdapterManager.СообщениеTableAdapter = null;
            this.tableAdapterManager.Тип_чатаTableAdapter = null;
            this.tableAdapterManager.ЧатTableAdapter = null;
            // 
            // пользовательBindingNavigator
            // 
            this.пользовательBindingNavigator.AddNewItem = null;
            this.пользовательBindingNavigator.BindingSource = this.пользовательBindingSource;
            this.пользовательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пользовательBindingNavigator.DeleteItem = null;
            this.пользовательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.пользовательBindingNavigatorSaveItem});
            this.пользовательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пользовательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пользовательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пользовательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пользовательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пользовательBindingNavigator.Name = "пользовательBindingNavigator";
            this.пользовательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пользовательBindingNavigator.Size = new System.Drawing.Size(426, 25);
            this.пользовательBindingNavigator.TabIndex = 0;
            this.пользовательBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // пользовательBindingNavigatorSaveItem
            // 
            this.пользовательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пользовательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пользовательBindingNavigatorSaveItem.Image")));
            this.пользовательBindingNavigatorSaveItem.Name = "пользовательBindingNavigatorSaveItem";
            this.пользовательBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.пользовательBindingNavigatorSaveItem.Text = "Save Data";
            this.пользовательBindingNavigatorSaveItem.Click += new System.EventHandler(this.пользовательBindingNavigatorSaveItem_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(217, 36);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(200, 20);
            this.логинTextBox.TabIndex = 2;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Номер_телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(217, 62);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_телефонаTextBox.TabIndex = 4;
            // 
            // дата_регистрацииDateTimePicker
            // 
            this.дата_регистрацииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пользовательBindingSource, "Дата_регистрации", true));
            this.дата_регистрацииDateTimePicker.Location = new System.Drawing.Point(217, 88);
            this.дата_регистрацииDateTimePicker.Name = "дата_регистрацииDateTimePicker";
            this.дата_регистрацииDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_регистрацииDateTimePicker.TabIndex = 6;
            // 
            // время_последнего_появления_в_сетиDateTimePicker
            // 
            this.время_последнего_появления_в_сетиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пользовательBindingSource, "Время_последнего_появления_в_сети", true));
            this.время_последнего_появления_в_сетиDateTimePicker.Location = new System.Drawing.Point(217, 170);
            this.время_последнего_появления_в_сетиDateTimePicker.Name = "время_последнего_появления_в_сетиDateTimePicker";
            this.время_последнего_появления_в_сетиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.время_последнего_появления_в_сетиDateTimePicker.TabIndex = 10;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(17, 130);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenPhoto.TabIndex = 12;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            // 
            // параметры_уведомленийBindingSource
            // 
            this.параметры_уведомленийBindingSource.DataMember = "FK_Параметрыуведомлений_Пользователь";
            this.параметры_уведомленийBindingSource.DataSource = this.пользовательBindingSource;
            // 
            // параметры_уведомленийTableAdapter
            // 
            this.параметры_уведомленийTableAdapter.ClearBeforeFill = true;
            // 
            // аватар_пользователяPictureBox
            // 
            this.аватар_пользователяPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.пользовательBindingSource, "Аватар_пользователя", true));
            this.аватар_пользователяPictureBox.Location = new System.Drawing.Point(217, 114);
            this.аватар_пользователяPictureBox.Name = "аватар_пользователяPictureBox";
            this.аватар_пользователяPictureBox.Size = new System.Drawing.Size(200, 50);
            this.аватар_пользователяPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.аватар_пользователяPictureBox.TabIndex = 8;
            this.аватар_пользователяPictureBox.TabStop = false;
            // 
            // сообщениеBindingSource
            // 
            this.сообщениеBindingSource.DataMember = "Сообщение";
            this.сообщениеBindingSource.DataSource = this.messengerDataSet;
            // 
            // сообщениеTableAdapter
            // 
            this.сообщениеTableAdapter.ClearBeforeFill = true;
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
            // FormUsersForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 205);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(дата_регистрацииLabel);
            this.Controls.Add(this.дата_регистрацииDateTimePicker);
            this.Controls.Add(аватар_пользователяLabel);
            this.Controls.Add(this.аватар_пользователяPictureBox);
            this.Controls.Add(время_последнего_появления_в_сетиLabel);
            this.Controls.Add(this.время_последнего_появления_в_сетиDateTimePicker);
            this.Controls.Add(this.пользовательBindingNavigator);
            this.Name = "FormUsersForUser";
            this.Text = "Пользователи (пользователь)";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messengerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).EndInit();
            this.пользовательBindingNavigator.ResumeLayout(false);
            this.пользовательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.параметры_уведомленийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аватар_пользователяPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чатBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MessengerDataSet messengerDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private MessengerDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private MessengerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пользовательBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton пользовательBindingNavigatorSaveItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.DateTimePicker дата_регистрацииDateTimePicker;
        private System.Windows.Forms.PictureBox аватар_пользователяPictureBox;
        private System.Windows.Forms.DateTimePicker время_последнего_появления_в_сетиDateTimePicker;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.BindingSource параметры_уведомленийBindingSource;
        private MessengerDataSetTableAdapters.Параметры_уведомленийTableAdapter параметры_уведомленийTableAdapter;
        private System.Windows.Forms.BindingSource сообщениеBindingSource;
        private MessengerDataSetTableAdapters.СообщениеTableAdapter сообщениеTableAdapter;
        private System.Windows.Forms.BindingSource чатBindingSource;
        private MessengerDataSetTableAdapters.ЧатTableAdapter чатTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}