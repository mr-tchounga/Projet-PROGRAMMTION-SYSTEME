using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Form2 simulation = new Form2();
            simulation.Visible = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form1 gestion_stock = new Form1();
            gestion_stock.Visible = true;
            this.Visible = false;

    }
}
}
