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
    public partial class TechinspectionForm : Form
    {
        public string idReq = null;
        public string idCar = null;
        public string idClient = null;
        public string idPerfCar = null;
        public string idPassport = null;
        public string idEmployee = null;
        public TechinspectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command2 = new MySqlCommand($"UPDATE request SET sent_tech_inspect=@sent_tech_inspect WHERE id_req={idReq}", db.getConnection());
            command2.Parameters.AddWithValue("@sent_tech_inspect", 1);

            db.openConnection();

            try
            {
                command2.ExecuteNonQuery();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlCommand command4 = new MySqlCommand($"INSERT into techinspection (time_spending, cost, id_car, id_employee) values(@time_spending, @cost, @id_car, @id_employee)", db.getConnection());
            command4.Parameters.AddWithValue("@time_spending", timeSpendingTxt.Text);
            command4.Parameters.AddWithValue("@cost", CostTxt.Text);
            command4.Parameters.AddWithValue("@id_car", idCar);
            command4.Parameters.AddWithValue("@id_employee", idEmployee);
            db.openConnection();

            try
            {
                timeSpendingTxt.Text = "";
                CostTxt.Text = "";
                command4.ExecuteNonQuery();
                MessageBox.Show("Технический осмотр успешно добавлен", "Удача", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
