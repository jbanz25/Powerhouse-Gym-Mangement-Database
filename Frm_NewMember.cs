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
    public partial class Frm_NewMember : Form
    {
        public Frm_NewMember()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19GDBOJ;Initial Catalog=D:\LOGIN\LOGIN\DATAGYM.MDF;Integrated Security=True");
        private void combopersnaltrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string q = "SELECT Trainer_Name FROM tbl_AddTrainer where Persnal_Trainer='" + combopersnaltrainer.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                while (r.Read())
                {
                    combopersnaltrainer.Items.Add(r.GetString(0));
                }
            }
            con.Close();
        }

        public void reset()
        {
            txtmemberid.Clear();
            txtmembernm.Clear();
            txtaddress.Clear();
            txtcontactno.Clear();
            txtmailid.Clear();
            combogender.Text = "";
            txtdob.Clear();
            txtage.Clear();
            txtplane.Clear();
            dtpdojoin.Text = System.DateTime.Now.ToString();
            dtpdoend.Text = System.DateTime.Now.ToString();
            combopersnaltrainer.Text = "";
            txtamount.Clear();
            comboamountstatus.Text = "";
            txtpeningamount.Clear();
            txtheight.Clear();
            txtweight.Clear();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_NewMember VALUES ('" + txtmemberid.Text + "','" + txtmembernm.Text + "','" + txtaddress.Text + "','" + txtcontactno.Text + "','" + txtmailid.Text + "','" + combogender.Text + "','" + txtdob.Text + "','" + txtage.Text + "','" + txtplane.Text + "','" + dtpdojoin.Text + "','" + dtpdoend.Text + "','" + combopersnaltrainer.Text + "','" + txtamount.Text + "','" + comboamountstatus.Text + "','" + txtpeningamount.Text + "','" + txtheight.Text + "','" + txtweight.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Data...");
            con.Close();
            reset();
            
            //display();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtmemberid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtmembernm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcontactno.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtmailid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            combogender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtdob.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtage.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtplane.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpdojoin.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            dtpdoend.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            combopersnaltrainer.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtamount.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            comboamountstatus.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            txtpeningamount.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            txtheight.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            txtweight.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
        }


        //void display()
        //{
        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_NewMember",con);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    dataGridView1.Rows.Clear();
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        int n = dataGridView1.Rows.Add();
        //        dataGridView1.Rows[0].Cells[0].Value = item["First"].ToString();
        //        dataGridView1.Rows[0].Cells[1].Value = item[1].ToString();
        //        dataGridView1.Rows[0].Cells[2].Value = item[2].ToString();
        //        dataGridView1.Rows[0].Cells[3].Value = item[3].ToString();
        //        dataGridView1.Rows[0].Cells[4].Value = item[4].ToString();
        //        dataGridView1.Rows[0].Cells[5].Value = item[5].ToString();
        //        dataGridView1.Rows[0].Cells[6].Value = item[6].ToString();
        //        dataGridView1.Rows[0].Cells[7].Value = item[7].ToString();
        //        dataGridView1.Rows[0].Cells[8].Value = item[8].ToString();
        //        dataGridView1.Rows[0].Cells[9].Value = item[9].ToString();
        //        dataGridView1.Rows[0].Cells[10].Value = item[10].ToString();
        //        dataGridView1.Rows[0].Cells[11].Value = item[11].ToString();
        //        dataGridView1.Rows[0].Cells[12].Value = item[12].ToString();
        //        dataGridView1.Rows[0].Cells[13].Value = item[13].ToString();
        //        dataGridView1.Rows[0].Cells[14].Value = item[14].ToString();
        //        dataGridView1.Rows[0].Cells[15].Value = item[15].ToString();
        //        dataGridView1.Rows[0].Cells[16].Value = item[16].ToString();
        //    }
        //}
        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tbl_NewMember Where Member_ID='" + txtmemberid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Data...");
            con.Close();
            reset();
        }
           
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE  tbl_NewMember SET  Member_ID ='" + txtmemberid.Text + "', Member_Name ='" + txtmembernm.Text + "', Address ='" + txtaddress.Text + "', Contact_No ='" + txtcontactno.Text + "', Mail_ID ='" + txtmailid.Text + "', Gender ='" + combogender.Text + "', Date_Of_Birth ='" + txtdob.Text + "', Age ='" + txtage.Text + "', Plane_Type ='" + txtplane.Text + "', Date_Of_Joining ='" + dtpdojoin.Text + "', Date_Of_End ='" + dtpdoend.Text + "',Personal_Trainer ='" + combopersnaltrainer.Text + "', Amount ='" + txtamount.Text + "', Amout_Status ='" + comboamountstatus.Text + "', Pending_Amount ='" + txtpeningamount.Text + "', Height ='" + txtheight.Text + "', Weight ='" + txtweight.Text + "' Where Member_ID ='" + txtmemberid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Data...");
            con.Close();
            reset();
        }

        private void btnview_Click(object sender, EventArgs e)
        {

        }

        private void Frm_NewMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataGymDataSet.tbl_NewMember' table. You can move, or remove it, as needed.
           // this.tbl_NewMemberTableAdapter.Fill(this.dataGymDataSet.tbl_NewMember);

        }

        private void txtmemberid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmembernm.Focus();
            }
        }

        private void txtmembernm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
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
                txtplane.Focus();
            }
        }

        private void txtplane_KeyDown(object sender, KeyEventArgs e)
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
                dtpdoend.Focus();
            }
        }

        private void dtpdoend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combopersnaltrainer.Focus();
            }
        }

        private void combopersnaltrainer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtamount.Focus();
            }
        }

        private void txtamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboamountstatus.Focus();
            }
        }

        private void comboamountstatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpeningamount.Focus();
            }
        }

        private void txtpeningamount_KeyDown(object sender, KeyEventArgs e)
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

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndelete.Focus();
            }
        }

        private void btndelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnupdate.Focus();
            }
        }

        private void btnupdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnview.Focus();
            }
        }

        private void btnview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnclose.Focus();
            }
        }

        private void btnclose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmemberid.Focus();
            }
        }

       
        private void btnnew_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max (cast(Member_ID as int)),0)+1 From tbl_NewMember", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtmemberid.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txtmembernm;
            txtmembernm.Clear();
            txtaddress.Clear();
            txtcontactno.Clear();
            txtmailid.Clear();
           // combogender.Items.Clear();
            txtdob.Clear();
            txtage.Clear();
            txtplane.Clear();
            dtpdojoin.Text = System.DateTime.Now.ToString();
            dtpdoend.Text = System.DateTime.Now.ToString();
           // combopersnaltrainer.Items.Clear();
            txtamount.Clear();
        // comboamountstatus.Items.Clear();
            txtpeningamount.Clear();
            txtheight.Clear();
            txtweight.Clear();
        }

        private void btnview_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string a = "SELECT * FROM tbl_NewMember";
            SqlDataAdapter sda = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboamountstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
        
        

                         
              
   
