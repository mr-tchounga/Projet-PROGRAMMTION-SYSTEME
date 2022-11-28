using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Kitchen_stuff_controller
    {
        public Kitchen_stuff_controller()
        {

        }

        // INSERT NEW MATERIAL
        public void AddKitchen_stuff(string name, string qty, string available)
        {
            
            string query = $"INSERT INTO Kitchen_stuff(items,qty,available) VALUES ({name}, {qty}, {available})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
            MessageBox.Show("Request Successfull!");
        }


        // EDIT MATERIAL
        public void EditKitchen_stuff(string id, string name, string qty, string available)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Kitchen_stuff SET items={name},qty={qty},available={available} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
                MessageBox.Show("Request Successfull!");
            }

        }


        // REMOVE MATERIAL
        public void DeleteKitchen_stuff(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Kitchen_stuff WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
                MessageBox.Show("Request Successfull!");
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayKitchen_stuff()
        {
            string query = "SELECT * FROM Kitchen_stuff";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
            MessageBox.Show("Request Successfull!");
        }


        // FIND A MATERIAL
        protected void FindKitchen_stuff(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Kitchen_stuff WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
                MessageBox.Show("Request Successfull!");
            }
        }

    }
}
