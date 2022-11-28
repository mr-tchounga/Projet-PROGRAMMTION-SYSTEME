using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Table_material_controller
    {
        public Table_material_controller()
        {

        }

        // INSERT NEW MATERIAL
        public void AddTable_material(string id_Table, string id_Material, string mat_qty)
        {
            
            string query = $"INSERT INTO Table_material(items,id_Material,mat_qty) VALUES ({id_Table}, {id_Material}, {mat_qty})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditTable_material(string id_Table, string id_Material, string mat_qty)
        {
            if(id_Table == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Table_material SET items={id_Table},id_Material={id_Material},mat_qty={mat_qty} WHERE id_Table={id_Table}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteTable_material(string id_Table)
        {
            if(id_Table == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Table_material WHERE id={id_Table}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayTable_material()
        {
            string query = "SELECT * FROM Table_material";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindTable_material(string id_Table)
        {
            if (id_Table == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Table_material WHERE id_Table={id_Table}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
