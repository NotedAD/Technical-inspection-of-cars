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
    public partial class ActiveOrder : UserControl
    {
        public ActiveOrder()
        {
            InitializeComponent();
        }
        private string _modelCar;
        private string _name;
        private string _surname;
        private string _idReq;
        private string _idCar;
        private string _idClient;
        private string _idEmployee;

        [Category("Custom Props")]
        public string ModelCar
        {
            get { return _modelCar; }
            set
            { _modelCar = value; modelCarLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set
            { _name = value; colorCarLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Surname
        {
            get { return _surname; }
            set
            { _surname = value; typeCarLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string IdRequest
        {
            get { return _idReq; }
            set
            { _idReq = value; idReq.Text = value; }
        }
        [Category("Custom Props")]
        public string IdCar
        {
            get { return _idCar; }
            set
            { _idCar = value;  }
        }
        [Category("Custom Props")]
        public string IdClient
        {
            get { return _idClient; }
            set
            { _idClient = value; }
        }
        [Category("Custom Props")]
        public string IdEmployee
        {
            get { return _idEmployee; }
            set
            { _idEmployee = value; }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            ActiveOrderForm activeOrderForm = new ActiveOrderForm();
            activeOrderForm.idReq = idReq.Text;
            activeOrderForm.idCar = IdCar; 
            activeOrderForm.idClient = IdClient;
            activeOrderForm.idEmployee = IdEmployee;
            activeOrderForm.Show();
        }
    }
}
