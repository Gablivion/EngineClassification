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
    public partial class Main : Form
    {
        MySqlConnection conn;
        public Main()
        {
            conn = new MySqlConnection("SERVER=localhost; DATABASE=mech_thesis; uid = root; pwd = root; Allow Zero Datetime=True ");
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            
        }
 

        //Loads the material in the GridView and selects in according to the sorting
        public void loadMaterials()
        {
            String query = "SELECT id, name,alloy_type,material_type  FROM material where material_type = '" + material + "'";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            materialGridView.DataSource = dt;
            materialGridView.Columns["id"].Visible = false;
            materialGridView.Columns["material_type"].Visible = false;
            materialGridView.Columns["alloy_type"].Visible = false;
            materialGridView.Columns["name"].HeaderText = "Material Name";

        }

        // Loads the details of the Material selected in the Grid View
        public void loadData()
        {
           
            String query = "SELECT * from material where id = "+ id +"";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;
            conn.Open();
            MySqlDataReader drd = comm.ExecuteReader();


            while (drd.Read())
            {
                txtem.Text = lblem.Text = drd["elastic_modulus"].ToString();
                txtsm.Text = lblsmod.Text = drd["shear_modulus"].ToString();
                txtts.Text = lblts.Text = drd["tensile_strength"].ToString();
                txtcs.Text = lblcs.Text = drd["compressive_strength"].ToString();
                txtmd.Text = lblmd.Text = drd["mass_density"].ToString();
                txttc.Text = lbltc.Text = drd["thermal_conductivity"].ToString();
                txttec.Text = lbltc.Text = drd["thermal_expansion_coefficient"].ToString();
                txtpr.Text = lblpr.Text = drd["poissons_ratio"].ToString();
                txtsh.Text = lblsh.Text = drd["specific_heat"].ToString();
                txtmdr.Text = lblmdr.Text = drd["material_damping_ratio"].ToString();
                txtys.Text = lblys.Text = drd["yeild_strength"].ToString();
                
            }
            conn.Close();
        }

        // Selection that is the basis of sorting for the grid view
        public string material;
        public Boolean alloy = false;
        private void materialcmb_SelectedValueChanged(object sender, EventArgs e)
        {

            if (materialcmb.Text.Contains("Alloy"))
            {
                material = "Alloy";

                loadMaterials();
            }
            else
            {
                material = "Iron";
                loadMaterials();
            }
        }

        // Selection that is the basis of sorting for the grid view
        private void alloyCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (materialcmb.Text.Contains("Alloy"))
            {
                alloy = true;
                loadMaterials();
                alloy = false;
            }
            else
            {
                alloy = false;
                loadMaterials();
            }
        }


        // When the Grid View is clicked, the details of the material is shown on the left
        public static int id;
        private void materialGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = int.Parse(materialGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                loadData();
            }
        }
       
        // Exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Code for the form to be moved
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }
        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        //When the picture is clicked, it shows The Engine Classification Panel
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Engine_Classification eclass = new Engine_Classification();
            eclass.Show();
            this.Hide();
            eclass.previousform = this;
        }

        //When the label is clicked, it shows The Engine Classification Panel
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Engine_Classification eclass = new Engine_Classification();
            eclass.Show();
            this.Hide();
            eclass.previousform = this;
        }
    }
}
