using MessengerBDApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerBDApp
{
    public partial class FormUser : Form
    {
        private readonly byte[] _userNameBytes;
        private readonly byte[] _userPasswordBytes;

        public FormUser(byte[] pNameBytes, byte[] pPasswordBytes)
        {
            InitializeComponent();
            _userNameBytes = pNameBytes;
            _userPasswordBytes = pPasswordBytes;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            var ops = new LoginLibrary.DataClasses.DataClasses.DataOperations(
                _userNameBytes,
                _userPasswordBytes,
                @"CRM\SQLEXPRESS",
                "Messenger");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, БИС, Кривошеин Илья Андреевич, группа 748, 2021", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
            Application.ExitThread();
        }

        private void секретныеЧатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecretChat.fsc.ShowForm();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsersForUser.fusrusr.ShowForm();
        }

        private void сообщенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessageList.fml.ShowForm();
        }

        private void параметрыУведомленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotificationSettings.fns.ShowForm();
        }

        private void типыЧатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChatType.fct.ShowForm();
        }

        private void беседыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDialog.fdi.ShowForm();
        }

        private void каналыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChannel.fchan.ShowForm();
        }

        private void чатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChats.fchat.ShowForm();
        }

        private void contextMenuStripMain_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButtonSQL_Click(object sender, EventArgs e)
        {
            FormSQL.fsql.ShowForm();
        }
    }
}
