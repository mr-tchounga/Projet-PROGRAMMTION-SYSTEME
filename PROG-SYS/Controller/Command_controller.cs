using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Command_controller
    {
        public Command_controller()
        {

        }

        // INSERT NEW STAFF MEMEBER
        public void AddCommand(string amount, string command_date, string id_Staff, string id_Table, string id_Recipe, string id_Client)
        {
            
            string query = $"INSERT INTO Command(amount,command_date,id_Staff,id_Table,id_Recipe,id_Client) VALUES ({amount}, {command_date}, {id_Staff}, {id_Table}, {id_Recipe}, {id_Client})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditCommand(string id, string amount, string command_date, string id_Staff, string id_Table, string id_Recipe, string id_Client)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Command SET items={amount},command_date={command_date},id_Staff={id_Staff},id_Table={id_Table},id_Recipe={id_Recipe},id_Client={id_Client} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteCommand(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Command WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayCommand()
        {
            string query = "SELECT * FROM Command";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindCommand(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Command WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
