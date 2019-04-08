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

namespace Mech_Thesis
{
    public partial class Engine_Classification : Form
    {
        public Form previousform { get; set; }

        MySqlConnection conn;
        public Engine_Classification()
        {
            conn = new MySqlConnection("SERVER=localhost; DATABASE=mech_thesis; uid = root; pwd = root");

            InitializeComponent();

        }

        private void Engine_Classification_Load(object sender, EventArgs e)
        {

        }

        //Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Code for the form to be moved
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

     

        private void Engine_Classification_MouseDown(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Engine_Classification_MouseMove(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }


        private void Engine_Classification_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //Loads information in the grid view
        public void loadInfo()
        {
            if (table == "cyclinder_arrangement")
            {
                String query = "SELECT * FROM " + table + "";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dtgvti.DataSource = dt;
                dtgvti.Columns["id"].Visible = false;
                dtgvti.Columns["name"].HeaderText = "Name";
                dtgvti.Columns["description"].Visible = false;
                dtgvti.Columns["applications"].Visible = false;
            }
            else
            {
                String query = "SELECT * FROM " + table + "";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dtgvti.DataSource = dt;
                dtgvti.Columns["id"].Visible = false;
                dtgvti.Columns["name"].HeaderText = "Name";
                dtgvti.Columns["description"].Visible = false;
            }
         

        }



      
        // Loads information depending on what text is clicked
        public static string table;
        private void lbti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "ignition";
            loadInfo();
        }

        private void lblec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "engine_cycle";
            loadInfo();
        }

        private void lblvl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "valve_location";
            loadInfo();
        }

        private void lblbd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "basic_design";
            loadInfo();
        }

        private void lblpe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "cyclinder_arrangement";
            loadInfo();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "cyclinder_arrangement";
            loadInfo();
        }

        private void lblap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "breathing";
            loadInfo();
        }

        private void lblmi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "method_of_fuel_input";
            loadInfo();
        }

        private void lblfu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "type_of_fuel";
            loadInfo();
        }

      
        private void lbltc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            table = "cooling_method";
            loadInfo();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                {

                    txtdesc.Text = dtgvti.Rows[e.RowIndex].Cells["description"].Value.ToString();
                }

         }

        // When link is clicked, it goes back to the main menu
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            previousform.Show();
        }
        // When link is clicked, it goes back to the main menu
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            previousform.Show();
        }
    }
}
