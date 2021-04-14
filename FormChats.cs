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
    public partial class FormChats : Form
    {
        public FormChats()
        {
            InitializeComponent();
        }

        private void чатBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.чатBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Чат' table. You can move, or remove it, as needed.
            this.чатTableAdapter.Fill(this.messengerDataSet.Чат);

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
                        аватар_чатаPictureBox.Image = new
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

        private static FormChats f;
        public static FormChats fchat
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormChats();
                return f;
            }
        }

        string idCurrent = "-1";
        public string ShowSelectForm(string id)
        {
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (string)((DataRowView)чатBindingSource.Current)["идентификатор_чата"];
            else
                return "-1";
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void FormChats_Shown(object sender, EventArgs e)
        {
            чатBindingSource.Position = чатBindingSource.Find("идентификатор_чата", idCurrent);
        }
    }
}
