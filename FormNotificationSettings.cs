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
    public partial class FormNotificationSettings : Form
    {
        public FormNotificationSettings()
        {
            InitializeComponent();
        }

        private void параметры_уведомленийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void FormNotificationSettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Чат' table. You can move, or remove it, as needed.
            this.чатTableAdapter.Fill(this.messengerDataSet.Чат);
            // TODO: This line of code loads data into the 'messengerDataSet.Параметры_уведомлений' table. You can move, or remove it, as needed.
            this.параметры_уведомленийTableAdapter.Fill(this.messengerDataSet.Параметры_уведомлений);

        }

        private static FormNotificationSettings f;
        public static FormNotificationSettings fns
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNotificationSettings();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
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
