using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Information_and_reference_catalog_of_computer_games;
using Техничесикй_осмотр_автомобилей;
using System.Security.Policy;
using System.Windows.Controls;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Техничесикй_осмотр_автомобилей.Forms
{
    public partial class MainForm : Form
    {
        public bool isEmployee = false;
        public string idClient = null;
        public string idEmployee = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!isEmployee)
            {
                сотрудникуToolStripMenuItem.Visible = false;
            }
            else
            {
                клиентуToolStripMenuItem.Visible = false;    
                famTxt.Visible = false;
                patronTxt.Visible = false;
                phoneTxt.Visible = false;
                placeWorkTxt.Visible = false;
                numberPassportTxt.Visible = false;
                seriesPassportTxt.Visible = false;
                dataIssueTxt.Visible = false;
                authorityTxt.Visible = false;
                nameTxt.Visible = false;
            }
            tabControl1.TabPages.Remove(order);
            tabControl1.TabPages.Remove(orderCheck);
            tabControl1.TabPages.Remove(activeOrder);
            tabControl1.TabPages.Remove(texOsmotr);
            tabControl1.TabPages.Remove(employee);
            tabControl1.TabPages.Remove(report);
        }

        private void заявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(order);
            tabControl1.TabPages.Remove(orderCheck);
        }

        private void просмотретьЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(orderCheck);
            tabControl1.TabPages.Remove(order);
            GenerateDynamicUserControlCheckOrder(idClient, "");
        }

        private void активныеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControlActiveOrder();
            tabControl1.TabPages.Add(activeOrder);
            tabControl1.TabPages.Remove(texOsmotr);
            tabControl1.TabPages.Remove(employee);
            tabControl1.TabPages.Remove(report);
            tabControl1.TabPages.Remove(orderCheck);
            tabControl1.TabPages.Remove(order);
        }

        private void техническийОсмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControlTechinspection();
            tabControl1.TabPages.Add(texOsmotr);
            tabControl1.TabPages.Remove(activeOrder);
            tabControl1.TabPages.Remove(employee);
            tabControl1.TabPages.Remove(report);
            tabControl1.TabPages.Remove(orderCheck);
            tabControl1.TabPages.Remove(order);
        }

        private void сотрудникиГАИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(employee);
            tabControl1.TabPages.Remove(texOsmotr);
            tabControl1.TabPages.Remove(activeOrder);
            tabControl1.TabPages.Remove(report);
            tabControl1.TabPages.Remove(orderCheck);
            tabControl1.TabPages.Remove(order);
            GenerateDynamicUserControlEmployee();
        }

        private void отчетОПроведенномТехОсмотреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(report);
            tabControl1.TabPages.Remove(texOsmotr);
            tabControl1.TabPages.Remove(employee);
            tabControl1.TabPages.Remove(activeOrder);
            tabControl1.TabPages.Remove(orderCheck);
            tabControl1.TabPages.Remove(order);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string idPerfomancecar = null;
            string idPassport = null;
            string idCar = null;
            MySqlCommand command1 = new MySqlCommand($"INSERT into perfomancecar (body_color, engine_capacity, year_issue, type_car, vin_number) values(@body_color" +
 $", @engine_capacity, @year_issue, @type_car, @vin_number)", db.getConnection());
            MySqlCommand commandGetLastID = new MySqlCommand($"SELECT id_perfcar  FROM perfomancecar WHERE (id_perfcar  = LAST_INSERT_ID())", db.getConnection());
            command1.Parameters.AddWithValue("@body_color", colorTxt.Text);
            command1.Parameters.AddWithValue("@engine_capacity", engineCapacityTxt.Text);
            command1.Parameters.AddWithValue("@year_issue", yearIssueTxt.Text);
            command1.Parameters.AddWithValue("@type_car", typeCarTxt.Text);
            command1.Parameters.AddWithValue("@vin_number", vinNumberTxt.Text);
            db.openConnection();

            try
            {
                command1.ExecuteNonQuery();

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlDataReader reader = commandGetLastID.ExecuteReader();
            while (reader.Read())
            {
                idPerfomancecar = reader[0].ToString();
            }
            reader.Close();

            db.closeConnection();

            MySqlCommand command4 = new MySqlCommand($"INSERT into passport (passport_number, passport_series, date_issue, authority) values(@passport_number" +
                $", @passport_series, @date_issue, @authority)", db.getConnection());
            MySqlCommand commandGetLastID4 = new MySqlCommand($"SELECT id FROM passport WHERE (id = LAST_INSERT_ID())", db.getConnection());
            command4.Parameters.AddWithValue("@passport_number", numberPassportTxt.Text);
            command4.Parameters.AddWithValue("@passport_series", seriesPassportTxt.Text);
            command4.Parameters.AddWithValue("@date_issue", dataIssueTxt.Text);
            command4.Parameters.AddWithValue("@authority", authorityTxt.Text);
            db.openConnection();

            try
            {
                command4.ExecuteNonQuery();

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlDataReader reader4 = commandGetLastID4.ExecuteReader();
            while (reader4.Read())
            {
                idPassport = reader4[0].ToString();
            }
            reader4.Close();

            db.closeConnection();

            MySqlCommand command2 = new MySqlCommand($"UPDATE client SET name=@name, surname=@surname, patronymic=@patronymic, phone_number=@phone_number, place_of_work=@place_of_work, passport_id=@passport_id WHERE id={idClient}", db.getConnection());
            command2.Parameters.AddWithValue("@name", nameTxt.Text);
            command2.Parameters.AddWithValue("@surname", famTxt.Text);
            command2.Parameters.AddWithValue("@patronymic", patronTxt.Text);
            command2.Parameters.AddWithValue("@phone_number", phoneTxt.Text);
            command2.Parameters.AddWithValue("@place_of_work", placeWorkTxt.Text);
            command2.Parameters.AddWithValue("@passport_id", idPassport);

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

            MySqlCommand command3 = new MySqlCommand("INSERT INTO `car` (`car_model`, `id_client`, `id_perfomancecar`) VALUES (@car_model, @id_client, @id_perfomancecar)", db.getConnection());
            MySqlCommand commandGetLastID5 = new MySqlCommand($"SELECT id_car FROM car WHERE (id_car = LAST_INSERT_ID())", db.getConnection());
            db.openConnection();
            command3.Parameters.AddWithValue("@car_model", modelCarTxt.Text);
            command3.Parameters.AddWithValue("@id_client", idClient);
            command3.Parameters.AddWithValue("@id_perfomancecar", idPerfomancecar);

            db.openConnection();
            if (command3.ExecuteNonQuery() == 1)
            {
            }
            else MessageBox.Show("Ошибка создания заявки", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
  

            MySqlDataReader reader5 = commandGetLastID5.ExecuteReader();
            while (reader5.Read())
            {
                idCar = reader5[0].ToString();
            }
            reader5.Close();
            db.closeConnection();

            MySqlCommand command5 = new MySqlCommand("INSERT INTO `request` (`id_client`, `id_car`, `sent_tech_inspect`) VALUES (@id_client, @id_car, @sent_tech_inspect)", db.getConnection());
            command5.Parameters.AddWithValue("@id_client", idClient);
            command5.Parameters.AddWithValue("@id_car", idCar);
            command5.Parameters.AddWithValue("@sent_tech_inspect", 0);
            db.openConnection();
            if (command5.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка создана!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Ошибка создания заявки", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db.closeConnection();

            nameTxt.Text = "";
            famTxt.Text = "";
            patronTxt.Text = "";
            phoneTxt.Text = "";
            placeWorkTxt.Text = "";
            ClientCbb.Text = "";
            numberPassportTxt.Text = "";
            seriesPassportTxt.Text = "";
            dataIssueTxt.Text = "";
            authorityTxt.Text = "";
            nameTxt.Text = "";
            modelCarTxt.Text = "";
            colorTxt.Text = "";
            engineCapacityTxt.Text = "";
            yearIssueTxt.Text = "";
            typeCarTxt.Text = "";
            vinNumberTxt.Text = "";

        }
        private void GenerateDynamicUserControlEmployee()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassEmployeeBLL objbll = new ClassEmployeeBLL();

            System.Data.DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Employee[] listItems = new Employee[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new Employee();
                            listItems[i].Namee = row["name"].ToString();
                            listItems[i].Surname = row["surname"].ToString();
                            listItems[i].Patronymic = row["patronymic"].ToString();
                            listItems[i].Rank = row["rank"].ToString();
                            listItems[i].JobTitle = row["job_title"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }
        public void GenerateDynamicUserControlCheckOrder(string idClient,string search)
        {
            flowLayoutPanel2.Controls.Clear();
            ClassCheckOrderBLL objbll = new ClassCheckOrderBLL();

            System.Data.DataTable dt = objbll.GetItems(idClient, search);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    CheckOrder[] listItems = new CheckOrder[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new CheckOrder();
                            listItems[i].ModelCar = row["car_model"].ToString();
                            listItems[i].ColorCar = row["body_color"].ToString();
                            listItems[i].TypeCar = row["type_car"].ToString();
                            listItems[i].IdCar = row["id_car"].ToString();
                            listItems[i].IdPerfomancecar = row["id_perfcar"].ToString();

                            flowLayoutPanel2.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }
        private void GenerateDynamicUserControlActiveOrder()
        {
            flowLayoutPanel3.Controls.Clear();
            ClassActiveOrderBLL objbll = new ClassActiveOrderBLL();

            System.Data.DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ActiveOrder[] listItems = new ActiveOrder[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new ActiveOrder();
                            listItems[i].ModelCar = row["car_model"].ToString();
                            listItems[i].Name = row["name"].ToString();
                            listItems[i].Surname = row["surname"].ToString();
                            listItems[i].IdRequest = row["id_req"].ToString();
                            listItems[i].IdCar = row["id_car"].ToString();
                            listItems[i].IdClient = row["id_client"].ToString();
                            listItems[i].IdEmployee = idEmployee;


                            flowLayoutPanel3.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }
            private void GenerateDynamicUserControlTechinspection()
            {
                flowLayoutPanel4.Controls.Clear();
                ClassTechinspectionBLL objbll = new ClassTechinspectionBLL();

            System.Data.DataTable dt = objbll.GetItems();

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        Techinspection[] listItems = new Techinspection[dt.Rows.Count];

                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                listItems[i] = new Techinspection();
                                listItems[i].SurnEmpl = row["surname"].ToString();
                                listItems[i].Cost = row["cost"].ToString();
                                listItems[i].TimeSpending = row["time_spending"].ToString();
                                listItems[i].IdTechinspect = row["id_techinsp"].ToString();
                                listItems[i].IdEmploy = row["id_employee"].ToString();
                                listItems[i].IdCar = row["id_car"].ToString();
                            flowLayoutPanel4.Controls.Add(listItems[i]);

                            }
                        }
                    }
                }
            }

        private void report_Enter(object sender, EventArgs e)
        {
            techinspectionCbb.Items.Clear();
            ClientCbb.Items.Clear();
            DB db = new DB();

            string queryInfoTechinspectCbb = $"SELECT id_techinsp, time_spending, cost FROM techinspection";
            string queryInfoClientCbb = $"SELECT * FROM employee";

            MySqlCommand mySqlCommandTechinspectCbb = new MySqlCommand(queryInfoTechinspectCbb, db.getConnection());
            MySqlCommand mySqlCommandClientCbb = new MySqlCommand(queryInfoClientCbb, db.getConnection());

            db.openConnection();

            MySqlDataReader readerTechinspectCbb = mySqlCommandTechinspectCbb.ExecuteReader();
            while (readerTechinspectCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{readerTechinspectCbb[1]} {readerTechinspectCbb[2]}";
                item.Value = readerTechinspectCbb[0];
                techinspectionCbb.Items.Add(item);
            }
            readerTechinspectCbb.Close();


            MySqlDataReader readerClientCbb = mySqlCommandClientCbb.ExecuteReader();
            while (readerClientCbb.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = $"{readerClientCbb[1]} {readerClientCbb[2]} {readerClientCbb[3]}";
                item.Value = readerClientCbb[0];
                ClientCbb.Items.Add(item);
            }
            readerClientCbb.Close();
            db.closeConnection();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO report (result, end_time, car_appraisal, malfunctions, fault_fixed, id_employee, id_client ) VALUES (@result, @end_time, @car_appraisal, @malfunctions, @fault_fixed, @id_employee, @id_client)", db.getConnection());
            command.Parameters.AddWithValue("@result", resultTxt.Text);
            command.Parameters.AddWithValue("@end_time", timeEndLbl.Text);
            command.Parameters.AddWithValue("@car_appraisal", carAppraisalTxt.Text);
            command.Parameters.AddWithValue("@malfunctions", malfunctionsTxt.Text);
            command.Parameters.AddWithValue("@fault_fixed", faultFixedCbb.SelectedItem.ToString());
            command.Parameters.AddWithValue("@id_employee", MySqlDbType.Int32).Value = (ClientCbb.SelectedItem as ComboboxItem).Value;
            command.Parameters.Add("@id_client", MySqlDbType.Int32).Value = (techinspectionCbb.SelectedItem as ComboboxItem).Value;

            db.openConnection();

            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show("Запись успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exexps) 
            {
                MessageBox.Show(exexps.ToString());
            }

            db.closeConnection();

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document sourceDoc = wordApp.Documents.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Шаблон.docx"));
            sourceDoc.Content.Copy();
            Document targetDoc = wordApp.Documents.Add();
            targetDoc.Content.Paste();

            Bookmark bookmark = targetDoc.Bookmarks["ФИО"];
            if (bookmark != null)
            {
                Range range = bookmark.Range;
                range.Text = ClientCbb.SelectedItem.ToString();

            }
            bookmark = targetDoc.Bookmarks["Результат"];
            if (bookmark != null)
            {
                Range range = bookmark.Range;
                range.Text = resultTxt.Text;
            }
            bookmark = targetDoc.Bookmarks["Завершения"];
            if (bookmark != null)
            {
                Range range = bookmark.Range;
                range.Text = timeEndLbl.Text;
            }
            bookmark = targetDoc.Bookmarks["Оценка"];
            if (bookmark != null)
            {
                Range range = bookmark.Range;
                range.Text = carAppraisalTxt.Text;
            }
            bookmark = targetDoc.Bookmarks["Неисправности"];
            if (bookmark != null)
            {
                Range range = bookmark.Range;
                range.Text = malfunctionsTxt.Text;
            }
            bookmark = targetDoc.Bookmarks["НомерТех"];
            if (bookmark != null)
            {
                Range range = bookmark.Range;
                range.Text = (techinspectionCbb.SelectedItem as ComboboxItem).Value.ToString();
            }
            sourceDoc.Close();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Документ Word (*.docx)|*.docx";
            saveFileDialog1.Title = "Сохранить скопированный документ в";
            saveFileDialog1.ShowDialog();
            string targetPath = saveFileDialog1.FileName;
            targetDoc.Close();
            wordApp.Quit();

            Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            Document wordDocument = wordApplication.Documents.Open(targetPath);
            wordApplication.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = "";
            search = textBox1.Text;
            GenerateDynamicUserControlCheckOrder(idClient, search);
        }

    }
}
