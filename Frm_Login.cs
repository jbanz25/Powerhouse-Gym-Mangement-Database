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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19GDBOJ;Initial Catalog=D:\LOGIN\LOGIN\DATAGYM.MDF;Integrated Security=True");
        
        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbllogin.Focus();
            }
        }

        private void lbllogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblexit.Focus();
            }
        }
        private void lblexit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtuser.Focus();
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Reset()
        {
            txtuser.Clear();
            txtpass.Clear();
            
        }
        private void lbllogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) From tbl_Login Where UserName='" + txtuser.Text + "' and Password='" + txtpass.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Frm_Main fm = new Frm_Main();
                fm.Show();
                MessageBox.Show("WelCome To Powerhouse Gym");
            }
            else
            {
                MessageBox.Show("Please Check You User Name and Password");
            }
            Reset();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }
    }
}
