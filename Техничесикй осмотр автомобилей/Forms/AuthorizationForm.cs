using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Техничесикй_осмотр_автомобилей;
using Техничесикй_осмотр_автомобилей.Forms;

namespace Техничесикй_осмотр_автомобилей
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void registrBtn_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string loginUser = textBox1.Text;
            string passUser = textBox2.Text;

            DB db = new DB();
            try
            {
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string queryAccount = $"SELECT id_client, is_employee, id_employee FROM login WHERE login = '{loginUser}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(queryAccount, db.getConnection());
                    db.openConnection();
                    MainForm mainForm = new MainForm();
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        mainForm.idClient = reader[0].ToString();
                        mainForm.isEmployee = (bool)reader[1];
                        mainForm.idEmployee = reader[2].ToString();
                    }
                    reader.Close();
  
                    db.closeConnection();
                    MessageBox.Show("Добро пожаловать " + loginUser, "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не запустили сервер либо у вас база данных не создана!");
            }
        }
    }
}
