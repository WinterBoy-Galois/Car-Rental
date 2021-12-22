namespace myCarRental
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.Person = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.initial = new MetroFramework.Controls.MetroTextBox();
            this.lastname = new MetroFramework.Controls.MetroTextBox();
            this.firstname = new MetroFramework.Controls.MetroTextBox();
            this.cusid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.country = new MetroFramework.Controls.MetroTextBox();
            this.city = new MetroFramework.Controls.MetroTextBox();
            this.address = new MetroFramework.Controls.MetroTextBox();
            this.phonenumber = new MetroFramework.Controls.MetroTextBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.CUSTOMERSTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Searchbyphone = new MetroFramework.Controls.MetroTextBox();
            this.Person.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(32, 22);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(66, 28);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Person
            // 
            this.Person.Controls.Add(this.female);
            this.Person.Controls.Add(this.male);
            this.Person.Controls.Add(this.initial);
            this.Person.Controls.Add(this.lastname);
            this.Person.Controls.Add(this.firstname);
            this.Person.Controls.Add(this.cusid);
            this.Person.Controls.Add(this.metroLabel5);
            this.Person.Controls.Add(this.metroLabel4);
            this.Person.Controls.Add(this.metroLabel3);
            this.Person.Controls.Add(this.metroLabel2);
            this.Person.Controls.Add(this.metroLabel1);
            this.Person.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Person.Location = new System.Drawing.Point(23, 56);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(414, 213);
            this.Person.TabIndex = 1;
            this.Person.TabStop = false;
            this.Person.Text = "Person";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(268, 177);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(92, 25);
            this.female.TabIndex = 10;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(124, 177);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(72, 25);
            this.male.TabIndex = 9;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // initial
            // 
            // 
            // 
            // 
            this.initial.CustomButton.Image = null;
            this.initial.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.initial.CustomButton.Name = "";
            this.initial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.initial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.initial.CustomButton.TabIndex = 1;
            this.initial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.initial.CustomButton.UseSelectable = true;
            this.initial.CustomButton.Visible = false;
            this.initial.Lines = new string[0];
            this.initial.Location = new System.Drawing.Point(133, 146);
            this.initial.MaxLength = 32767;
            this.initial.Name = "initial";
            this.initial.PasswordChar = '\0';
            this.initial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.initial.SelectedText = "";
            this.initial.SelectionLength = 0;
            this.initial.SelectionStart = 0;
            this.initial.ShortcutsEnabled = true;
            this.initial.Size = new System.Drawing.Size(259, 23);
            this.initial.TabIndex = 8;
            this.initial.UseSelectable = true;
            this.initial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.initial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastname
            // 
            // 
            // 
            // 
            this.lastname.CustomButton.Image = null;
            this.lastname.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.lastname.CustomButton.Name = "";
            this.lastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastname.CustomButton.TabIndex = 1;
            this.lastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastname.CustomButton.UseSelectable = true;
            this.lastname.CustomButton.Visible = false;
            this.lastname.Lines = new string[0];
            this.lastname.Location = new System.Drawing.Point(133, 113);
            this.lastname.MaxLength = 32767;
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastname.SelectedText = "";
            this.lastname.SelectionLength = 0;
            this.lastname.SelectionStart = 0;
            this.lastname.ShortcutsEnabled = true;
            this.lastname.Size = new System.Drawing.Size(259, 23);
            this.lastname.TabIndex = 7;
            this.lastname.UseSelectable = true;
            this.lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstname
            // 
            // 
            // 
            // 
            this.firstname.CustomButton.Image = null;
            this.firstname.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.firstname.CustomButton.Name = "";
            this.firstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstname.CustomButton.TabIndex = 1;
            this.firstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstname.CustomButton.UseSelectable = true;
            this.firstname.CustomButton.Visible = false;
            this.firstname.Lines = new string[0];
            this.firstname.Location = new System.Drawing.Point(133, 81);
            this.firstname.MaxLength = 32767;
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstname.SelectedText = "";
            this.firstname.SelectionLength = 0;
            this.firstname.SelectionStart = 0;
            this.firstname.ShortcutsEnabled = true;
            this.firstname.Size = new System.Drawing.Size(259, 23);
            this.firstname.TabIndex = 6;
            this.firstname.UseSelectable = true;
            this.firstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cusid
            // 
            this.cusid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.cusid.CustomButton.Image = null;
            this.cusid.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.cusid.CustomButton.Name = "";
            this.cusid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cusid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cusid.CustomButton.TabIndex = 1;
            this.cusid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cusid.CustomButton.UseSelectable = true;
            this.cusid.CustomButton.Visible = false;
            this.cusid.Lines = new string[0];
            this.cusid.Location = new System.Drawing.Point(133, 40);
            this.cusid.MaxLength = 32767;
            this.cusid.Name = "cusid";
            this.cusid.PasswordChar = '\0';
            this.cusid.ReadOnly = true;
            this.cusid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cusid.SelectedText = "";
            this.cusid.SelectionLength = 0;
            this.cusid.SelectionStart = 0;
            this.cusid.ShortcutsEnabled = true;
            this.cusid.Size = new System.Drawing.Size(259, 23);
            this.cusid.TabIndex = 5;
            this.cusid.UseCustomBackColor = true;
            this.cusid.UseSelectable = true;
            this.cusid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cusid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel5.Location = new System.Drawing.Point(9, 146);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Initials";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel4.Location = new System.Drawing.Point(7, 179);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Gender";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel3.Location = new System.Drawing.Point(6, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Lastname";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel2.Location = new System.Drawing.Point(6, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Firstname";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(7, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer ID";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.country);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.phonenumber);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(462, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact";
            // 
            // country
            // 
            // 
            // 
            // 
            this.country.CustomButton.Image = null;
            this.country.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.country.CustomButton.Name = "";
            this.country.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.country.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.country.CustomButton.TabIndex = 1;
            this.country.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.country.CustomButton.UseSelectable = true;
            this.country.CustomButton.Visible = false;
            this.country.Lines = new string[0];
            this.country.Location = new System.Drawing.Point(142, 179);
            this.country.MaxLength = 32767;
            this.country.Name = "country";
            this.country.PasswordChar = '\0';
            this.country.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.country.SelectedText = "";
            this.country.SelectionLength = 0;
            this.country.SelectionStart = 0;
            this.country.ShortcutsEnabled = true;
            this.country.Size = new System.Drawing.Size(259, 23);
            this.country.TabIndex = 10;
            this.country.UseSelectable = true;
            this.country.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.country.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // city
            // 
            // 
            // 
            // 
            this.city.CustomButton.Image = null;
            this.city.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.city.CustomButton.Name = "";
            this.city.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.city.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.city.CustomButton.TabIndex = 1;
            this.city.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.city.CustomButton.UseSelectable = true;
            this.city.CustomButton.Visible = false;
            this.city.Lines = new string[0];
            this.city.Location = new System.Drawing.Point(142, 146);
            this.city.MaxLength = 32767;
            this.city.Name = "city";
            this.city.PasswordChar = '\0';
            this.city.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.city.SelectedText = "";
            this.city.SelectionLength = 0;
            this.city.SelectionStart = 0;
            this.city.ShortcutsEnabled = true;
            this.city.Size = new System.Drawing.Size(259, 23);
            this.city.TabIndex = 9;
            this.city.UseSelectable = true;
            this.city.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.city.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // address
            // 
            // 
            // 
            // 
            this.address.CustomButton.Image = null;
            this.address.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.address.CustomButton.Name = "";
            this.address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address.CustomButton.TabIndex = 1;
            this.address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address.CustomButton.UseSelectable = true;
            this.address.CustomButton.Visible = false;
            this.address.Lines = new string[0];
            this.address.Location = new System.Drawing.Point(142, 113);
            this.address.MaxLength = 32767;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address.SelectedText = "";
            this.address.SelectionLength = 0;
            this.address.SelectionStart = 0;
            this.address.ShortcutsEnabled = true;
            this.address.Size = new System.Drawing.Size(259, 23);
            this.address.TabIndex = 8;
            this.address.UseSelectable = true;
            this.address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phonenumber
            // 
            // 
            // 
            // 
            this.phonenumber.CustomButton.Image = null;
            this.phonenumber.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.phonenumber.CustomButton.Name = "";
            this.phonenumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phonenumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phonenumber.CustomButton.TabIndex = 1;
            this.phonenumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phonenumber.CustomButton.UseSelectable = true;
            this.phonenumber.CustomButton.Visible = false;
            this.phonenumber.Lines = new string[0];
            this.phonenumber.Location = new System.Drawing.Point(142, 81);
            this.phonenumber.MaxLength = 32767;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.PasswordChar = '\0';
            this.phonenumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phonenumber.SelectedText = "";
            this.phonenumber.SelectionLength = 0;
            this.phonenumber.SelectionStart = 0;
            this.phonenumber.ShortcutsEnabled = true;
            this.phonenumber.Size = new System.Drawing.Size(259, 23);
            this.phonenumber.TabIndex = 7;
            this.phonenumber.UseSelectable = true;
            this.phonenumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phonenumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(142, 44);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(259, 23);
            this.email.TabIndex = 6;
            this.email.UseSelectable = true;
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel10.Location = new System.Drawing.Point(23, 113);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(56, 19);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Address";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel9.Location = new System.Drawing.Point(23, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(92, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Phonenumber";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel8.Location = new System.Drawing.Point(23, 146);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(31, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "City";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel7.Location = new System.Drawing.Point(23, 183);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Country";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(23, 44);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Email";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // cARRENTALDataSet
            // 
            this.cARRENTALDataSet.DataSetName = "CARRENTALDataSet";
            this.cARRENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.cARRENTALDataSet;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BRANDTableAdapter = null;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = this.cUSTOMERSTableAdapter;
            this.tableAdapterManager.LOCATIONSTableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.RENTALTableAdapter = null;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VEHICLETableAdapter = null;
            // 
            // cUSTOMERSDataGridView
            // 
            this.cUSTOMERSDataGridView.AllowUserToDeleteRows = false;
            this.cUSTOMERSDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERSDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.cUSTOMERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.cUSTOMERSDataGridView.DataSource = this.cUSTOMERSBindingSource;
            this.cUSTOMERSDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.cUSTOMERSDataGridView.Location = new System.Drawing.Point(23, 314);
            this.cUSTOMERSDataGridView.Name = "cUSTOMERSDataGridView";
            this.cUSTOMERSDataGridView.ReadOnly = true;
            this.cUSTOMERSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cUSTOMERSDataGridView.Size = new System.Drawing.Size(852, 137);
            this.cUSTOMERSDataGridView.TabIndex = 4;
            this.cUSTOMERSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cUSTOMERSDataGridView_CellContentClick);
            this.cUSTOMERSDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cUSTOMERSDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CUS_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CUS_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CUS_FNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "CUS_FNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CUS_LNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "CUS_LNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CUS_INITIAL";
            this.dataGridViewTextBoxColumn4.HeaderText = "CUS_INITIAL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CUS_EMAIL";
            this.dataGridViewTextBoxColumn5.HeaderText = "CUS_EMAIL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CUS_CELL";
            this.dataGridViewTextBoxColumn6.HeaderText = "CUS_CELL";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CUS_ADDRESS";
            this.dataGridViewTextBoxColumn7.HeaderText = "CUS_ADDRESS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CUS_GENDER";
            this.dataGridViewTextBoxColumn8.HeaderText = "CUS_GENDER";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CUS_CITY";
            this.dataGridViewTextBoxColumn9.HeaderText = "CUS_CITY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CUS_COUNTRY";
            this.dataGridViewTextBoxColumn10.HeaderText = "CUS_COUNTRY";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(23, 457);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(214, 122);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Update";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel11.Location = new System.Drawing.Point(23, 282);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(153, 19);
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "Search By Phonenumber";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            this.metroLabel11.UseStyleColors = true;
            // 
            // Searchbyphone
            // 
            // 
            // 
            // 
            this.Searchbyphone.CustomButton.Image = null;
            this.Searchbyphone.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.Searchbyphone.CustomButton.Name = "";
            this.Searchbyphone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Searchbyphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Searchbyphone.CustomButton.TabIndex = 1;
            this.Searchbyphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Searchbyphone.CustomButton.UseSelectable = true;
            this.Searchbyphone.CustomButton.Visible = false;
            this.Searchbyphone.Lines = new string[0];
            this.Searchbyphone.Location = new System.Drawing.Point(178, 278);
            this.Searchbyphone.MaxLength = 32767;
            this.Searchbyphone.Name = "Searchbyphone";
            this.Searchbyphone.PasswordChar = '\0';
            this.Searchbyphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Searchbyphone.SelectedText = "";
            this.Searchbyphone.SelectionLength = 0;
            this.Searchbyphone.SelectionStart = 0;
            this.Searchbyphone.ShortcutsEnabled = true;
            this.Searchbyphone.Size = new System.Drawing.Size(259, 23);
            this.Searchbyphone.TabIndex = 7;
            this.Searchbyphone.UseSelectable = true;
            this.Searchbyphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Searchbyphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Searchbyphone.TextChanged += new System.EventHandler(this.Searchbyphone_TextChanged);
            this.Searchbyphone.Click += new System.EventHandler(this.metroTextBox10_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(895, 584);
            this.Controls.Add(this.Searchbyphone);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.cUSTOMERSDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.metroLink1);
            this.Name = "UpdateCustomer";
            this.Text = "           UpdateCustomer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            this.Person.ResumeLayout(false);
            this.Person.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.GroupBox Person;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.CheckBox male;
        private MetroFramework.Controls.MetroTextBox initial;
        private MetroFramework.Controls.MetroTextBox lastname;
        private MetroFramework.Controls.MetroTextBox firstname;
        private MetroFramework.Controls.MetroTextBox cusid;
        private MetroFramework.Controls.MetroTextBox country;
        private MetroFramework.Controls.MetroTextBox city;
        private MetroFramework.Controls.MetroTextBox address;
        private MetroFramework.Controls.MetroTextBox phonenumber;
        private MetroFramework.Controls.MetroTextBox email;
        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private CARRENTALDataSetTableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cUSTOMERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox Searchbyphone;
    }
}