﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROG_SYS
{
    class ConnectionDB
    {
        public ConnectionDB()
        {

        }

        private string cnxString = "Data Source=MR-T;Initial Catalog=Restau;Integrated Security=True";

        public void Connection(string query)
        {
            SqlConnection cnx = new SqlConnection(cnxString);
            cnx.Open();

            if (cnx.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Request Successfull!");
            }

        }
    }
}
