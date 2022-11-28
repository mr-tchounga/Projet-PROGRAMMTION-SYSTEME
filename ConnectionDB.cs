using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proj_PROG_SYS
{
    public partial class ConnectionDB : Form
    {
        public ConnectionDB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_qtyAvailable(object sender, EventArgs e)
        {

        }

        public string cnxString = "Data Source=MR-T;Initial Catalog=Restau;Integrated Security=True";

        private void button_validate(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(cnxString);
            cnx.Open();

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO Material(items,qty,available) VALUES ('"+name.Text.ToString()+"', '"+totalQty.Text.ToString()+"', '"+QtyAvailable.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New item successfully added!");
            }
        }

        private void textBox_itemName(object sender, EventArgs e)
        {

        }

        private void textBox2_totalQty(object sender, EventArgs e)
        {

        }
    }
}
