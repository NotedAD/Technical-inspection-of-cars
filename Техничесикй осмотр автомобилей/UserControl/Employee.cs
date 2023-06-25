using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Техничесикй_осмотр_автомобилей
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }
        #region Getter & Setter For Labels & Picture Box
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _rank; 
        private string _job_title;

        [Category("Custom Props")]
        public string Namee
        {
            get { return _name; }
            set
            { _name = value; nameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Surname
        {
            get { return _surname; }
            set
            { _surname = value; surnameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Patronymic
        {
            get { return _patronymic; }
            set
            { _patronymic = value; patronLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string Rank
        {
            get { return _rank; }
            set
            { _rank = value; rankLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string JobTitle
        {
            get { return _job_title; }
            set
            { _job_title = value; jobTitleLbl.Text = value; }
        }
    }
}
#endregion