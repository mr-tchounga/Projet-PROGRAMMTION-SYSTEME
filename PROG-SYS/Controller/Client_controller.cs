using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Client_controller
    {
        public Client_controller()
        {

        }

        // INSERT NEW STAFF MEMEBER
        public void AddClient(string name, string phone_no, string email, string presence_date, string pref_taste, string pref_menu, string pref_server, string command_style)
        {
            
            string query = $"INSERT INTO Client(name,phone_no,email,presence_date,pref_taste,pref_menu,pref_server,command_style) VALUES ({name},{phone_no},{email},{presence_date},{pref_taste},{pref_menu},{pref_server},{command_style})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditClient(string id, string name, string phone_no, string email, string presence_date, string pref_taste, string pref_menu, string pref_server, string command_style)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Client SET items={name},phone_no={phone_no},email={email},presence_date={presence_date},pref_taste={pref_taste},pref_menu={pref_menu},pref_server={pref_server},command_style={command_style} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteClient(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Client WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayClient()
        {
            string query = "SELECT * FROM Client";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindClient(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Client WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
