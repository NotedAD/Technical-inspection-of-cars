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
    internal class ClassTechinspectionDB
    {

        #region Read Items Table

        public DataTable ReadItemsTable()
        {
            DB db = new DB();

            string query = $"SELECT client.*,employee.*,techinspection.* FROM techinspection" +
                $" INNER JOIN employee ON employee.id = techinspection.id_employee" +
                $" INNER JOIN car ON car.id_car = techinspection.id_car" +
                $" INNER JOIN client ON client.id = car.id_client;";
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
