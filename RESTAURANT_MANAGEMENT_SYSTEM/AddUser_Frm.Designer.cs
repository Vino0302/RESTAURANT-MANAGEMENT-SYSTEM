namespace RESTAURANT_MANAGEMENT_SYSTEM
{
    partial class AddUser_Frm
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
            this.lbl_AddUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resturant_m_SystemDataSet = new RESTAURANT_MANAGEMENT_SYSTEM.Resturant_m_SystemDataSet();
            this.createAccTableAdapter = new RESTAURANT_MANAGEMENT_SYSTEM.Resturant_m_SystemDataSetTableAdapters.CreateAccTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nicMsg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Exit_btn = new MetroFramework.Controls.MetroButton();
            this.clear_btn = new MetroFramework.Controls.MetroButton();
            this.delete_btn = new MetroFramework.Controls.MetroButton();
            this.button_view = new MetroFramework.Controls.MetroButton();
            this.update_btn = new MetroFramework.Controls.MetroButton();
            this.add_btn = new MetroFramework.Controls.MetroButton();
            this.ComboBox_Position = new MetroFramework.Controls.MetroComboBox();
            this.ComboBox_gender = new MetroFramework.Controls.MetroComboBox();
            this.DateTime_JoinedDate = new MetroFramework.Controls.MetroDateTime();
            this.bday_datetimepicker = new MetroFramework.Controls.MetroDateTime();
            this.textBox_NIC = new System.Windows.Forms.TextBox();
            this.textBox_staffId = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_conPw = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_ConPw = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant_m_SystemDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AddUser
            // 
            this.lbl_AddUser.AutoSize = true;
            this.lbl_AddUser.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddUser.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_AddUser.Location = new System.Drawing.Point(377, 42);
            this.lbl_AddUser.Name = "lbl_AddUser";
            this.lbl_AddUser.Size = new System.Drawing.Size(262, 37);
            this.lbl_AddUser.TabIndex = 1;
            this.lbl_AddUser.Text = "Create Account..!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(500, 1004);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ARCEDIA";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(390, 663);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(458, 1041);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restaurant Manegement System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Blackadder ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(496, 1079);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "___7-3Code___";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 684);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 308);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // createAccBindingSource
            // 
            this.createAccBindingSource.DataMember = "CreateAcc";
            this.createAccBindingSource.DataSource = this.resturant_m_SystemDataSet;
            // 
            // resturant_m_SystemDataSet
            // 
            this.resturant_m_SystemDataSet.DataSetName = "Resturant_m_SystemDataSet";
            this.resturant_m_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createAccTableAdapter
            // 
            this.createAccTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::RESTAURANT_MANAGEMENT_SYSTEM.Properties.Resources.silhouette_plate_tableware;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lbl_nicMsg);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Exit_btn);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.button_view);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.ComboBox_Position);
            this.groupBox1.Controls.Add(this.ComboBox_gender);
            this.groupBox1.Controls.Add(this.DateTime_JoinedDate);
            this.groupBox1.Controls.Add(this.bday_datetimepicker);
            this.groupBox1.Controls.Add(this.textBox_NIC);
            this.groupBox1.Controls.Add(this.textBox_staffId);
            this.groupBox1.Controls.Add(this.textBox_contact);
            this.groupBox1.Controls.Add(this.textBox_conPw);
            this.groupBox1.Controls.Add(this.textBox_pw);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.txtboxFirstName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label_ConPw);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_Email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(42, 98);
            this.groupBox1.MaximumSize = new System.Drawing.Size(995, 562);
            this.groupBox1.MinimumSize = new System.Drawing.Size(995, 562);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 562);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbl_nicMsg
            // 
            this.lbl_nicMsg.AutoSize = true;
            this.lbl_nicMsg.BackColor = System.Drawing.Color.Black;
            this.lbl_nicMsg.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nicMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_nicMsg.Location = new System.Drawing.Point(106, 303);
            this.lbl_nicMsg.Name = "lbl_nicMsg";
            this.lbl_nicMsg.Size = new System.Drawing.Size(0, 24);
            this.lbl_nicMsg.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label_Search);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Location = new System.Drawing.Point(270, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 57);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSearch.BackgroundImage = global::RESTAURANT_MANAGEMENT_SYSTEM.Properties.Resources.icons8_search_50;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(352, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.BackColor = System.Drawing.Color.Black;
            this.label_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.ForeColor = System.Drawing.Color.White;
            this.label_Search.Location = new System.Drawing.Point(38, 18);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(68, 23);
            this.label_Search.TabIndex = 13;
            this.label_Search.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(114, 18);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(313, 30);
            this.textBoxSearch.TabIndex = 19;
            // 
            // Exit_btn
            // 
            this.Exit_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Exit_btn.Location = new System.Drawing.Point(837, 399);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 39);
            this.Exit_btn.TabIndex = 17;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Exit_btn.UseSelectable = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clear_btn.Location = new System.Drawing.Point(690, 399);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(100, 39);
            this.clear_btn.TabIndex = 16;
            this.clear_btn.Text = "Clear";
            this.clear_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.clear_btn.UseSelectable = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.delete_btn.Location = new System.Drawing.Point(530, 399);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(103, 39);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.delete_btn.UseSelectable = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // button_view
            // 
            this.button_view.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.button_view.Location = new System.Drawing.Point(246, 399);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(98, 39);
            this.button_view.TabIndex = 13;
            this.button_view.Text = "View";
            this.button_view.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_view.UseSelectable = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // update_btn
            // 
            this.update_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.update_btn.Location = new System.Drawing.Point(384, 399);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(98, 39);
            this.update_btn.TabIndex = 14;
            this.update_btn.Text = "Update";
            this.update_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.update_btn.UseSelectable = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.add_btn.Location = new System.Drawing.Point(108, 399);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 39);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Add";
            this.add_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.add_btn.UseSelectable = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // ComboBox_Position
            // 
            this.ComboBox_Position.FormattingEnabled = true;
            this.ComboBox_Position.ItemHeight = 24;
            this.ComboBox_Position.Items.AddRange(new object[] {
            "Manager",
            "Waiter",
            "Cashier"});
            this.ComboBox_Position.Location = new System.Drawing.Point(690, 32);
            this.ComboBox_Position.Name = "ComboBox_Position";
            this.ComboBox_Position.Size = new System.Drawing.Size(223, 30);
            this.ComboBox_Position.TabIndex = 6;
            this.ComboBox_Position.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComboBox_Position.UseSelectable = true;
            this.ComboBox_Position.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Position_SelectedIndexChanged_1);
            // 
            // ComboBox_gender
            // 
            this.ComboBox_gender.FormattingEnabled = true;
            this.ComboBox_gender.ItemHeight = 24;
            this.ComboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Rather not say"});
            this.ComboBox_gender.Location = new System.Drawing.Point(246, 336);
            this.ComboBox_gender.Name = "ComboBox_gender";
            this.ComboBox_gender.Size = new System.Drawing.Size(223, 30);
            this.ComboBox_gender.TabIndex = 5;
            this.ComboBox_gender.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComboBox_gender.UseSelectable = true;
            // 
            // DateTime_JoinedDate
            // 
            this.DateTime_JoinedDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.DateTime_JoinedDate.Location = new System.Drawing.Point(690, 341);
            this.DateTime_JoinedDate.MinimumSize = new System.Drawing.Size(0, 27);
            this.DateTime_JoinedDate.Name = "DateTime_JoinedDate";
            this.DateTime_JoinedDate.Size = new System.Drawing.Size(223, 27);
            this.DateTime_JoinedDate.TabIndex = 11;
            this.DateTime_JoinedDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // bday_datetimepicker
            // 
            this.bday_datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bday_datetimepicker.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.bday_datetimepicker.Location = new System.Drawing.Point(246, 203);
            this.bday_datetimepicker.Margin = new System.Windows.Forms.Padding(1);
            this.bday_datetimepicker.MinimumSize = new System.Drawing.Size(0, 27);
            this.bday_datetimepicker.Name = "bday_datetimepicker";
            this.bday_datetimepicker.Size = new System.Drawing.Size(223, 27);
            this.bday_datetimepicker.TabIndex = 3;
            this.bday_datetimepicker.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox_NIC
            // 
            this.textBox_NIC.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_NIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_NIC.Location = new System.Drawing.Point(246, 270);
            this.textBox_NIC.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_NIC.Name = "textBox_NIC";
            this.textBox_NIC.Size = new System.Drawing.Size(223, 30);
            this.textBox_NIC.TabIndex = 4;
            this.textBox_NIC.TextChanged += new System.EventHandler(this.textBox_NIC_TextChanged);
            // 
            // textBox_staffId
            // 
            this.textBox_staffId.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_staffId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_staffId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_staffId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_staffId.Location = new System.Drawing.Point(689, 85);
            this.textBox_staffId.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_staffId.Name = "textBox_staffId";
            this.textBox_staffId.Size = new System.Drawing.Size(223, 30);
            this.textBox_staffId.TabIndex = 7;
            // 
            // textBox_contact
            // 
            this.textBox_contact.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_contact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_contact.Location = new System.Drawing.Point(690, 141);
            this.textBox_contact.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(223, 30);
            this.textBox_contact.TabIndex = 8;
            // 
            // textBox_conPw
            // 
            this.textBox_conPw.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_conPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_conPw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_conPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_conPw.Location = new System.Drawing.Point(690, 262);
            this.textBox_conPw.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_conPw.Name = "textBox_conPw";
            this.textBox_conPw.PasswordChar = '*';
            this.textBox_conPw.Size = new System.Drawing.Size(223, 30);
            this.textBox_conPw.TabIndex = 10;
            // 
            // textBox_pw
            // 
            this.textBox_pw.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_pw.Location = new System.Drawing.Point(689, 198);
            this.textBox_pw.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(223, 30);
            this.textBox_pw.TabIndex = 9;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Email.Location = new System.Drawing.Point(246, 141);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(223, 30);
            this.textBox_Email.TabIndex = 2;
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_lastname.Location = new System.Drawing.Point(246, 85);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(0);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(223, 30);
            this.txt_lastname.TabIndex = 1;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtboxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxFirstName.Location = new System.Drawing.Point(246, 31);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(223, 30);
            this.txtboxFirstName.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(572, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(104, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(572, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Contact";
            // 
            // label_ConPw
            // 
            this.label_ConPw.AutoSize = true;
            this.label_ConPw.BackColor = System.Drawing.Color.Black;
            this.label_ConPw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConPw.ForeColor = System.Drawing.Color.White;
            this.label_ConPw.Location = new System.Drawing.Point(572, 254);
            this.label_ConPw.Name = "label_ConPw";
            this.label_ConPw.Size = new System.Drawing.Size(90, 46);
            this.label_ConPw.TabIndex = 17;
            this.label_ConPw.Text = "Confirm \r\nPassword";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(572, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(572, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Staff Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(559, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Joined Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(104, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(104, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birth Date";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.Black;
            this.label_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Email.Location = new System.Drawing.Point(104, 141);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(58, 23);
            this.label_Email.TabIndex = 11;
            this.label_Email.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(105, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(104, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // AddUser_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 1102);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AddUser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 1102);
            this.MinimumSize = new System.Drawing.Size(1080, 1028);
            this.Name = "AddUser_Frm";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddUser_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturant_m_SystemDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_AddUser;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Resturant_m_SystemDataSet resturant_m_SystemDataSet;
        private System.Windows.Forms.BindingSource createAccBindingSource;
        private Resturant_m_SystemDataSetTableAdapters.CreateAccTableAdapter createAccTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton Exit_btn;
        private MetroFramework.Controls.MetroButton clear_btn;
        private MetroFramework.Controls.MetroButton delete_btn;
        private MetroFramework.Controls.MetroButton button_view;
        private MetroFramework.Controls.MetroButton update_btn;
        private MetroFramework.Controls.MetroButton add_btn;
        private MetroFramework.Controls.MetroComboBox ComboBox_Position;
        private MetroFramework.Controls.MetroComboBox ComboBox_gender;
        private MetroFramework.Controls.MetroDateTime DateTime_JoinedDate;
        private MetroFramework.Controls.MetroDateTime bday_datetimepicker;
        private System.Windows.Forms.TextBox textBox_NIC;
        private System.Windows.Forms.TextBox textBox_staffId;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.TextBox textBox_conPw;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_ConPw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBoxSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.Label lbl_nicMsg;
    }
}