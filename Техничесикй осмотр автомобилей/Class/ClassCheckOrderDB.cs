using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Техничесикй_осмотр_автомобилей;

namespace Information_and_reference_catalog_of_computer_games
{
    internal class ClassCheckOrderDB
    {

        #region Read Items Table

        public DataTable ReadItemsTable(string id, string search)
        {
            string query = null;
            DB db = new DB();
            if(search == "")
            {
                query = $"SELECT car.*, perfomancecar.* FROM car INNER JOIN perfomancecar ON perfomancecar.id_perfcar = car.id_perfomancecar where car.id_client = {id}";
            }
            else
            {
                query = $"SELECT car.*, perfomancecar.* FROM car INNER JOIN perfomancecar ON perfomancecar.id_perfcar = car.id_perfomancecar where car.id_client = {id} and car.car_model like '%" + search + "%' or perfomancecar.body_color like '%" + search + "%' or perfomancecar.engine_capacity like '%" + search + "%' or perfomancecar.year_issue like '%" + search + "%' or perfomancecar.type_car like '%" + search + "%' or perfomancecar.vin_number like '%" + search + "%'";
            }
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
