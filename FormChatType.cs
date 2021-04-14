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
    public partial class FormChatType : Form
    {
        public FormChatType()
        {
            InitializeComponent();
        }

        private void тип_чатаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.тип_чатаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.messengerDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChatType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'messengerDataSet.Тип_чата' table. You can move, or remove it, as needed.
            this.тип_чатаTableAdapter.Fill(this.messengerDataSet.Тип_чата);

        }

        private static FormChatType f;
        public static FormChatType fct
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormChatType();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return
           тип_чатаDataGridView.Columns[тип_чатаDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = тип_чатаBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                тип_чатаBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких чатов нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                тип_чатаBindingSource.Position = 0;
            }

        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxFind.Checked)
                {
                    if (toolStripTextBoxFind.Text == "")
                        MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        try
                        {
                            тип_чатаBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                        }
                }
                else
                    тип_чатаBindingSource.Filter = "";
                if (тип_чатаBindingSource.Count == 0)
                {
                    MessageBox.Show("Нет таких");
                    тип_чатаBindingSource.Filter = "";
                    checkBoxFind.Checked = false;
                }
            }
        }
    }
}
