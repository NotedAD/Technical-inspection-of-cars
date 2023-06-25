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
    public partial class EditTechinspectionForm : Form
    {
        public string id;
        public EditTechinspectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command1 = new MySqlCommand($"UPDATE techinspection SET time_spending=@time_spending, cost=@cost WHERE id_techinsp={id}", db.getConnection());
            command1.Parameters.AddWithValue("@time_spending", timeSpendingTxt.Text);
            command1.Parameters.AddWithValue("@cost", CostTxt.Text);

            db.openConnection();

            try
            {
                timeSpendingTxt.Text = "";
                CostTxt.Text = "";
                command1.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void EditTechinspectionForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT * FROM techinspection WHERE id_techinsp = '{id}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                timeSpendingTxt.Text = reader[1].ToString();
                CostTxt.Text = reader[2].ToString();
            }
            reader.Close();
            db.closeConnection();
        }
    }
}
