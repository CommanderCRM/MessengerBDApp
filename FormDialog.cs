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
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        private void беседаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.беседаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Беседа' table. You can move, or remove it, as needed.
            this.беседаTableAdapter.Fill(this.messengerDataSet.Беседа);

        }

        private static FormDialog f;
        public static FormDialog fdi
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDialog();
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
