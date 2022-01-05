namespace Login
{
    partial class Frm_NewMember
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.comboamountstatus = new System.Windows.Forms.ComboBox();
            this.combopersnaltrainer = new System.Windows.Forms.ComboBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.dtpdoend = new System.Windows.Forms.DateTimePicker();
            this.dtpdojoin = new System.Windows.Forms.DateTimePicker();
            this.txtpeningamount = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtmailid = new System.Windows.Forms.TextBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txtmembernm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tblNewMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGymDataSet = new GYMApplication.DataGymDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_NewMemberTableAdapter = new GYMApplication.DataGymDataSetTableAdapters.tbl_NewMemberTableAdapter();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.txtplane = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNewMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGymDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Location = new System.Drawing.Point(2191, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 645);
            this.panel2.TabIndex = 91;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(33, 27);
            this.btnnew.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(212, 83);
            this.btnnew.TabIndex = 55;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Black;
            this.btnview.Location = new System.Drawing.Point(33, 451);
            this.btnview.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(212, 83);
            this.btnview.TabIndex = 54;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click_1);
            this.btnview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnview_KeyDown);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(33, 239);
            this.btndelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(212, 83);
            this.btndelete.TabIndex = 51;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btndelete_KeyDown);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(33, 547);
            this.btnclose.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(212, 83);
            this.btnclose.TabIndex = 53;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnclose_KeyDown);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(33, 123);
            this.btnsave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(212, 83);
            this.btnsave.TabIndex = 50;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsave_KeyDown);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(33, 346);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(212, 83);
            this.btnupdate.TabIndex = 52;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            this.btnupdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnupdate_KeyDown);
            // 
            // comboamountstatus
            // 
            this.comboamountstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboamountstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboamountstatus.FormattingEnabled = true;
            this.comboamountstatus.Items.AddRange(new object[] {
            "Paid",
            "Balance",
            "Cheak"});
            this.comboamountstatus.Location = new System.Drawing.Point(1752, 299);
            this.comboamountstatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboamountstatus.Name = "comboamountstatus";
            this.comboamountstatus.Size = new System.Drawing.Size(401, 43);
            this.comboamountstatus.TabIndex = 90;
            this.comboamountstatus.SelectedIndexChanged += new System.EventHandler(this.comboamountstatus_SelectedIndexChanged);
            this.comboamountstatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboamountstatus_KeyDown);
            // 
            // combopersnaltrainer
            // 
            this.combopersnaltrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combopersnaltrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combopersnaltrainer.FormattingEnabled = true;
            this.combopersnaltrainer.Items.AddRange(new object[] {
            "Pawar",
            "Kadam",
            "Yadav",
            "Jadhav",
            "Mulla",
            "Kambale",
            "Shinde",
            "More",
            "Deshmukh",
            "Ghorpade"});
            this.combopersnaltrainer.Location = new System.Drawing.Point(1001, 642);
            this.combopersnaltrainer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combopersnaltrainer.Name = "combopersnaltrainer";
            this.combopersnaltrainer.Size = new System.Drawing.Size(401, 43);
            this.combopersnaltrainer.TabIndex = 89;
            this.combopersnaltrainer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combopersnaltrainer_KeyDown);
            // 
            // combogender
            // 
            this.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combogender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(292, 642);
            this.combogender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(401, 43);
            this.combogender.TabIndex = 88;
            this.combogender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combogender_KeyDown);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(292, 390);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(401, 42);
            this.txtaddress.TabIndex = 87;
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyDown);
            // 
            // txtdob
            // 
            this.txtdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.Location = new System.Drawing.Point(1001, 221);
            this.txtdob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(401, 42);
            this.txtdob.TabIndex = 86;
            this.txtdob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdob_KeyDown);
            // 
            // dtpdoend
            // 
            this.dtpdoend.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdoend.CustomFormat = "dd/mm/yyyy";
            this.dtpdoend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdoend.Location = new System.Drawing.Point(1001, 549);
            this.dtpdoend.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpdoend.Name = "dtpdoend";
            this.dtpdoend.Size = new System.Drawing.Size(401, 35);
            this.dtpdoend.TabIndex = 85;
            this.dtpdoend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpdoend_KeyDown);
            // 
            // dtpdojoin
            // 
            this.dtpdojoin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdojoin.CustomFormat = "dd/mm/yyyy";
            this.dtpdojoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdojoin.Location = new System.Drawing.Point(1001, 466);
            this.dtpdojoin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpdojoin.Name = "dtpdojoin";
            this.dtpdojoin.Size = new System.Drawing.Size(401, 35);
            this.dtpdojoin.TabIndex = 84;
            this.dtpdojoin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpdojoin_KeyDown);
            // 
            // txtpeningamount
            // 
            this.txtpeningamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeningamount.Location = new System.Drawing.Point(1752, 384);
            this.txtpeningamount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpeningamount.Name = "txtpeningamount";
            this.txtpeningamount.Size = new System.Drawing.Size(401, 42);
            this.txtpeningamount.TabIndex = 83;
            this.txtpeningamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpeningamount_KeyDown);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(1001, 303);
            this.txtage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(401, 42);
            this.txtage.TabIndex = 82;
            this.txtage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtage_KeyDown);
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.Location = new System.Drawing.Point(1752, 549);
            this.txtweight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(401, 42);
            this.txtweight.TabIndex = 81;
            this.txtweight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtweight_KeyDown);
            // 
            // txtheight
            // 
            this.txtheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheight.Location = new System.Drawing.Point(1752, 453);
            this.txtheight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(401, 42);
            this.txtheight.TabIndex = 80;
            this.txtheight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtheight_KeyDown);
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(1752, 228);
            this.txtamount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(401, 42);
            this.txtamount.TabIndex = 79;
            this.txtamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtamount_KeyDown);
            // 
            // txtmailid
            // 
            this.txtmailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmailid.Location = new System.Drawing.Point(292, 549);
            this.txtmailid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmailid.Name = "txtmailid";
            this.txtmailid.Size = new System.Drawing.Size(401, 42);
            this.txtmailid.TabIndex = 78;
            this.txtmailid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmailid_KeyDown);
            // 
            // txtcontactno
            // 
            this.txtcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno.Location = new System.Drawing.Point(292, 460);
            this.txtcontactno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(401, 42);
            this.txtcontactno.TabIndex = 77;
            this.txtcontactno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontactno_KeyDown);
            // 
            // txtmembernm
            // 
            this.txtmembernm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmembernm.Location = new System.Drawing.Point(292, 310);
            this.txtmembernm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmembernm.Name = "txtmembernm";
            this.txtmembernm.Size = new System.Drawing.Size(401, 42);
            this.txtmembernm.TabIndex = 76;
            this.txtmembernm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmembernm_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1470, 555);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 35);
            this.label16.TabIndex = 75;
            this.label16.Text = "Weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1470, 466);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 35);
            this.label15.TabIndex = 74;
            this.label15.Text = "Height";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1470, 397);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(242, 35);
            this.label14.TabIndex = 73;
            this.label14.Text = "Pending Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1470, 308);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 35);
            this.label13.TabIndex = 72;
            this.label13.Text = "Amount Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1470, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 35);
            this.label12.TabIndex = 71;
            this.label12.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(719, 649);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 35);
            this.label11.TabIndex = 70;
            this.label11.Text = "Personal Trainer";
            // 
            // tblNewMemberBindingSource
            // 
            this.tblNewMemberBindingSource.DataMember = "tbl_NewMember";
            this.tblNewMemberBindingSource.DataSource = this.dataGymDataSet;
            // 
            // dataGymDataSet
            // 
            this.dataGymDataSet.DataSetName = "DataGymDataSet";
            this.dataGymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(719, 555);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 35);
            this.label10.TabIndex = 67;
            this.label10.Text = "Date Of End";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(719, 466);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 35);
            this.label9.TabIndex = 66;
            this.label9.Text = "Date Of Joining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(719, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 35);
            this.label8.TabIndex = 65;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(719, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 35);
            this.label7.TabIndex = 64;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 660);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 35);
            this.label6.TabIndex = 63;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 562);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 35);
            this.label5.TabIndex = 62;
            this.label5.Text = "Mail ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 61;
            this.label4.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 60;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 35);
            this.label2.TabIndex = 59;
            this.label2.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 58;
            this.label1.Text = "Member ID";
            // 
            // tbl_NewMemberTableAdapter
            // 
            this.tbl_NewMemberTableAdapter.ClearBeforeFill = true;
            // 
            // txtmemberid
            // 
            this.txtmemberid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmemberid.Location = new System.Drawing.Point(292, 228);
            this.txtmemberid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtmemberid.Name = "txtmemberid";
            this.txtmemberid.ReadOnly = true;
            this.txtmemberid.Size = new System.Drawing.Size(401, 42);
            this.txtmemberid.TabIndex = 94;
            this.txtmemberid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmemberid_KeyDown);
            // 
            // txtplane
            // 
            this.txtplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplane.Location = new System.Drawing.Point(1001, 384);
            this.txtplane.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtplane.Name = "txtplane";
            this.txtplane.Size = new System.Drawing.Size(401, 42);
            this.txtplane.TabIndex = 96;
            this.txtplane.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtplane_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(719, 397);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 35);
            this.label17.TabIndex = 95;
            this.label17.Text = "Plane";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(37, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2424, 158);
            this.panel1.TabIndex = 98;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.OrangeRed;
            this.label18.Location = new System.Drawing.Point(1066, 40);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(357, 63);
            this.label18.TabIndex = 59;
            this.label18.Text = "New Member";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 852);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2424, 413);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Frm_NewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(2492, 1292);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtplane);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtmemberid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboamountstatus);
            this.Controls.Add(this.combopersnaltrainer);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.dtpdoend);
            this.Controls.Add(this.dtpdojoin);
            this.Controls.Add(this.txtpeningamount);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtmailid);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txtmembernm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
            this.Name = "Frm_NewMember";
            this.Text = "Frm_NewMember";
            this.Load += new System.EventHandler(this.Frm_NewMember_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblNewMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGymDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox comboamountstatus;
        private System.Windows.Forms.ComboBox combopersnaltrainer;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.DateTimePicker dtpdoend;
        private System.Windows.Forms.DateTimePicker dtpdojoin;
        private System.Windows.Forms.TextBox txtpeningamount;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtmailid;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txtmembernm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnview;
        private GYMApplication.DataGymDataSet dataGymDataSet;
        private System.Windows.Forms.BindingSource tblNewMemberBindingSource;
        private GYMApplication.DataGymDataSetTableAdapters.tbl_NewMemberTableAdapter tbl_NewMemberTableAdapter;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.TextBox txtplane;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnew;
    }
}