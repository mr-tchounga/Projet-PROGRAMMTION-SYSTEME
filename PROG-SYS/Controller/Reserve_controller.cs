using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Reserve_controller
    {
        public Reserve_controller()
        {

        }

        // INSERT NEW STAFF MEMEBER
        public void AddReserve(string amount, string command_date, string id_Client, string id_Table, string id_Recipe, string id_Staff)
        {
            
            string query = $"INSERT INTO Reserve(amount,command_date,id_Staff,id_Table,id_Recipe,id_Client) VALUES ({amount}, {command_date}, {id_Staff}, {id_Table}, {id_Recipe}, {id_Client})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditReserve(string id, string amount, string command_date, string id_Client, string id_Table, string id_Recipe, string id_Staff)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Reserve SET items={amount},command_date={command_date},id_Staff={id_Staff},id_Table={id_Table},id_Recipe={id_Recipe},id_Client={id_Client} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteReserve(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Reserve WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayReserve()
        {
            string query = "SELECT * FROM Reserve";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindReserve(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Reserve WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
