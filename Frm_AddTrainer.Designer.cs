namespace Login
{
    partial class Frm_AddTrainer
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
            this.components = new System.ComponentModel.Container();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtaress = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.dtpdojoin = new System.Windows.Forms.DateTimePicker();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtsalery = new System.Windows.Forms.TextBox();
            this.txtmailid = new System.Windows.Forms.TextBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txttrainernm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tblAddTrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGymDataSet1 = new GYMApplication.DataGymDataSet1();
            this.txtrainerid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_AddTrainerTableAdapter = new GYMApplication.DataGymDataSet1TableAdapters.tbl_AddTrainerTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfJoiningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddTrainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGymDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(12, 187);
            this.btndelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(212, 83);
            this.btndelete.TabIndex = 51;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.View);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Location = new System.Drawing.Point(1407, 141);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 564);
            this.panel2.TabIndex = 104;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(12, 7);
            this.btnnew.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(212, 83);
            this.btnnew.TabIndex = 107;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.Black;
            this.View.Location = new System.Drawing.Point(12, 466);
            this.View.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(212, 83);
            this.View.TabIndex = 55;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(12, 370);
            this.btnclose.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(212, 83);
            this.btnclose.TabIndex = 53;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(12, 103);
            this.btnsave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(212, 83);
            this.btnsave.TabIndex = 50;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(12, 279);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(212, 83);
            this.btnupdate.TabIndex = 52;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // combogender
            // 
            this.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(287, 598);
            this.combogender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(345, 43);
            this.combogender.TabIndex = 103;
            this.combogender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combogender_KeyDown);
            // 
            // txtaress
            // 
            this.txtaress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaress.Location = new System.Drawing.Point(287, 330);
            this.txtaress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtaress.Name = "txtaress";
            this.txtaress.Size = new System.Drawing.Size(345, 42);
            this.txtaress.TabIndex = 102;
            this.txtaress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaress_KeyDown);
            // 
            // txtdob
            // 
            this.txtdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.Location = new System.Drawing.Point(992, 174);
            this.txtdob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(345, 42);
            this.txtdob.TabIndex = 101;
            this.txtdob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdob_KeyDown);
            // 
            // dtpdojoin
            // 
            this.dtpdojoin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdojoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdojoin.Location = new System.Drawing.Point(992, 330);
            this.dtpdojoin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpdojoin.Name = "dtpdojoin";
            this.dtpdojoin.Size = new System.Drawing.Size(345, 35);
            this.dtpdojoin.TabIndex = 100;
            this.dtpdojoin.Value = new System.DateTime(2017, 9, 13, 22, 3, 59, 0);
            this.dtpdojoin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpdojoin_KeyDown);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(992, 261);
            this.txtage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(345, 42);
            this.txtage.TabIndex = 99;
            this.txtage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtage_KeyDown);
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.Location = new System.Drawing.Point(992, 591);
            this.txtweight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(345, 42);
            this.txtweight.TabIndex = 98;
            this.txtweight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtweight_KeyDown);
            // 
            // txtheight
            // 
            this.txtheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheight.Location = new System.Drawing.Point(992, 495);
            this.txtheight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(345, 42);
            this.txtheight.TabIndex = 97;
            this.txtheight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtheight_KeyDown);
            // 
            // txtsalery
            // 
            this.txtsalery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalery.Location = new System.Drawing.Point(992, 415);
            this.txtsalery.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsalery.Name = "txtsalery";
            this.txtsalery.Size = new System.Drawing.Size(345, 42);
            this.txtsalery.TabIndex = 96;
            this.txtsalery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsalery_KeyDown);
            // 
            // txtmailid
            // 
            this.txtmailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmailid.Location = new System.Drawing.Point(287, 502);
            this.txtmailid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmailid.Name = "txtmailid";
            this.txtmailid.Size = new System.Drawing.Size(345, 42);
            this.txtmailid.TabIndex = 95;
            this.txtmailid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmailid_KeyDown);
            // 
            // txtcontactno
            // 
            this.txtcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno.Location = new System.Drawing.Point(287, 415);
            this.txtcontactno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(345, 42);
            this.txtcontactno.TabIndex = 94;
            this.txtcontactno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontactno_KeyDown);
            // 
            // txttrainernm
            // 
            this.txttrainernm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrainernm.Location = new System.Drawing.Point(287, 245);
            this.txttrainernm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txttrainernm.Name = "txttrainernm";
            this.txttrainernm.Size = new System.Drawing.Size(345, 42);
            this.txttrainernm.TabIndex = 93;
            this.txttrainernm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttrainernm_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(728, 605);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 35);
            this.label16.TabIndex = 92;
            this.label16.Text = "Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(728, 509);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 35);
            this.label15.TabIndex = 91;
            this.label15.Text = "Height";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(728, 428);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 35);
            this.label12.TabIndex = 90;
            this.label12.Text = "Salery";
            // 
            // tblAddTrainerBindingSource
            // 
            this.tblAddTrainerBindingSource.DataMember = "tbl_AddTrainer";
            this.tblAddTrainerBindingSource.DataSource = this.dataGymDataSet1;
            // 
            // dataGymDataSet1
            // 
            this.dataGymDataSet1.DataSetName = "DataGymDataSet1";
            this.dataGymDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtrainerid
            // 
            this.txtrainerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrainerid.Location = new System.Drawing.Point(287, 170);
            this.txtrainerid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtrainerid.Name = "txtrainerid";
            this.txtrainerid.ReadOnly = true;
            this.txtrainerid.Size = new System.Drawing.Size(345, 42);
            this.txtrainerid.TabIndex = 88;
            this.txtrainerid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrainerid_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(728, 337);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 35);
            this.label9.TabIndex = 87;
            this.label9.Text = "Date Of Joining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(728, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 35);
            this.label8.TabIndex = 86;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(728, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 35);
            this.label7.TabIndex = 85;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 605);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 35);
            this.label6.TabIndex = 84;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 509);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 35);
            this.label5.TabIndex = 83;
            this.label5.Text = "Mail ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 82;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 81;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 35);
            this.label2.TabIndex = 80;
            this.label2.Text = "Trainer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 79;
            this.label1.Text = "Trainer ID";
            // 
            // tbl_AddTrainerTableAdapter
            // 
            this.tbl_AddTrainerTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(595, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 55);
            this.label10.TabIndex = 105;
            this.label10.Text = "Add Trainer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainerIDDataGridViewTextBoxColumn,
            this.trainerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.mailIDDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.dateOfJoiningDataGridViewTextBoxColumn,
            this.saleryDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAddTrainerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 716);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1573, 402);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // trainerIDDataGridViewTextBoxColumn
            // 
            this.trainerIDDataGridViewTextBoxColumn.DataPropertyName = "Trainer_ID";
            this.trainerIDDataGridViewTextBoxColumn.HeaderText = "Trainer_ID";
            this.trainerIDDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.trainerIDDataGridViewTextBoxColumn.Name = "trainerIDDataGridViewTextBoxColumn";
            this.trainerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainerIDDataGridViewTextBoxColumn.Width = 225;
            // 
            // trainerNameDataGridViewTextBoxColumn
            // 
            this.trainerNameDataGridViewTextBoxColumn.DataPropertyName = "Trainer_Name";
            this.trainerNameDataGridViewTextBoxColumn.HeaderText = "Trainer_Name";
            this.trainerNameDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.trainerNameDataGridViewTextBoxColumn.Name = "trainerNameDataGridViewTextBoxColumn";
            this.trainerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainerNameDataGridViewTextBoxColumn.Width = 225;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 225;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNoDataGridViewTextBoxColumn.Width = 225;
            // 
            // mailIDDataGridViewTextBoxColumn
            // 
            this.mailIDDataGridViewTextBoxColumn.DataPropertyName = "Mail_ID";
            this.mailIDDataGridViewTextBoxColumn.HeaderText = "Mail_ID";
            this.mailIDDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.mailIDDataGridViewTextBoxColumn.Name = "mailIDDataGridViewTextBoxColumn";
            this.mailIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailIDDataGridViewTextBoxColumn.Width = 225;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 225;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 225;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 225;
            // 
            // dateOfJoiningDataGridViewTextBoxColumn
            // 
            this.dateOfJoiningDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Joining";
            this.dateOfJoiningDataGridViewTextBoxColumn.HeaderText = "Date_Of_Joining";
            this.dateOfJoiningDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.dateOfJoiningDataGridViewTextBoxColumn.Name = "dateOfJoiningDataGridViewTextBoxColumn";
            this.dateOfJoiningDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfJoiningDataGridViewTextBoxColumn.Width = 225;
            // 
            // saleryDataGridViewTextBoxColumn
            // 
            this.saleryDataGridViewTextBoxColumn.DataPropertyName = "Salery";
            this.saleryDataGridViewTextBoxColumn.HeaderText = "Salery";
            this.saleryDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.saleryDataGridViewTextBoxColumn.Name = "saleryDataGridViewTextBoxColumn";
            this.saleryDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleryDataGridViewTextBoxColumn.Width = 225;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Width = 225;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 225;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(65, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1573, 123);
            this.panel3.TabIndex = 107;
            // 
            // Frm_AddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1664, 1144);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.txtaress);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.dtpdojoin);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtsalery);
            this.Controls.Add(this.txtmailid);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txttrainernm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtrainerid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Frm_AddTrainer";
            this.Text = "Frm_AddTrainer";
            this.Load += new System.EventHandler(this.Frm_AddTrainer_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAddTrainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGymDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.TextBox txtaress;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.DateTimePicker dtpdojoin;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtsalery;
        private System.Windows.Forms.TextBox txtmailid;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txttrainernm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrainerid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GYMApplication.DataGymDataSet1 dataGymDataSet1;
        private System.Windows.Forms.BindingSource tblAddTrainerBindingSource;
        private GYMApplication.DataGymDataSet1TableAdapters.tbl_AddTrainerTableAdapter tbl_AddTrainerTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfJoiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel3;
    }
}