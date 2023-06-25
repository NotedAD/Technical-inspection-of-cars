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
using Техничесикй_осмотр_автомобилей.Forms;

namespace Техничесикй_осмотр_автомобилей
{
    public partial class CheckOrder : UserControl
    {
        public CheckOrder()
        {
            InitializeComponent();
        }
        #region Getter & Setter For Labels & Picture Box
        private string _modelCar;
        private string _colorCar;
        private string _typeCar;
        private string _idCar;
        private string _idPerfomancecar;

        [Category("Custom Props")]
        public string ModelCar
        {
            get { return _modelCar; }
            set
            { _modelCar = value; modelCarLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string ColorCar
        {
            get { return _colorCar; }
            set
            { _colorCar = value; colorCarLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string TypeCar
        {
            get { return _typeCar; }
            set
            { _typeCar = value; typeCarLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string IdCar
        {
            get { return _idCar; }
            set
            { _idCar = value; idcar.Text = value; }
        }
        [Category("Custom Props")]
        public string IdPerfomancecar
        {
            get { return _idPerfomancecar; }
            set
            { _idPerfomancecar = value; idperfcar.Text = value; }
        }
        #endregion
        MainForm form = new MainForm();
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"DELETE car, perfomancecar FROM car INNER JOIN perfomancecar WHERE car.id_car = {idcar.Text} AND perfomancecar.id_perfcar = {idperfcar.Text}", db.getConnection());

            db.openConnection();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запись удалена", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.GenerateDynamicUserControlCheckOrder(form.idClient, "");
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            EditCheckOrder editCheckOrder = new EditCheckOrder();
            editCheckOrder.idCar = idcar.Text;
            editCheckOrder.Show();
        }
    }
}
