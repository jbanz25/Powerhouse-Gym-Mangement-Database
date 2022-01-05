using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Frm_AddProduct : Form
    {
        public Frm_AddProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19GDBOJ;Initial Catalog=D:\LOGIN\LOGIN\DATAGYM.MDF;Integrated Security=True");
        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnm.Focus();
            }
        }

        private void txtnm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcmpanynm.Focus();
            }
        }

        private void txtcmpanynm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboproduct.Focus();
            }
        }

        private void comboproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtqty.Focus();
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtperunitrate.Focus();
            }
        }

        private void txtperunitrate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtotalcost.Focus();
            }
        }

        private void txtotalcost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Product VALUES ('" + txtid.Text + "','" + txtnm.Text + "','" + txtcmpanynm.Text + "','" + comboproduct.Text + "','" + combotype.Text + "','" + txtqty.Text + "','" + txtperunitrate.Text + "','" + txtotalcost.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Data...");
            con.Close();
            Reset();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Product Where ID='" + txtid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data...");
            con.Close();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Product SET Name ='" + txtnm.Text + "', Company_Name ='" + txtcmpanynm.Text + "', Product ='" + comboproduct.Text + "',Type='"+combotype.Text+"', Quantity ='" + txtqty.Text + "', Per_Unit_Cost ='" + txtperunitrate.Text + "', Total_Cost ='" + txtotalcost.Text + "' Where ID='" + txtid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data...");
            con.Close();
            
        }

        
         public void Reset()
        {
            txtid.Clear();
            txtnm.Clear();
            txtcmpanynm.Clear();
            comboproduct.Items.Clear();
            combotype.Items.Clear();
            txtqty.Clear();
            txtperunitrate.Clear();
            txtotalcost.Clear();
        }
        private void btnnew_Click_1(object sender, EventArgs e)
        {
             SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max (cast(ID as int)),0)+1 From Product", con);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             txtid.Text = dt.Rows[0][0].ToString();
             this.ActiveControl = txtnm;
             txtnm.Clear();
             txtcmpanynm.Clear();
             comboproduct.Text = "";
             combotype.Text = "";
             txtqty.Clear();
             txtperunitrate.Clear();
             txtotalcost.Clear();
        }
        
        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            String q = "select * from Product";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtnm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtcmpanynm.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboproduct.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            combotype.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtqty.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtperunitrate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtotalcost.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_AddProduct_Load(object sender, EventArgs e)
        {

        }                
    }
}
