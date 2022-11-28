using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Table_controller
    {
        public Table_controller()
        {

        }

        // INSERT NEW MATERIAL
        public void AddTable(string no_places, string qty, string available)
        {
            
            string query = $"INSERT INTO Table(no_places,qty,available) VALUES ({no_places}, {qty}, {available})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditTable(string id, string no_places, string qty, string available)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Table SET items={no_places},qty={qty},available={available} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteTable(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Table WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayTable()
        {
            string query = "SELECT * FROM Table";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindTable(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Table WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
