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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Техничесикй_осмотр_автомобилей.Forms
{
    public partial class EditCheckOrder : Form
    {
        public string idCar = null;
        string idClient = null;
        string idPerfCar = null;
        string idPassport = null;
        public EditCheckOrder()
        {
            InitializeComponent();
        }

        private void EditCheckOrder_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT * FROM car WHERE id_car = '{idCar}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                modelCarTxt.Text = reader[1].ToString();
                idClient = reader[2].ToString();
                idPerfCar = reader[3].ToString();
            }
            reader.Close();
            string queryInfo1 = $"SELECT * FROM client WHERE id = '{idClient}'";
            MySqlCommand mySqlCommand1 = new MySqlCommand(queryInfo1, db.getConnection());
            string queryInfo2 = $"SELECT * FROM perfomancecar WHERE id_perfcar  = '{idPerfCar}'";
            MySqlCommand mySqlCommand2 = new MySqlCommand(queryInfo2, db.getConnection());

            MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();
            while (reader1.Read())
            {
                idPassport= reader1[6].ToString();
                phoneTxt.Text = reader1[4].ToString();
                placeWorkTxt.Text = reader1[5].ToString();
            }
            reader1.Close();


            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                colorTxt.Text = reader2[1].ToString();
                engineCapacityTxt.Text = reader2[2].ToString();
                yearIssueTxt.Text = reader2[3].ToString();
                typeCarTxt.Text = reader2[4].ToString();
                vinNumberTxt.Text = reader2[5].ToString();
            }
            reader2.Close();

            string queryInfo3 = $"SELECT * FROM passport WHERE id = '{idPassport}'";
            MySqlCommand mySqlCommand3 = new MySqlCommand(queryInfo3, db.getConnection());

            MySqlDataReader reader3 = mySqlCommand3.ExecuteReader();
            while (reader3.Read())
            {
                numberPassportTxt.Text = reader3[1].ToString();
                seriesPassportTxt.Text = reader3[2].ToString();
                dataIssueTxt.Text = reader3[3].ToString();
                authorityTxt.Text = reader3[4].ToString();


            }
            reader3.Close();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command1 = new MySqlCommand($"UPDATE client SET phone_number=@phone_number, place_of_work=@place_of_work WHERE id={idClient}", db.getConnection());
            command1.Parameters.AddWithValue("@phone_number", phoneTxt.Text);
            command1.Parameters.AddWithValue("@place_of_work", placeWorkTxt.Text);

            db.openConnection();

            try
            {
                command1.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            MySqlCommand command2 = new MySqlCommand($"UPDATE car SET car_model=@car_model WHERE id_car={idCar}", db.getConnection());
            command2.Parameters.AddWithValue("@car_model", phoneTxt.Text);

            db.openConnection();

            try
            {
                command2.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            MySqlCommand command3 = new MySqlCommand($"UPDATE passport SET passport_number=@passport_number, passport_series=@passport_series, date_issue=@date_issue, authority=@authority WHERE id={idPassport}", db.getConnection());
            command3.Parameters.AddWithValue("@passport_number", numberPassportTxt.Text);
            command3.Parameters.AddWithValue("@passport_series", seriesPassportTxt.Text);
            command3.Parameters.AddWithValue("@date_issue", dataIssueTxt.Text);
            command3.Parameters.AddWithValue("@authority", authorityTxt.Text);

            db.openConnection();

            try
            {
                command3.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            MySqlCommand command4 = new MySqlCommand($"UPDATE perfomancecar SET body_color=@body_color, engine_capacity=@engine_capacity, year_issue=@year_issue, type_car=@type_car, vin_number=@vin_number WHERE id_perfcar ={idPerfCar}", db.getConnection());
            command4.Parameters.AddWithValue("@body_color", colorTxt.Text);
            command4.Parameters.AddWithValue("@engine_capacity", engineCapacityTxt.Text);
            command4.Parameters.AddWithValue("@year_issue", yearIssueTxt.Text);
            command4.Parameters.AddWithValue("@type_car", typeCarTxt.Text);
            command4.Parameters.AddWithValue("@vin_number", vinNumberTxt.Text);

            db.openConnection();

            try
            {
                command4.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }
    }
}
