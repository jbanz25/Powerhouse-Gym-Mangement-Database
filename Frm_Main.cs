using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewMember ss = new Frm_NewMember();
            ss.Show();
        }

        private void newTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddTrainer ad = new Frm_AddTrainer();
            ad.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddProduct ss = new Frm_AddProduct();
            ss.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
      

        
        

                

       