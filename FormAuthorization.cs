using LoginLibrary.DataClasses.DataClasses;
using LoginLibrary.SecurityClasses.SecurityClasses;
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
    public partial class FormAuthorization : Form
    {

        public FormAuthorization()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                var ops = new DatabaseUser(@"CRM\SQLEXPRESS", "Messenger");

                var encryption = new Encryption();
                var userNameBytes = encryption.Encrypt(usernameTextBox.Text, "111");
                var passwordBytes = encryption.Encrypt(passwordTextBox.Text, "111");

                var results = ops.SqlCredentialLogin(userNameBytes, passwordBytes);

                if (results.Success)
                {
                    Hide();
                    var mainForm = new FormMain(userNameBytes, passwordBytes);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(results.Message);
                }
            }
            else
            {
                MessageBox.Show("Не хватает информации для входа.");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
            {
                Close();
            }

        }
    }
