using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_and_reference_catalog_of_computer_games
{
    internal class ClassCheckOrderBLL
    {

        #region Get Items
        public DataTable GetItems(string id, string search)
        {
            try
            {
                ClassCheckOrderDB objdal = new ClassCheckOrderDB();
                return objdal.ReadItemsTable(id, search);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
