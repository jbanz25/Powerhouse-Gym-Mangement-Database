namespace Login
{
    partial class Frm_AddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboproduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcmpanynm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtotalcost = new System.Windows.Forms.TextBox();
            this.txtperunitrate = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.combotype);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboproduct);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtcmpanynm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtotalcost);
            this.panel1.Controls.Add(this.txtperunitrate);
            this.panel1.Controls.Add(this.txtqty);
            this.panel1.Controls.Add(this.txtnm);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 165);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1631, 622);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // combotype
            // 
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Add Product",
            "Sale Product"});
            this.combotype.Location = new System.Drawing.Point(1132, 49);
            this.combotype.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(466, 48);
            this.combotype.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(828, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 40);
            this.label9.TabIndex = 71;
            this.label9.Text = "Type.:";
            // 
            // comboproduct
            // 
            this.comboproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboproduct.FormattingEnabled = true;
            this.comboproduct.Items.AddRange(new object[] {
            "Gym Equipment",
            "Suppliments"});
            this.comboproduct.Location = new System.Drawing.Point(334, 413);
            this.comboproduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboproduct.Name = "comboproduct";
            this.comboproduct.Size = new System.Drawing.Size(466, 48);
            this.comboproduct.TabIndex = 70;
            this.comboproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboproduct_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 40);
            this.label8.TabIndex = 69;
            this.label8.Text = "Product.:";
            // 
            // txtcmpanynm
            // 
            this.txtcmpanynm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmpanynm.Location = new System.Drawing.Point(334, 279);
            this.txtcmpanynm.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtcmpanynm.Name = "txtcmpanynm";
            this.txtcmpanynm.Size = new System.Drawing.Size(466, 48);
            this.txtcmpanynm.TabIndex = 68;
            this.txtcmpanynm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcmpanynm_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 40);
            this.label7.TabIndex = 67;
            this.label7.Text = "Company Name.:";
            // 
            // txtotalcost
            // 
            this.txtotalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotalcost.Location = new System.Drawing.Point(1132, 399);
            this.txtotalcost.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtotalcost.Name = "txtotalcost";
            this.txtotalcost.Size = new System.Drawing.Size(466, 48);
            this.txtotalcost.TabIndex = 66;
            this.txtotalcost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtotalcost_KeyDown);
            // 
            // txtperunitrate
            // 
            this.txtperunitrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperunitrate.Location = new System.Drawing.Point(1132, 274);
            this.txtperunitrate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtperunitrate.Name = "txtperunitrate";
            this.txtperunitrate.Size = new System.Drawing.Size(466, 48);
            this.txtperunitrate.TabIndex = 65;
            this.txtperunitrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtperunitrate_KeyDown);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(1132, 172);
            this.txtqty.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(466, 48);
            this.txtqty.TabIndex = 64;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            // 
            // txtnm
            // 
            this.txtnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.Location = new System.Drawing.Point(334, 172);
            this.txtnm.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(466, 48);
            this.txtnm.TabIndex = 63;
            this.txtnm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnm_KeyDown);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(334, 54);
            this.txtid.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(466, 48);
            this.txtid.TabIndex = 62;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(828, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 40);
            this.label6.TabIndex = 61;
            this.label6.Text = "Total Cost.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(828, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 40);
            this.label5.TabIndex = 60;
            this.label5.Text = "Per Unit Cost.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(824, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 40);
            this.label4.TabIndex = 59;
            this.label4.Text = "Quantity.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 40);
            this.label3.TabIndex = 58;
            this.label3.Text = "Name.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 40);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID.:";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Blue;
            this.btndelete.Location = new System.Drawing.Point(28, 219);
            this.btndelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(212, 83);
            this.btndelete.TabIndex = 51;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Location = new System.Drawing.Point(28, 326);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(212, 83);
            this.btnupdate.TabIndex = 52;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(28, 103);
            this.btnsave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(212, 83);
            this.btnsave.TabIndex = 50;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Blue;
            this.btnclose.Location = new System.Drawing.Point(28, 431);
            this.btnclose.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(212, 83);
            this.btnclose.TabIndex = 53;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Location = new System.Drawing.Point(1666, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 622);
            this.panel2.TabIndex = 56;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(28, 7);
            this.btnnew.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(212, 83);
            this.btnnew.TabIndex = 56;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Blue;
            this.btnview.Location = new System.Drawing.Point(28, 526);
            this.btnview.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(212, 83);
            this.btnview.TabIndex = 55;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(26, 799);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1909, 341);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1909, 149);
            this.panel3.TabIndex = 74;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(777, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 63);
            this.label1.TabIndex = 56;
            this.label1.Text = "Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1972, 1191);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_AddProduct";
            this.Text = "Frm_AddProduct";
            this.Load += new System.EventHandler(this.Frm_AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcmpanynm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtotalcost;
        private System.Windows.Forms.TextBox txtperunitrate;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}