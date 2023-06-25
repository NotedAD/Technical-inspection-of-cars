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
    public partial class Techinspection : UserControl
    {
        public Techinspection()
        {
            InitializeComponent();
        }
        private string _surnameEmployee;
        private string _cost;
        private string _timeSpend;
        private string _idTechinspect;
        private string _idCar;
        private string _idEmployee;

        [Category("Custom Props")]
        public string SurnEmpl
        {
            get { return _surnameEmployee; }
            set
            { _surnameEmployee = value; surnameEmployeeLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Cost
        {
            get { return _cost; }
            set
            { _cost = value; costLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string TimeSpending
        {
            get { return _timeSpend; }
            set
            { _timeSpend = value; timeSpendingLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string IdTechinspect
        {
            get { return _idTechinspect; }
            set
            { _idTechinspect = value;  }
        }
        [Category("Custom Props")]
        public string IdCar
        {
            get { return _idCar; }
            set
            { _idCar = value; }
        }
        [Category("Custom Props")]
        public string IdEmploy
        {
            get { return _idEmployee; }
            set
            { _idEmployee = value; }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            EditTechinspectionForm editTechinspectionForm = new EditTechinspectionForm();
            editTechinspectionForm.id = IdTechinspect;
            editTechinspectionForm.Show();
        }
    }
}
