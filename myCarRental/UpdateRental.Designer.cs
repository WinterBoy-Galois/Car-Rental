namespace myCarRental
{
    partial class UpdateRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRental));
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pickuplocation = new MetroFramework.Controls.MetroTextBox();
            this.dropofflocation = new MetroFramework.Controls.MetroTextBox();
            this.regnum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.customerid = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(13, 117);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 11;
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
            this.metroLabel5.Location = new System.Drawing.Point(11, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Starting Date";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(130, 114);
            this.endDate.MinDate = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(185, 29);
            this.endDate.TabIndex = 22;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(130, 79);
            this.startDate.MinDate = new System.DateTime(2017, 5, 18, 0, 0, 0, 0);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(184, 29);
            this.startDate.TabIndex = 21;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel13.Location = new System.Drawing.Point(11, 200);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(112, 19);
            this.metroLabel13.TabIndex = 32;
            this.metroLabel13.Text = "Drop off Location";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel11.Location = new System.Drawing.Point(11, 160);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(104, 19);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Pick up Location";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            this.metroLabel11.UseStyleColors = true;
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
            this.rENTALDataGridView.Location = new System.Drawing.Point(320, 79);
            this.rENTALDataGridView.Name = "rENTALDataGridView";
            this.rENTALDataGridView.ReadOnly = true;
            this.rENTALDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rENTALDataGridView.Size = new System.Drawing.Size(541, 221);
            this.rENTALDataGridView.TabIndex = 37;
            this.rENTALDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rENTALDataGridView_MouseDoubleClick);
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroTile1.Location = new System.Drawing.Point(387, 306);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(205, 145);
            this.metroTile1.TabIndex = 38;
            this.metroTile1.Text = "Update Rental";
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
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.LightSlateGray;
            this.metroLink1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(11, 22);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(53, 34);
            this.metroLink1.TabIndex = 39;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel8.Location = new System.Drawing.Point(11, 247);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 19);
            this.metroLabel8.TabIndex = 41;
            this.metroLabel8.Text = "Registration Number";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // pickuplocation
            // 
            // 
            // 
            // 
            this.pickuplocation.CustomButton.Image = null;
            this.pickuplocation.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.pickuplocation.CustomButton.Name = "";
            this.pickuplocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pickuplocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pickuplocation.CustomButton.TabIndex = 1;
            this.pickuplocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pickuplocation.CustomButton.UseSelectable = true;
            this.pickuplocation.CustomButton.Visible = false;
            this.pickuplocation.Lines = new string[0];
            this.pickuplocation.Location = new System.Drawing.Point(148, 156);
            this.pickuplocation.MaxLength = 32767;
            this.pickuplocation.Name = "pickuplocation";
            this.pickuplocation.PasswordChar = '\0';
            this.pickuplocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pickuplocation.SelectedText = "";
            this.pickuplocation.SelectionLength = 0;
            this.pickuplocation.SelectionStart = 0;
            this.pickuplocation.ShortcutsEnabled = true;
            this.pickuplocation.Size = new System.Drawing.Size(166, 23);
            this.pickuplocation.TabIndex = 42;
            this.pickuplocation.UseSelectable = true;
            this.pickuplocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pickuplocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dropofflocation
            // 
            // 
            // 
            // 
            this.dropofflocation.CustomButton.Image = null;
            this.dropofflocation.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.dropofflocation.CustomButton.Name = "";
            this.dropofflocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dropofflocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dropofflocation.CustomButton.TabIndex = 1;
            this.dropofflocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dropofflocation.CustomButton.UseSelectable = true;
            this.dropofflocation.CustomButton.Visible = false;
            this.dropofflocation.Lines = new string[0];
            this.dropofflocation.Location = new System.Drawing.Point(148, 196);
            this.dropofflocation.MaxLength = 32767;
            this.dropofflocation.Name = "dropofflocation";
            this.dropofflocation.PasswordChar = '\0';
            this.dropofflocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dropofflocation.SelectedText = "";
            this.dropofflocation.SelectionLength = 0;
            this.dropofflocation.SelectionStart = 0;
            this.dropofflocation.ShortcutsEnabled = true;
            this.dropofflocation.Size = new System.Drawing.Size(167, 23);
            this.dropofflocation.TabIndex = 43;
            this.dropofflocation.UseSelectable = true;
            this.dropofflocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropofflocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // regnum
            // 
            // 
            // 
            // 
            this.regnum.CustomButton.Image = null;
            this.regnum.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.regnum.CustomButton.Name = "";
            this.regnum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.regnum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.regnum.CustomButton.TabIndex = 1;
            this.regnum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regnum.CustomButton.UseSelectable = true;
            this.regnum.CustomButton.Visible = false;
            this.regnum.Lines = new string[0];
            this.regnum.Location = new System.Drawing.Point(148, 245);
            this.regnum.MaxLength = 32767;
            this.regnum.Name = "regnum";
            this.regnum.PasswordChar = '\0';
            this.regnum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.regnum.SelectedText = "";
            this.regnum.SelectionLength = 0;
            this.regnum.SelectionStart = 0;
            this.regnum.ShortcutsEnabled = true;
            this.regnum.Size = new System.Drawing.Size(167, 23);
            this.regnum.TabIndex = 44;
            this.regnum.UseSelectable = true;
            this.regnum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.regnum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(11, 290);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Customer ID";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // customerid
            // 
            // 
            // 
            // 
            this.customerid.CustomButton.Image = null;
            this.customerid.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.customerid.CustomButton.Name = "";
            this.customerid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customerid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customerid.CustomButton.TabIndex = 1;
            this.customerid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerid.CustomButton.UseSelectable = true;
            this.customerid.CustomButton.Visible = false;
            this.customerid.Lines = new string[0];
            this.customerid.Location = new System.Drawing.Point(148, 286);
            this.customerid.MaxLength = 32767;
            this.customerid.Name = "customerid";
            this.customerid.PasswordChar = '\0';
            this.customerid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerid.SelectedText = "";
            this.customerid.SelectionLength = 0;
            this.customerid.SelectionStart = 0;
            this.customerid.ShortcutsEnabled = true;
            this.customerid.Size = new System.Drawing.Size(167, 23);
            this.customerid.TabIndex = 46;
            this.customerid.UseSelectable = true;
            this.customerid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customerid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdateRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 472);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.regnum);
            this.Controls.Add(this.dropofflocation);
            this.Controls.Add(this.pickuplocation);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.rENTALDataGridView);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Name = "UpdateRental";
            this.Text = "       UpdateRental";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UpdateRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
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
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox pickuplocation;
        private MetroFramework.Controls.MetroTextBox dropofflocation;
        private MetroFramework.Controls.MetroTextBox regnum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox customerid;
    }
}