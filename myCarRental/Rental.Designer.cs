namespace myCarRental
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mycusid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.myphonenumber = new MetroFramework.Controls.MetroTextBox();
            this.mylastname = new MetroFramework.Controls.MetroTextBox();
            this.myfirstname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.rENTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTALTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.RENTALTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.rENTALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.model = new MetroFramework.Controls.MetroComboBox();
            this.pickupcity = new MetroFramework.Controls.MetroComboBox();
            this.pickuplocation = new MetroFramework.Controls.MetroComboBox();
            this.dropofflocation = new MetroFramework.Controls.MetroComboBox();
            this.dropoffcity = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.regnum = new MetroFramework.Controls.MetroComboBox();
            this.carprice = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer ID";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
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
            this.mycusid.Location = new System.Drawing.Point(176, 75);
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
            this.mycusid.TabIndex = 1;
            this.mycusid.UseCustomBackColor = true;
            this.mycusid.UseSelectable = true;
            this.mycusid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mycusid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mycusid.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Firstname";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel3.Location = new System.Drawing.Point(23, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Lastname";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel4.Location = new System.Drawing.Point(23, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Phonenumber";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
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
            this.myphonenumber.Location = new System.Drawing.Point(176, 183);
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
            this.myphonenumber.TabIndex = 5;
            this.myphonenumber.UseCustomBackColor = true;
            this.myphonenumber.UseSelectable = true;
            this.myphonenumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.myphonenumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mylastname.Location = new System.Drawing.Point(176, 148);
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
            this.mylastname.TabIndex = 6;
            this.mylastname.UseCustomBackColor = true;
            this.mylastname.UseSelectable = true;
            this.mylastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mylastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.myfirstname.Location = new System.Drawing.Point(176, 109);
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
            this.myfirstname.TabIndex = 7;
            this.myfirstname.UseCustomBackColor = true;
            this.myfirstname.UseSelectable = true;
            this.myfirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.myfirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel5.Location = new System.Drawing.Point(22, 222);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Starting Date";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(24, 261);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Ending Date";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel7.Location = new System.Drawing.Point(24, 360);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Car Price(TL)";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel8.Location = new System.Drawing.Point(23, 328);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Registration Number";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel9.Location = new System.Drawing.Point(22, 301);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(47, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Model";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel10.Location = new System.Drawing.Point(24, 393);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Pick up City";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel11.Location = new System.Drawing.Point(23, 427);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(104, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Pick up Location";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel12.Location = new System.Drawing.Point(23, 457);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(85, 19);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "Drop off City";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel13.Location = new System.Drawing.Point(23, 491);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(112, 19);
            this.metroLabel13.TabIndex = 16;
            this.metroLabel13.Text = "Drop off Location";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            this.metroLabel13.UseStyleColors = true;
            // 
            // cARRENTALDataSet
            // 
            this.cARRENTALDataSet.DataSetName = "CARRENTALDataSet";
            this.cARRENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rENTALBindingSource
            // 
            this.rENTALBindingSource.DataMember = "RENTAL";
            this.rENTALBindingSource.DataSource = this.cARRENTALDataSet;
            // 
            // rENTALTableAdapter
            // 
            this.rENTALTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RENTALTableAdapter = this.rENTALTableAdapter;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VEHICLETableAdapter = null;
            // 
            // rENTALDataGridView
            // 
            this.rENTALDataGridView.AutoGenerateColumns = false;
            this.rENTALDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.rENTALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rENTALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rENTALDataGridView.DataSource = this.rENTALBindingSource;
            this.rENTALDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.rENTALDataGridView.Location = new System.Drawing.Point(367, 46);
            this.rENTALDataGridView.Name = "rENTALDataGridView";
            this.rENTALDataGridView.ReadOnly = true;
            this.rENTALDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rENTALDataGridView.Size = new System.Drawing.Size(597, 312);
            this.rENTALDataGridView.TabIndex = 18;
            this.rENTALDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rENTALDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RENTAL_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RENTAL_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STARTDATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "STARTDATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ENDDATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "ENDDATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CUS_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CUS_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "REG_NUM";
            this.dataGridViewTextBoxColumn5.HeaderText = "REG_NUM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PICUPLOC_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "PICUPLOC_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DROPOFFLOC_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "DROPOFFLOC_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(176, 222);
            this.startDate.MinDate = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(184, 29);
            this.startDate.TabIndex = 19;
            this.startDate.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(176, 257);
            this.endDate.MinDate = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(185, 29);
            this.endDate.TabIndex = 20;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.LightSlateGray;
            this.metroLink1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(6, 21);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(53, 34);
            this.metroLink1.TabIndex = 21;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.ItemHeight = 23;
            this.model.Location = new System.Drawing.Point(176, 292);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(184, 29);
            this.model.TabIndex = 24;
            this.model.UseSelectable = true;
            this.model.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroComboBox1_MouseClick);
            // 
            // pickupcity
            // 
            this.pickupcity.FormattingEnabled = true;
            this.pickupcity.ItemHeight = 23;
            this.pickupcity.Location = new System.Drawing.Point(160, 386);
            this.pickupcity.Name = "pickupcity";
            this.pickupcity.Size = new System.Drawing.Size(200, 29);
            this.pickupcity.TabIndex = 25;
            this.pickupcity.UseCustomBackColor = true;
            this.pickupcity.UseCustomForeColor = true;
            this.pickupcity.UseSelectable = true;
            this.pickupcity.UseStyleColors = true;
            this.pickupcity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pickupcity_MouseClick);
            // 
            // pickuplocation
            // 
            this.pickuplocation.FormattingEnabled = true;
            this.pickuplocation.ItemHeight = 23;
            this.pickuplocation.Location = new System.Drawing.Point(160, 418);
            this.pickuplocation.Name = "pickuplocation";
            this.pickuplocation.Size = new System.Drawing.Size(200, 29);
            this.pickuplocation.TabIndex = 26;
            this.pickuplocation.UseCustomBackColor = true;
            this.pickuplocation.UseCustomForeColor = true;
            this.pickuplocation.UseSelectable = true;
            this.pickuplocation.UseStyleColors = true;
            this.pickuplocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pickuplocation_MouseClick);
            // 
            // dropofflocation
            // 
            this.dropofflocation.FormattingEnabled = true;
            this.dropofflocation.ItemHeight = 23;
            this.dropofflocation.Location = new System.Drawing.Point(160, 490);
            this.dropofflocation.Name = "dropofflocation";
            this.dropofflocation.Size = new System.Drawing.Size(200, 29);
            this.dropofflocation.TabIndex = 27;
            this.dropofflocation.UseCustomBackColor = true;
            this.dropofflocation.UseCustomForeColor = true;
            this.dropofflocation.UseSelectable = true;
            this.dropofflocation.UseStyleColors = true;
            this.dropofflocation.SelectedIndexChanged += new System.EventHandler(this.metroComboBox4_SelectedIndexChanged);
            this.dropofflocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dropofflocation_MouseClick);
            // 
            // dropoffcity
            // 
            this.dropoffcity.FormattingEnabled = true;
            this.dropoffcity.ItemHeight = 23;
            this.dropoffcity.Location = new System.Drawing.Point(160, 452);
            this.dropoffcity.Name = "dropoffcity";
            this.dropoffcity.Size = new System.Drawing.Size(200, 29);
            this.dropoffcity.TabIndex = 28;
            this.dropoffcity.UseCustomBackColor = true;
            this.dropoffcity.UseCustomForeColor = true;
            this.dropoffcity.UseSelectable = true;
            this.dropoffcity.UseStyleColors = true;
            this.dropoffcity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dropoffcity_MouseClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroTile1.Location = new System.Drawing.Point(522, 363);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(211, 150);
            this.metroTile1.TabIndex = 29;
            this.metroTile1.Text = "Rent car";
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
            // regnum
            // 
            this.regnum.FormattingEnabled = true;
            this.regnum.ItemHeight = 23;
            this.regnum.Location = new System.Drawing.Point(161, 324);
            this.regnum.Name = "regnum";
            this.regnum.Size = new System.Drawing.Size(200, 29);
            this.regnum.TabIndex = 30;
            this.regnum.UseCustomBackColor = true;
            this.regnum.UseCustomForeColor = true;
            this.regnum.UseSelectable = true;
            this.regnum.UseStyleColors = true;
            this.regnum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regnum_MouseClick);
            // 
            // carprice
            // 
            this.carprice.FormattingEnabled = true;
            this.carprice.ItemHeight = 23;
            this.carprice.Location = new System.Drawing.Point(161, 355);
            this.carprice.Name = "carprice";
            this.carprice.Size = new System.Drawing.Size(200, 29);
            this.carprice.TabIndex = 31;
            this.carprice.UseCustomBackColor = true;
            this.carprice.UseCustomForeColor = true;
            this.carprice.UseSelectable = true;
            this.carprice.UseStyleColors = true;
            this.carprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroComboBox3_MouseClick);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 544);
            this.Controls.Add(this.carprice);
            this.Controls.Add(this.regnum);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.dropoffcity);
            this.Controls.Add(this.dropofflocation);
            this.Controls.Add(this.pickuplocation);
            this.Controls.Add(this.pickupcity);
            this.Controls.Add(this.model);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.rENTALDataGridView);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.myfirstname);
            this.Controls.Add(this.mylastname);
            this.Controls.Add(this.myphonenumber);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mycusid);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Rental";
            this.Text = "         Rent A Car";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Activated += new System.EventHandler(this.Rental_Activated);
            this.Load += new System.EventHandler(this.Rental_Load);
            this.Shown += new System.EventHandler(this.Rental_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mycusid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox myphonenumber;
        private MetroFramework.Controls.MetroTextBox mylastname;
        private MetroFramework.Controls.MetroTextBox myfirstname;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource rENTALBindingSource;
        private CARRENTALDataSetTableAdapters.RENTALTableAdapter rENTALTableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rENTALDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroComboBox model;
        private MetroFramework.Controls.MetroComboBox pickupcity;
        private MetroFramework.Controls.MetroComboBox pickuplocation;
        private MetroFramework.Controls.MetroComboBox dropofflocation;
        private MetroFramework.Controls.MetroComboBox dropoffcity;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox regnum;
        private MetroFramework.Controls.MetroComboBox carprice;
    }
}