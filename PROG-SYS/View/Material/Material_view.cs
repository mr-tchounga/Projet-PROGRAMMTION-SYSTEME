﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_SYS.View.Material
{
    public partial class Material_view : Form
    {
        public Material_view()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Material";

            ConnectionDB cnx = new ConnectionDB();
            cnx.Connection(query);
        }
    }
}