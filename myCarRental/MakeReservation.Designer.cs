namespace myCarRental
{
    partial class MakeReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeReservation));
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.myfirstname = new MetroFramework.Controls.MetroTextBox();
            this.mylastname = new MetroFramework.Controls.MetroTextBox();
            this.myphonenumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mycusid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dropoffcity = new MetroFramework.Controls.MetroComboBox();
            this.dropofflocation = new MetroFramework.Controls.MetroComboBox();
            this.pickuplocation = new MetroFramework.Controls.MetroComboBox();
            this.pickupcity = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.vehiclecategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.rESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESERVATIONTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.RESERVATIONTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.rESERVATIONDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(6, 16);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(66, 42);
            this.lnkLogOut.TabIndex = 8;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // myfirstname
            // 
            this.myfirstname.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.myfirstname.CustomButton.Image = null;
            this.myfirstname.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.myfirstname.CustomButton.Name = "";
            this.myfirstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.myfirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.myfirstname.CustomButton.TabIndex = 1;
            this.myfirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.myfirstname.CustomButton.UseSelectable = true;
            this.myfirstname.CustomButton.Visible = false;
            this.myfirstname.Lines = new string[0];
            this.myfirstname.Location = new System.Drawing.Point(159, 124);
            this.myfirstname.MaxLength = 32767;
            this.myfirstname.Name = "myfirstname";
            this.myfirstname.PasswordChar = '\0';
            this.myfirstname.ReadOnly = true;
            this.myfirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.myfirstname.SelectedText = "";
            this.myfirstname.SelectionLength = 0;
            this.myfirstname.SelectionStart = 0;
            this.myfirstname.ShortcutsEnabled = true;
            this.myfirstname.Size = new System.Drawing.Size(184, 23);
            this.myfirstname.TabIndex = 16;
            this.myfirstname.UseCustomBackColor = true;
            this.myfirstname.UseSelectable = true;
            this.myfirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.myfirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mylastname
            // 
            this.mylastname.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.mylastname.CustomButton.Image = null;
            this.mylastname.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.mylastname.CustomButton.Name = "";
            this.mylastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mylastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mylastname.CustomButton.TabIndex = 1;
            this.mylastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mylastname.CustomButton.UseSelectable = true;
            this.mylastname.CustomButton.Visible = false;
            this.mylastname.Lines = new string[0];
            this.mylastname.Location = new System.Drawing.Point(159, 163);
            this.mylastname.MaxLength = 32767;
            this.mylastname.Name = "mylastname";
            this.mylastname.PasswordChar = '\0';
            this.mylastname.ReadOnly = true;
            this.mylastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mylastname.SelectedText = "";
            this.mylastname.SelectionLength = 0;
            this.mylastname.SelectionStart = 0;
            this.mylastname.ShortcutsEnabled = true;
            this.mylastname.Size = new System.Drawing.Size(184, 23);
            this.mylastname.TabIndex = 15;
            this.mylastname.UseCustomBackColor = true;
            this.mylastname.UseSelectable = true;
            this.mylastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mylastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // myphonenumber
            // 
            this.myphonenumber.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.myphonenumber.CustomButton.Image = null;
            this.myphonenumber.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.myphonenumber.CustomButton.Name = "";
            this.myphonenumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.myphonenumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.myphonenumber.CustomButton.TabIndex = 1;
            this.myphonenumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.myphonenumber.CustomButton.UseSelectable = true;
            this.myphonenumber.CustomButton.Visible = false;
            this.myphonenumber.Lines = new string[0];
            this.myphonenumber.Location = new System.Drawing.Point(159, 198);
            this.myphonenumber.MaxLength = 32767;
            this.myphonenumber.Name = "myphonenumber";
            this.myphonenumber.PasswordChar = '\0';
            this.myphonenumber.ReadOnly = true;
            this.myphonenumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.myphonenumber.SelectedText = "";
            this.myphonenumber.SelectionLength = 0;
            this.myphonenumber.SelectionStart = 0;
            this.myphonenumber.ShortcutsEnabled = true;
            this.myphonenumber.Size = new System.Drawing.Size(184, 23);
            this.myphonenumber.TabIndex = 14;
            this.myphonenumber.UseCustomBackColor = true;
            this.myphonenumber.UseSelectable = true;
            this.myphonenumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.myphonenumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel4.Location = new System.Drawing.Point(6, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Phonenumber";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel3.Location = new System.Drawing.Point(6, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 12;
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
            this.metroLabel2.Location = new System.Drawing.Point(6, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Firstname";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // mycusid
            // 
            this.mycusid.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.mycusid.CustomButton.Image = null;
            this.mycusid.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.mycusid.CustomButton.Name = "";
            this.mycusid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mycusid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mycusid.CustomButton.TabIndex = 1;
            this.mycusid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mycusid.CustomButton.UseSelectable = true;
            this.mycusid.CustomButton.Visible = false;
            this.mycusid.Lines = new string[0];
            this.mycusid.Location = new System.Drawing.Point(159, 90);
            this.mycusid.MaxLength = 32767;
            this.mycusid.Name = "mycusid";
            this.mycusid.PasswordChar = '\0';
            this.mycusid.ReadOnly = true;
            this.mycusid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mycusid.SelectedText = "";
            this.mycusid.SelectionLength = 0;
            this.mycusid.SelectionStart = 0;
            this.mycusid.ShortcutsEnabled = true;
            this.mycusid.Size = new System.Drawing.Size(184, 23);
            this.mycusid.TabIndex = 10;
            this.mycusid.UseCustomBackColor = true;
            this.mycusid.UseSelectable = true;
            this.mycusid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mycusid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(6, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Customer ID";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // dropoffcity
            // 
            this.dropoffcity.FormattingEnabled = true;
            this.dropoffcity.ItemHeight = 23;
            this.dropoffcity.Location = new System.Drawing.Point(142, 293);
            this.dropoffcity.Name = "dropoffcity";
            this.dropoffcity.Size = new System.Drawing.Size(200, 29);
            this.dropoffcity.TabIndex = 36;
            this.dropoffcity.UseCustomBackColor = true;
            this.dropoffcity.UseCustomForeColor = true;
            this.dropoffcity.UseSelectable = true;
            this.dropoffcity.UseStyleColors = true;
            this.dropoffcity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dropoffcity_MouseClick);
            // 
            // dropofflocation
            // 
            this.dropofflocation.FormattingEnabled = true;
            this.dropofflocation.ItemHeight = 23;
            this.dropofflocation.Location = new System.Drawing.Point(142, 331);
            this.dropofflocation.Name = "dropofflocation";
            this.dropofflocation.Size = new System.Drawing.Size(200, 29);
            this.dropofflocation.TabIndex = 35;
            this.dropofflocation.UseCustomBackColor = true;
            this.dropofflocation.UseCustomForeColor = true;
            this.dropofflocation.UseSelectable = true;
            this.dropofflocation.UseStyleColors = true;
            this.dropofflocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dropofflocation_MouseClick);
            // 
            // pickuplocation
            // 
            this.pickuplocation.FormattingEnabled = true;
            this.pickuplocation.ItemHeight = 23;
            this.pickuplocation.Location = new System.Drawing.Point(142, 259);
            this.pickuplocation.Name = "pickuplocation";
            this.pickuplocation.Size = new System.Drawing.Size(200, 29);
            this.pickuplocation.TabIndex = 34;
            this.pickuplocation.UseCustomBackColor = true;
            this.pickuplocation.UseCustomForeColor = true;
            this.pickuplocation.UseSelectable = true;
            this.pickuplocation.UseStyleColors = true;
            this.pickuplocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pickuplocation_MouseClick);
            // 
            // pickupcity
            // 
            this.pickupcity.FormattingEnabled = true;
            this.pickupcity.ItemHeight = 23;
            this.pickupcity.Location = new System.Drawing.Point(142, 227);
            this.pickupcity.Name = "pickupcity";
            this.pickupcity.Size = new System.Drawing.Size(200, 29);
            this.pickupcity.TabIndex = 33;
            this.pickupcity.UseCustomBackColor = true;
            this.pickupcity.UseCustomForeColor = true;
            this.pickupcity.UseSelectable = true;
            this.pickupcity.UseStyleColors = true;
            this.pickupcity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pickupcity_MouseClick);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel13.Location = new System.Drawing.Point(5, 332);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(112, 19);
            this.metroLabel13.TabIndex = 32;
            this.metroLabel13.Text = "Drop off Location";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel12.Location = new System.Drawing.Point(5, 298);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(85, 19);
            this.metroLabel12.TabIndex = 31;
            this.metroLabel12.Text = "Drop off City";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel11.Location = new System.Drawing.Point(5, 268);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(104, 19);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Pick up Location";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel10.Location = new System.Drawing.Point(6, 234);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Pick up City";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(160, 408);
            this.endDate.MinDate = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(185, 29);
            this.endDate.TabIndex = 40;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(160, 373);
            this.startDate.MinDate = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(184, 29);
            this.startDate.TabIndex = 39;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(8, 412);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Ending Date";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel5.Location = new System.Drawing.Point(6, 373);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Starting Date";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // vehiclecategory
            // 
            this.vehiclecategory.FormattingEnabled = true;
            this.vehiclecategory.ItemHeight = 23;
            this.vehiclecategory.Location = new System.Drawing.Point(142, 443);
            this.vehiclecategory.Name = "vehiclecategory";
            this.vehiclecategory.Size = new System.Drawing.Size(200, 29);
            this.vehiclecategory.TabIndex = 42;
            this.vehiclecategory.UseCustomBackColor = true;
            this.vehiclecategory.UseCustomForeColor = true;
            this.vehiclecategory.UseSelectable = true;
            this.vehiclecategory.UseStyleColors = true;
            this.vehiclecategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vehiclecategory_MouseClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel7.Location = new System.Drawing.Point(6, 450);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(108, 19);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Vehicle Category";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // cARRENTALDataSet
            // 
            this.cARRENTALDataSet.DataSetName = "CARRENTALDataSet";
            this.cARRENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESERVATIONBindingSource
            // 
            this.rESERVATIONBindingSource.DataMember = "RESERVATION";
            this.rESERVATIONBindingSource.DataSource = this.cARRENTALDataSet;
            // 
            // rESERVATIONTableAdapter
            // 
            this.rESERVATIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BRANDTableAdapter = null;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.LOCATIONSTableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.RENTALTableAdapter = null;
            this.tableAdapterManager.RESERVATIONTableAdapter = this.rESERVATIONTableAdapter;
            this.tableAdapterManager.UpdateOrder = myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VEHICLETableAdapter = null;
            // 
            // rESERVATIONDataGridView
            // 
            this.rESERVATIONDataGridView.AutoGenerateColumns = false;
            this.rESERVATIONDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.rESERVATIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rESERVATIONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rESERVATIONDataGridView.DataSource = this.rESERVATIONBindingSource;
            this.rESERVATIONDataGridView.Location = new System.Drawing.Point(349, 92);
            this.rESERVATIONDataGridView.Name = "rESERVATIONDataGridView";
            this.rESERVATIONDataGridView.ReadOnly = true;
            this.rESERVATIONDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rESERVATIONDataGridView.Size = new System.Drawing.Size(596, 259);
            this.rESERVATIONDataGridView.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RES_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RES_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PICKUPLOC_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PICKUPLOC_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DRPOFFLOC_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "DRPOFFLOC_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CAT_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CAT_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CUS_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "CUS_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PICKUPDATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "PICKUPDATE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DROPOFFDATE";
            this.dataGridViewTextBoxColumn7.HeaderText = "DROPOFFDATE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Red;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroTile1.Location = new System.Drawing.Point(498, 357);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(211, 128);
            this.metroTile1.TabIndex = 44;
            this.metroTile1.Text = "Make Reservation";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 492);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.rESERVATIONDataGridView);
            this.Controls.Add(this.vehiclecategory);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dropoffcity);
            this.Controls.Add(this.dropofflocation);
            this.Controls.Add(this.pickuplocation);
            this.Controls.Add(this.pickupcity);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.myfirstname);
            this.Controls.Add(this.mylastname);
            this.Controls.Add(this.myphonenumber);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mycusid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lnkLogOut);
            this.Name = "MakeReservation";
            this.Text = "MakeReservation";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MakeReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private MetroFramework.Controls.MetroTextBox myfirstname;
        private MetroFramework.Controls.MetroTextBox mylastname;
        private MetroFramework.Controls.MetroTextBox myphonenumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mycusid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox dropoffcity;
        private MetroFramework.Controls.MetroComboBox dropofflocation;
        private MetroFramework.Controls.MetroComboBox pickuplocation;
        private MetroFramework.Controls.MetroComboBox pickupcity;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox vehiclecategory;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource rESERVATIONBindingSource;
        private CARRENTALDataSetTableAdapters.RESERVATIONTableAdapter rESERVATIONTableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rESERVATIONDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}