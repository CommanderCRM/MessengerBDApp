namespace MessengerBDApp
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageExample = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonNotifSet = new System.Windows.Forms.RadioButton();
            this.radioButtonChats = new System.Windows.Forms.RadioButton();
            this.radioButtonUsers = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_Select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_None = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Dialog = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Channel = new System.Windows.Forms.RadioButton();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.labelChat = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelectChats = new System.Windows.Forms.Button();
            this.panelSC = new System.Windows.Forms.Panel();
            this.textBoxCTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCKey = new System.Windows.Forms.TextBox();
            this.labelCKey = new System.Windows.Forms.Label();
            this.labelCType = new System.Windows.Forms.Label();
            this.comboBoxCType = new System.Windows.Forms.ComboBox();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxSCID = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelSCID = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControlSQL.SuspendLayout();
            this.tabPageExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSC.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageExample);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageExample
            // 
            this.tabPageExample.Controls.Add(this.dataGridViewSelect);
            this.tabPageExample.Controls.Add(this.groupBoxSelect);
            this.tabPageExample.Location = new System.Drawing.Point(4, 22);
            this.tabPageExample.Name = "tabPageExample";
            this.tabPageExample.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExample.Size = new System.Drawing.Size(792, 424);
            this.tabPageExample.TabIndex = 0;
            this.tabPageExample.Text = "Примеры запросов";
            this.tabPageExample.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonNotifSet);
            this.groupBoxSelect.Controls.Add(this.radioButtonChats);
            this.groupBoxSelect.Controls.Add(this.radioButtonUsers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonNotifSet
            // 
            this.radioButtonNotifSet.AutoSize = true;
            this.radioButtonNotifSet.Location = new System.Drawing.Point(626, 48);
            this.radioButtonNotifSet.Name = "radioButtonNotifSet";
            this.radioButtonNotifSet.Size = new System.Drawing.Size(154, 17);
            this.radioButtonNotifSet.TabIndex = 2;
            this.radioButtonNotifSet.Text = "Параметры уведомлений";
            this.radioButtonNotifSet.UseVisualStyleBackColor = true;
            this.radioButtonNotifSet.CheckedChanged += new System.EventHandler(this.radioButtonNotifSet_CheckedChanged);
            // 
            // radioButtonChats
            // 
            this.radioButtonChats.AutoSize = true;
            this.radioButtonChats.Location = new System.Drawing.Point(350, 48);
            this.radioButtonChats.Name = "radioButtonChats";
            this.radioButtonChats.Size = new System.Drawing.Size(52, 17);
            this.radioButtonChats.TabIndex = 1;
            this.radioButtonChats.Text = "Чаты";
            this.radioButtonChats.UseVisualStyleBackColor = true;
            this.radioButtonChats.CheckedChanged += new System.EventHandler(this.radioButtonChats_CheckedChanged);
            // 
            // radioButtonUsers
            // 
            this.radioButtonUsers.AutoSize = true;
            this.radioButtonUsers.Location = new System.Drawing.Point(7, 48);
            this.radioButtonUsers.Name = "radioButtonUsers";
            this.radioButtonUsers.Size = new System.Drawing.Size(98, 17);
            this.radioButtonUsers.TabIndex = 0;
            this.radioButtonUsers.TabStop = true;
            this.radioButtonUsers.Text = "Пользователи";
            this.radioButtonUsers.UseVisualStyleBackColor = true;
            this.radioButtonUsers.CheckedChanged += new System.EventHandler(this.radioButtonUsers_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 137);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 284);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_Select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxChat);
            this.groupBoxFSelect.Controls.Add(this.labelChat);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 134);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Количество пользователей";
            // 
            // buttonF_Select
            // 
            this.buttonF_Select.Location = new System.Drawing.Point(298, 105);
            this.buttonF_Select.Name = "buttonF_Select";
            this.buttonF_Select.Size = new System.Drawing.Size(184, 23);
            this.buttonF_Select.TabIndex = 6;
            this.buttonF_Select.Text = "Количество пользователей";
            this.buttonF_Select.UseVisualStyleBackColor = true;
            this.buttonF_Select.Click += new System.EventHandler(this.buttonF_Select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 70);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(266, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию количества";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(179, 46);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(100, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 46);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(164, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать количество более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_None);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Dialog);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Channel);
            this.groupBoxDet.Location = new System.Drawing.Point(501, 3);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(279, 91);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация по типу чата";
            // 
            // radioButtonDet_None
            // 
            this.radioButtonDet_None.AutoSize = true;
            this.radioButtonDet_None.Location = new System.Drawing.Point(7, 66);
            this.radioButtonDet_None.Name = "radioButtonDet_None";
            this.radioButtonDet_None.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_None.TabIndex = 2;
            this.radioButtonDet_None.TabStop = true;
            this.radioButtonDet_None.Text = "Нет детализации";
            this.radioButtonDet_None.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Dialog
            // 
            this.radioButtonDet_Dialog.AutoSize = true;
            this.radioButtonDet_Dialog.Location = new System.Drawing.Point(7, 43);
            this.radioButtonDet_Dialog.Name = "radioButtonDet_Dialog";
            this.radioButtonDet_Dialog.Size = new System.Drawing.Size(197, 17);
            this.radioButtonDet_Dialog.TabIndex = 1;
            this.radioButtonDet_Dialog.TabStop = true;
            this.radioButtonDet_Dialog.Text = "Количество участников в беседах";
            this.radioButtonDet_Dialog.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Channel
            // 
            this.radioButtonDet_Channel.AutoSize = true;
            this.radioButtonDet_Channel.Location = new System.Drawing.Point(7, 20);
            this.radioButtonDet_Channel.Name = "radioButtonDet_Channel";
            this.radioButtonDet_Channel.Size = new System.Drawing.Size(205, 17);
            this.radioButtonDet_Channel.TabIndex = 0;
            this.radioButtonDet_Channel.TabStop = true;
            this.radioButtonDet_Channel.Text = "Количество подписчиков в каналах";
            this.radioButtonDet_Channel.UseVisualStyleBackColor = true;
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(125, 16);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(184, 20);
            this.textBoxChat.TabIndex = 1;
            // 
            // labelChat
            // 
            this.labelChat.AutoSize = true;
            this.labelChat.Location = new System.Drawing.Point(7, 19);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(112, 13);
            this.labelChat.TabIndex = 0;
            this.labelChat.Text = "Идентификатор чата";
            this.labelChat.Click += new System.EventHandler(this.labelChat_Click);
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 114);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 307);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxUser);
            this.groupBoxSubquery.Controls.Add(this.labelUser);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 111);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(73, 78);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(142, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(125, 52);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(272, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(6, 52);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(112, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Логин пользователя";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(209, 19);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridView1);
            this.tabPageDML.Controls.Add(this.buttonSelectChats);
            this.tabPageDML.Controls.Add(this.panelSC);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 424);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 268);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonSelectChats
            // 
            this.buttonSelectChats.Location = new System.Drawing.Point(259, 124);
            this.buttonSelectChats.Name = "buttonSelectChats";
            this.buttonSelectChats.Size = new System.Drawing.Size(207, 23);
            this.buttonSelectChats.TabIndex = 5;
            this.buttonSelectChats.Text = "Показать список секретных чатов";
            this.buttonSelectChats.UseVisualStyleBackColor = true;
            this.buttonSelectChats.Click += new System.EventHandler(this.buttonSelectChats_Click);
            // 
            // panelSC
            // 
            this.panelSC.Controls.Add(this.textBoxCTime);
            this.panelSC.Controls.Add(this.label1);
            this.panelSC.Controls.Add(this.textBoxCKey);
            this.panelSC.Controls.Add(this.labelCKey);
            this.panelSC.Controls.Add(this.labelCType);
            this.panelSC.Controls.Add(this.comboBoxCType);
            this.panelSC.Location = new System.Drawing.Point(3, 86);
            this.panelSC.Name = "panelSC";
            this.panelSC.Size = new System.Drawing.Size(786, 32);
            this.panelSC.TabIndex = 1;
            // 
            // textBoxCTime
            // 
            this.textBoxCTime.Location = new System.Drawing.Point(656, 7);
            this.textBoxCTime.Name = "textBoxCTime";
            this.textBoxCTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxCTime.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время до удаления сообщения";
            // 
            // textBoxCKey
            // 
            this.textBoxCKey.Location = new System.Drawing.Point(359, 6);
            this.textBoxCKey.Name = "textBoxCKey";
            this.textBoxCKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxCKey.TabIndex = 6;
            // 
            // labelCKey
            // 
            this.labelCKey.AutoSize = true;
            this.labelCKey.Location = new System.Drawing.Point(253, 6);
            this.labelCKey.Name = "labelCKey";
            this.labelCKey.Size = new System.Drawing.Size(100, 13);
            this.labelCKey.TabIndex = 5;
            this.labelCKey.Text = "Ключ шифрования";
            // 
            // labelCType
            // 
            this.labelCType.AutoSize = true;
            this.labelCType.Location = new System.Drawing.Point(6, 6);
            this.labelCType.Name = "labelCType";
            this.labelCType.Size = new System.Drawing.Size(93, 13);
            this.labelCType.TabIndex = 4;
            this.labelCType.Text = "Тип шифрования";
            // 
            // comboBoxCType
            // 
            this.comboBoxCType.FormattingEnabled = true;
            this.comboBoxCType.Items.AddRange(new object[] {
            "OTR",
            "RSA",
            "AES"});
            this.comboBoxCType.Location = new System.Drawing.Point(104, 6);
            this.comboBoxCType.Name = "comboBoxCType";
            this.comboBoxCType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCType.TabIndex = 0;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxSCID);
            this.groupBoxDML.Controls.Add(this.radioButton3);
            this.groupBoxDML.Controls.Add(this.labelSCID);
            this.groupBoxDML.Controls.Add(this.radioButton2);
            this.groupBoxDML.Controls.Add(this.radioButton1);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 77);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(256, 50);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(127, 23);
            this.buttonExecuteDML.TabIndex = 4;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxSCID
            // 
            this.textBoxSCID.Location = new System.Drawing.Point(125, 50);
            this.textBoxSCID.Name = "textBoxSCID";
            this.textBoxSCID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSCID.TabIndex = 2;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(494, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(262, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Удаление секретного чата по идентификатору";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // labelSCID
            // 
            this.labelSCID.AutoSize = true;
            this.labelSCID.Location = new System.Drawing.Point(6, 50);
            this.labelSCID.Name = "labelSCID";
            this.labelSCID.Size = new System.Drawing.Size(112, 13);
            this.labelSCID.TabIndex = 1;
            this.labelSCID.Text = "Идентификатор чата";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(193, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(270, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Изменение секретного чата по идентификатору";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(174, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Добавление секретного чата";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageExample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSC.ResumeLayout(false);
            this.panelSC.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageExample;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonUsers;
        private System.Windows.Forms.RadioButton radioButtonNotifSet;
        private System.Windows.Forms.RadioButton radioButtonChats;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_None;
        private System.Windows.Forms.RadioButton radioButtonDet_Dialog;
        private System.Windows.Forms.RadioButton radioButtonDet_Channel;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.Button buttonF_Select;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelSCID;
        private System.Windows.Forms.TextBox textBoxSCID;
        private System.Windows.Forms.Panel panelSC;
        private System.Windows.Forms.Label labelCType;
        private System.Windows.Forms.ComboBox comboBoxCType;
        private System.Windows.Forms.TextBox textBoxCKey;
        private System.Windows.Forms.Label labelCKey;
        private System.Windows.Forms.TextBox textBoxCTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.Button buttonSelectChats;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}