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
    public partial class FormMessageList : Form
    {
        public FormMessageList()
        {
            InitializeComponent();
        }

        private void сообщениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сообщениеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMessageList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Сообщение' table. You can move, or remove it, as needed.
            this.сообщениеTableAdapter.Fill(this.messengerDataSet.Сообщение);

        }

        private static FormMessageList f;
        public static FormMessageList fml
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMessageList();
                return f;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            сообщениеBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        string idCurrent = "-1";
        public string ShowSelectForm(string id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (string)((DataRowView)сообщениеBindingSource.Current)["отправитель"];
            else
                return "-1";
        }

        private void FormMessageList_Shown(object sender, EventArgs e)
        {
            сообщениеBindingSource.Position = сообщениеBindingSource.Find("отправитель", idCurrent);
        }
    }
}
