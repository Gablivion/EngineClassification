using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace Mech_Thesis
{
  
    public partial class Mech : Form
    {
        MySqlConnection conn;
        public Mech()
        {
            conn = new MySqlConnection("SERVER=localhost; DATABASE=mech_thesis; uid = root; pwd = root; Allow Zero Datetime=True ");
            InitializeComponent();
        }

    
        private void Mech_Load(object sender, EventArgs e)
        {
        }

        // When the word "ECAMP" is clicked the main menu is shown
        private void label1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        // When mouse hovers over the text "ECAMP" it will change to "Start"
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "START";
        }
        // When mouse leaves  the text "Start" it will change to "ECAMP"
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "ECAMP";
        }
    }
}
