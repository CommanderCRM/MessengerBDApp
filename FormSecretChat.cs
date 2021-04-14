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
    public partial class FormSecretChat : Form
    {
        public FormSecretChat()
        {
            InitializeComponent();
        }

        private void секретный_чатBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.секретный_чатBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSecretChat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Секретный_чат' table. You can move, or remove it, as needed.
            this.секретный_чатTableAdapter.Fill(this.messengerDataSet.Секретный_чат);

        }

        private static FormSecretChat f;
        public static FormSecretChat fsc
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSecretChat();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
