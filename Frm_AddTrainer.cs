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
    public partial class Frm_AddTrainer : Form
    {
        public Frm_AddTrainer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19GDBOJ;Initial Catalog=D:\LOGIN\LOGIN\DATAGYM.MDF;Integrated Security=True");
        private void txtrainerid_KeyDown(object sender, KeyEventArgs e)
        {
            
        
            if (e.KeyCode == Keys.Enter)
            {
                txttrainernm.Focus();
            }
        
        }

        private void txttrainernm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaress.Focus();
            }
        }

        private void txtaress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontactno.Focus();
            }
        }

        private void txtcontactno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmailid.Focus();
            }
        }

        private void txtmailid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combogender.Focus();
            }
        }

        private void combogender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdob.Focus();
            }
        }

        private void txtdob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtage.Focus();
            }
        }

        private void txtage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpdojoin.Focus();
            }
        }

        private void dtpdojoin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsalery.Focus();
            }
        }

        private void txtsalery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtheight.Focus();
            }
        }

        private void txtheight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtweight.Focus();
            }
        }

        private void txtweight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_AddTrainer VALUES ('" + txtrainerid.Text + "','" + txttrainernm.Text + "','" + txtaress.Text + "','" + txtcontactno.Text + "','" + txtmailid.Text + "','" + combogender.Text + "','" + txtdob.Text + "','" + txtage.Text + "','" + dtpdojoin.Text + "','"+txtsalery.Text+ "','" + txtheight.Text + "','" + txtweight.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Data...");
            con.Close();
            Clear();
         }

        void Clear()
        {
            txtrainerid.Clear();
            txttrainernm.Clear();
            txtaress.Clear();
            txtcontactno.Clear();
            txtmailid.Clear();
            combogender.Text = "";
            txtdob.Clear();
            txtage.Clear(); txtsalery.Clear();
            txtheight.Clear();
            txtweight.Clear();
        }
        private void Frm_AddTrainer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataGymDataSet1.tbl_AddTrainer' table. You can move, or remove it, as needed.
            this.tbl_AddTrainerTableAdapter.Fill(this.dataGymDataSet1.tbl_AddTrainer);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tbl_AddTrainer Where Trainer_ID='" + txtrainerid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data...");
            con.Close();
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_AddTrainer SET Trainer_ID ='" + txtrainerid.Text + "', Trainer_Name ='" + txttrainernm.Text + "', Address ='" + txtaress.Text + "', Contact_No ='" + txtcontactno.Text + "', Mail_ID ='" + txtmailid.Text + "', Gender ='" + combogender.Text + "', Date_Of_Birth ='" + txtdob.Text + "', Age ='" + txtage.Text + "', Date_Of_Joining ='" + dtpdojoin.Text + "', Salery='" + txtsalery.Text + "', Height ='" + txtheight.Text + "', Weight ='" + txtweight.Text + "' Where Trainer_ID='" + txtrainerid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data...");
            con.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max (cast(Trainer_ID as int)),0)+1 From tbl_AddTrainer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtrainerid.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txttrainernm;
            txttrainernm.Clear();
            txtaress.Clear();
            txtcontactno.Clear();
            txtmailid.Clear();
           // combogender.Items.Clear();
            txtdob.Clear();
            txtage.Clear();
            txtsalery.Clear();
            txtheight.Clear();
            txtweight.Clear();
        }

        private void View_Click(object sender, EventArgs e)
        {
            con.Open();
            String q = "select * from tbl_AddTrainer";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtrainerid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txttrainernm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtaress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcontactno.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtmailid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            combogender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtdob.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtage.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dtpdojoin.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtsalery.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtheight.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtweight.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            
        }     
       
    }
}
