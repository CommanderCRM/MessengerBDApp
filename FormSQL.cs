using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MessengerBDApp
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.MessengerConnectionString1);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonUsers_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT * FROM Пользователь"); 
        }

        private void radioButtonChats_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Идентификатор_сообщения, Статус_отправки, Статус_прочтения FROM Сообщение");
        }

        private void radioButtonNotifSet_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Идентификатор_чата, Тип_оповещения FROM Параметры_уведомлений WHERE Тип_оповещения = 'Баннер' ");
        }

        private static FormSQL f;
        public static FormSQL fsql
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void buttonF_Select_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxChat.Text))
            {
                MessageBox.Show("Обязательно укажите название необходимого чата.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указано количество в условии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";

            if (radioButtonDet_Channel.Checked)
            {
                sqlSelect = @"SELECT ch.Идентификатор_чата, Количество_пользователей FROM Канал ch WHERE Идентификатор_чата LIKE @id";
            }
            else if (radioButtonDet_Dialog.Checked)
            {
                sqlSelect = @"SELECT d.Идентификатор_чата, Количество_пользователей FROM Беседа d WHERE Идентификатор_чата LIKE @id";
            }
            else
            {
                sqlSelect = @"SELECT Идентификатор_чата, Количество_пользователей FROM Канал WHERE Идентификатор_чата LIKE @id UNION SELECT Идентификатор_чата, Количество_пользователей FROM Беседа WHERE Идентификатор_чата LIKE @id";
            }

            if (checkBoxMore.Checked)
            {
                sqlSelect += "HAVING Количество_пользователей > @amount";
            }

            if (checkBoxOrder.Checked)
            {
                sqlSelect += "ORDER BY Количество_пользователей DESC";
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.MessengerConnectionString1);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@id", textBoxChat.Text + "%");
            if (checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.SmallInt).Value = Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Количество в условии должно быть задано числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUser.Text))
            {
                MessageBox.Show("Обязательно укажите логин необходимого пользователя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT Логин FROM Пользователь WHERE Логин = @login, SELECT Отправитель FROM Сообщение WHERE Отправитель IN (SELECT Логин FROM Пользователь WHERE Логин = Отправитель) = @login";
            else
            if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT * FROM Пользователь WHERE Логин = @login";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.MessengerConnectionString1);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@login", textBoxUser.Text);
            }
            catch
            {
                MessageBox.Show("Логин пользователя должен содержать символы и цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void InsertChat()
        {
            string sqlInsert = @"INSERT INTO Секретный_чат (Идентификатор_чата, Тип_шифрования, Ключ_шифрования, Время_до_удаления_сообщения) VALUES (@id, @CType, @CKey, @CTime)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.MessengerConnectionString1);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", textBoxSCID.Text);
            command.Parameters.AddWithValue("@CType", comboBoxCType.Text);
            command.Parameters.AddWithValue("@CKey", textBoxCKey.Text);
            command.Parameters.AddWithValue("@CTime", textBoxCTime.Text);
            connection.Close();
            buttonSelectChats_Click(this, EventArgs.Empty);
        }

        void UpdateChat()
        {
            string sqlUpdate = "UPDATE Секретный_чат SET {0} WHERE Идентификатор_чата = @id"; 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.MessengerConnectionString1);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(comboBoxCType.Text))
                sqlValues += "Тип_шифрования=@CType,";
            if (!String.IsNullOrEmpty(textBoxCKey.Text))
                sqlValues += "Ключ_шифрования=@CKey,";
            if (!String.IsNullOrEmpty(textBoxCTime.Text))
                sqlValues += "Время_до_удаления_сообщения=@CType,";
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            command.Parameters.AddWithValue("@id", textBoxSCID.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectChats_Click(this, EventArgs.Empty);
        }

        void DeleteChat()
        {
            string sqlDelete = @"DELETE FROM Секретный_чат WHERE Идентификатор_чата=@id";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.MessengerConnectionString1);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@id", textBoxSCID.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectChats_Click(this, EventArgs.Empty);
        }

        private void buttonSelectChats_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView("SELECT * FROM Секретный_чат");
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                InsertChat();
            else
 if (radioButton2.Checked)
                UpdateChat();
            else
 if (radioButton3.Checked)
                DeleteChat();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void labelChat_Click(object sender, EventArgs e)
        {

        }
    }
}
