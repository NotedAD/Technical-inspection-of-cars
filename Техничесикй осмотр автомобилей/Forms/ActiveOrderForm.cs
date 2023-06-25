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
    public partial class ActiveOrderForm : Form
    {
        public string idReq = null;
        public string idCar = null;
        public string idClient = null;
        public string idPerfCar = null;
        public string idPassport = null;
        public string idEmployee = null;
        public ActiveOrderForm()
        {
            InitializeComponent();
        }

        private void ActiveOrderForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT * FROM car WHERE id_car = '{idCar}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                modelCar.Text = reader[1].ToString();
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
                name.Text = reader1[1].ToString();
                surn.Text = reader1[2].ToString();
                patr.Text = reader1[3].ToString();
                phone.Text = reader1[4].ToString();
                work.Text = reader1[5].ToString();
                idPassport = reader1[6].ToString();
            }
            reader1.Close();


            MySqlDataReader reader2 = mySqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                color.Text = reader2[1].ToString();
                engineCapac.Text = reader2[2].ToString();
                yearIssu.Text = reader2[3].ToString();
                typeCar.Text = reader2[4].ToString();
                vin.Text = reader2[5].ToString();
            }
            reader2.Close();

            string queryInfo3 = $"SELECT * FROM passport WHERE id = '{idPassport}'";
            MySqlCommand mySqlCommand3 = new MySqlCommand(queryInfo3, db.getConnection());

            MySqlDataReader reader3 = mySqlCommand3.ExecuteReader();
            while (reader3.Read())
            {
                numbPassp.Text = reader3[1].ToString();
                serPassp.Text = reader3[2].ToString();
                dataIssue.Text = reader3[3].ToString();
                author.Text = reader3[4].ToString();
            }
            reader3.Close();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           TechinspectionForm techinspectionForm = new TechinspectionForm();
            techinspectionForm.idReq = idReq;
            techinspectionForm.idPerfCar = idPerfCar;
            techinspectionForm.idPassport = idPassport;
            techinspectionForm.idClient = idClient;
            techinspectionForm.idCar = idCar;
            techinspectionForm.idEmployee = idEmployee;
            techinspectionForm.Show();

        }
    }
}
