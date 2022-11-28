using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class TableRow_controller
    {
        public TableRow_controller()
        {

        }

        // INSERT NEW MATERIAL
        public void AddTableRow(string id_Table)
        {   
            string query = $"INSERT INTO TableRow(id_Table) VALUES ({id_Table})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditTableRow(string id, string id_Table, string qty, string available)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE TableRow SET items={id_Table},qty={qty},available={available} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteTableRow(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM TableRow WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayTableRow()
        {
            string query = "SELECT * FROM TableRow";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindTableRow(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM TableRow WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
