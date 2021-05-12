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
    public partial class FormUsersForUser : Form
    {
        public FormUsersForUser()
        {
            InitializeComponent();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.пользовательBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Чат' table. You can move, or remove it, as needed.
            this.чатTableAdapter.Fill(this.messengerDataSet.Чат);
            // TODO: This line of code loads data into the 'messengerDataSet.Сообщение' table. You can move, or remove it, as needed.
            this.сообщениеTableAdapter.Fill(this.messengerDataSet.Сообщение);
            // TODO: This line of code loads data into the 'messengerDataSet.Параметры_уведомлений' table. You can move, or remove it, as needed.
            this.параметры_уведомленийTableAdapter.Fill(this.messengerDataSet.Параметры_уведомлений);
            // TODO: This line of code loads data into the 'messengerDataSet.Пользователь' table. You can move, or remove it, as needed.
            this.пользовательTableAdapter.Fill(this.messengerDataSet.Пользователь);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            {
                openFileDialogPhoto.Title = "Укажите файл для фото";
                if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
                {
                    fileImage = openFileDialogPhoto.FileName;
                    try
                    {
                        аватар_пользователяPictureBox.Image = new
                       Bitmap(openFileDialogPhoto.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else fileImage = "";
            }
        }

        private static FormUsersForUser f;
        public static FormUsersForUser fusrusr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormUsersForUser();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void UserNotifSetSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.параметры_уведомленийBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMessages_Click(object sender, EventArgs e)
        {
            string id = "-1";
            if
           (((DataRowView)пользовательBindingSource.Current)["логин"].ToString() != "")
            {
                id = (string)(((DataRowView)пользовательBindingSource.Current)["логин"]);
            }
            id = FormMessageList.fml.ShowSelectForm(id);
            if (!String.IsNullOrEmpty(id))
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)пользовательBindingSource.Current)["логин"] = id;
                пользовательBindingSource.EndEdit();
                пользовательTableAdapter.Fill(this.messengerDataSet.Пользователь);
            }
        }

        private void параметры_уведомленийDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = "-1";
            if
           (((DataRowView)параметры_уведомленийBindingSource.Current)["идентификатор_чата"].ToString() != "")
            {
                id = (string)(((DataRowView)параметры_уведомленийBindingSource.Current)["идентификатор_чата"]);
            }
            id = FormChats.fchat.ShowSelectForm(id);
            if (!String.IsNullOrEmpty(id))
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)параметры_уведомленийBindingSource.Current)["идентификатор_чата"] = id;
                параметры_уведомленийBindingSource.EndEdit();
            }
        }
    }
}