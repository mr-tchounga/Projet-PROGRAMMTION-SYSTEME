using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.Controller
{
    class Staff_controller
    {
        public Staff_controller()
        {

        }

        // INSERT NEW STAFF MEMEBER
        public void AddStaff(string name, string age, string role, string phone_no, string email, string employment_date)
        {
            
            string query = $"INSERT INTO Staff(name,age,role,phone_no,email,employment_date) VALUES ({name}, {age}, {role}, {phone_no}, {email}, {employment_date})";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // EDIT MATERIAL
        public void EditStaff(string id, string name, string age, string role, string phone_no, string email, string employment_date)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"UPDATE Staff SET items={name},age={age},role={role},phone_no={phone_no},email={email},employment_date={employment_date} WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // REMOVE MATERIAL
        public void DeleteStaff(string id)
        {
            if(id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"DELETE FROM Staff WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }

        }


        // DISPLAY MATERIALS
        protected void DisplayStaff()
        {
            string query = "SELECT * FROM Staff";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }


        // FIND A MATERIAL
        protected void FindStaff(string id)
        {
            if (id == null)
            {
                MessageBox.Show("ERROR: No ID was entered!!");
            }
            else
            {
                string query = $"SELECT * FROM Staff WHERE id={id}";

                ConnectionDB cnx = new ConnectionDB();
                cnx.Connection(query);
            }
        }

    }
}
