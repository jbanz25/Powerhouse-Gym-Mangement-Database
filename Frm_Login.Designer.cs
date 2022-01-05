namespace Login
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.OrangeRed;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtpass.Location = new System.Drawing.Point(838, 710);
            this.txtpass.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(461, 48);
            this.txtpass.TabIndex = 9;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.OrangeRed;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(838, 614);
            this.txtuser.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(461, 48);
            this.txtuser.TabIndex = 8;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblpass.Location = new System.Drawing.Point(564, 718);
            this.lblpass.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(227, 40);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "PASSWORD";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbluser.Location = new System.Drawing.Point(560, 622);
            this.lbluser.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(231, 40);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "USER NAME";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Black;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbllogin.Location = new System.Drawing.Point(840, 833);
            this.lbllogin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(192, 55);
            this.lbllogin.TabIndex = 12;
            this.lbllogin.Text = "LOG IN";
            this.lbllogin.Click += new System.EventHandler(this.lbllogin_Click);
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Black;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblexit.Location = new System.Drawing.Point(1147, 833);
            this.lblexit.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(134, 55);
            this.lblexit.TabIndex = 13;
            this.lblexit.Text = "EXIT";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(735, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 154);
            this.label1.TabIndex = 14;
            this.label1.Text = "Powerhouse Gym";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(828, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mangement System ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(632, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1880, 1022);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}