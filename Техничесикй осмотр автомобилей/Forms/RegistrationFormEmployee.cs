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

namespace Техничесикй_осмотр_автомобилей.Forms
{
    public partial class RegistrationFormEmployee : Form
    {
        DB db = new DB();

        public RegistrationFormEmployee()
        {
            InitializeComponent();
        }

        private void registrBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "SELECT * FROM login ORDER BY login";
                MySqlCommand mySqlCommand = new MySqlCommand(query, db.getConnection());
                db.openConnection();

                {
                    if (nameTxt.Text == "" || loginTxt.Text == "" || passTxt.Text == "" || repeatPassTxt.Text == "")
                    {
                        MessageBox.Show("Вы не ввели данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (loginTxt.Text.Length > 20)
                        {
                            MessageBox.Show("Слишком длинный логин!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (passTxt.Text.Length >= 6)
                            {
                                bool en = true;
                                bool symbol = false;
                                bool number = false;

                                for (int i = 0; i < passTxt.Text.Length; i++)
                                {
                                    if (passTxt.Text[i] >= 'А' && passTxt.Text[i] <= 'Я') en = false;
                                    if (passTxt.Text[i] >= '0' && passTxt.Text[i] <= '9') number = true;
                                    if (passTxt.Text[i] == '_' || passTxt.Text[i] == '-' || passTxt.Text[i] == '!') symbol = true;
                                }
                                if (!en)
                                    MessageBox.Show("Доступна только английская раскладка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else if (!symbol)
                                    MessageBox.Show("Добавьте один из следующих символов: _, -, !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else if (!number)
                                    MessageBox.Show("Добавьте хотя бы одну цифру", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (en && symbol && number)
                                {
                                    if (repeatPassTxt.Text == passTxt.Text)
                                    {
                                        try
                                        {
                                            ApplyExecuteResults();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Логин занят!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }
                                else MessageBox.Show("Пароли не совпадают!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("Пароль слишком короткий, минимум 6 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                db.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не запустили сервер либо у вас не база данных создана!");
            }

        }

        private void ApplyExecuteResults()
        {
            string idEmployee = null;

            MySqlCommand command1 = new MySqlCommand($"INSERT INTO `employee`(`name`, `surname`, `patronymic`, `rank`, `job_title`) VALUES (@name,@surname,@patronymic,@rank,@job_title)", db.getConnection());
            MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id FROM employee WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command1.Parameters.AddWithValue("@name", nameTxt.Text);
            command1.Parameters.AddWithValue("@surname", surTxt.Text);
            command1.Parameters.AddWithValue("@patronymic", patronTxt.Text);
            command1.Parameters.AddWithValue("@rank", rankTxt.Text);
            command1.Parameters.AddWithValue("@job_title", jobTitleTxt.Text);
            db.openConnection();

            try
            {
                command1.ExecuteNonQuery();

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlDataReader reader = commandGetLastID.ExecuteReader();
            while (reader.Read())
            {
                idEmployee = reader[0].ToString();
            }
            reader.Close();

            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand("INSERT INTO `login` (`login`, `pass`, `id_employee`, `is_employee`) VALUES (@login, @pass, @idEmpl, @isEmpl)", db.getConnection());

            command2.Parameters.AddWithValue("@login", loginTxt.Text);
            command2.Parameters.AddWithValue("@pass", passTxt.Text);
            command2.Parameters.AddWithValue("@isEmpl", 1);
            command2.Parameters.AddWithValue("@idEmpl", idEmployee);

            db.openConnection();

            if (command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new AuthorizationForm().Show();
                Close();
            }
            else MessageBox.Show("Ошибка созадния аккаунта", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.closeConnection();
        }

        private void registrBackBtn_Click(object sender, EventArgs e)
        {
            new AuthorizationForm().Show();
            this.Hide();
        }
    }
}
