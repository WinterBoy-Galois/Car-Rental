namespace myCarRental
{
    partial class NewVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewVehicle));
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.mileage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.rentprice = new MetroFramework.Controls.MetroTextBox();
            this.production = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLETableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.VEHICLETableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.vEHICLEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save = new MetroFramework.Controls.MetroTile();
            this.category = new MetroFramework.Controls.MetroComboBox();
            this.brands = new MetroFramework.Controls.MetroComboBox();
            this.model = new MetroFramework.Controls.MetroComboBox();
            this.reg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(11, 24);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 7;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // mileage
            // 
            // 
            // 
            // 
            this.mileage.CustomButton.Image = null;
            this.mileage.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.mileage.CustomButton.Name = "";
            this.mileage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mileage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mileage.CustomButton.TabIndex = 1;
            this.mileage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mileage.CustomButton.UseSelectable = true;
            this.mileage.CustomButton.Visible = false;
            this.mileage.Lines = new string[0];
            this.mileage.Location = new System.Drawing.Point(204, 268);
            this.mileage.MaxLength = 32767;
            this.mileage.Name = "mileage";
            this.mileage.PasswordChar = '\0';
            this.mileage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mileage.SelectedText = "";
            this.mileage.SelectionLength = 0;
            this.mileage.SelectionStart = 0;
            this.mileage.ShortcutsEnabled = true;
            this.mileage.Size = new System.Drawing.Size(170, 23);
            this.mileage.TabIndex = 33;
            this.mileage.UseSelectable = true;
            this.mileage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mileage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel2.Location = new System.Drawing.Point(11, 269);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 22);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Mileage";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // rentprice
            // 
            // 
            // 
            // 
            this.rentprice.CustomButton.Image = null;
            this.rentprice.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.rentprice.CustomButton.Name = "";
            this.rentprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.rentprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rentprice.CustomButton.TabIndex = 1;
            this.rentprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rentprice.CustomButton.UseSelectable = true;
            this.rentprice.CustomButton.Visible = false;
            this.rentprice.Lines = new string[0];
            this.rentprice.Location = new System.Drawing.Point(204, 302);
            this.rentprice.MaxLength = 32767;
            this.rentprice.Name = "rentprice";
            this.rentprice.PasswordChar = '\0';
            this.rentprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rentprice.SelectedText = "";
            this.rentprice.SelectionLength = 0;
            this.rentprice.SelectionStart = 0;
            this.rentprice.ShortcutsEnabled = true;
            this.rentprice.Size = new System.Drawing.Size(170, 23);
            this.rentprice.TabIndex = 31;
            this.rentprice.UseSelectable = true;
            this.rentprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rentprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // production
            // 
            // 
            // 
            // 
            this.production.CustomButton.Image = null;
            this.production.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.production.CustomButton.Name = "";
            this.production.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.production.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.production.CustomButton.TabIndex = 1;
            this.production.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.production.CustomButton.UseSelectable = true;
            this.production.CustomButton.Visible = false;
            this.production.Lines = new string[0];
            this.production.Location = new System.Drawing.Point(204, 229);
            this.production.MaxLength = 32767;
            this.production.Name = "production";
            this.production.PasswordChar = '\0';
            this.production.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.production.SelectedText = "";
            this.production.SelectionLength = 0;
            this.production.SelectionStart = 0;
            this.production.ShortcutsEnabled = true;
            this.production.Size = new System.Drawing.Size(170, 23);
            this.production.TabIndex = 30;
            this.production.UseSelectable = true;
            this.production.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.production.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(11, 187);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 23);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Model";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel5.Location = new System.Drawing.Point(13, 147);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(102, 23);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Brand";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel4.Location = new System.Drawing.Point(13, 229);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 23);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Production Year";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel3.Location = new System.Drawing.Point(11, 302);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 22);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Rent Price";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(11, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 23);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Category";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cARRENTALDataSet
            // 
            this.cARRENTALDataSet.DataSetName = "CARRENTALDataSet";
            this.cARRENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.cARRENTALDataSet;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VEHICLETableAdapter = this.vEHICLETableAdapter;
            // 
            // vEHICLEDataGridView
            // 
            this.vEHICLEDataGridView.AutoGenerateColumns = false;
            this.vEHICLEDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.vEHICLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vEHICLEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vEHICLEDataGridView.DataSource = this.vEHICLEBindingSource;
            this.vEHICLEDataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.vEHICLEDataGridView.Location = new System.Drawing.Point(380, 106);
            this.vEHICLEDataGridView.Name = "vEHICLEDataGridView";
            this.vEHICLEDataGridView.ReadOnly = true;
            this.vEHICLEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vEHICLEDataGridView.Size = new System.Drawing.Size(555, 220);
            this.vEHICLEDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "REG_NUM";
            this.dataGridViewTextBoxColumn1.HeaderText = "REG_NUM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MILEAGE";
            this.dataGridViewTextBoxColumn2.HeaderText = "MILEAGE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PROD_YEAR";
            this.dataGridViewTextBoxColumn3.HeaderText = "PROD_YEAR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VEH_RENT_PRICE";
            this.dataGridViewTextBoxColumn4.HeaderText = "VEH_RENT_PRICE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MODEL_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "MODEL_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CAT_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CAT_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // save
            // 
            this.save.ActiveControl = null;
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save.Location = new System.Drawing.Point(380, 342);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(160, 106);
            this.save.TabIndex = 35;
            this.save.Text = "Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.save.TileImage = ((System.Drawing.Image)(resources.GetObject("save.TileImage")));
            this.save.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.save.UseCustomBackColor = true;
            this.save.UseCustomForeColor = true;
            this.save.UseSelectable = true;
            this.save.UseStyleColors = true;
            this.save.UseTileImage = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.ItemHeight = 23;
            this.category.Location = new System.Drawing.Point(204, 106);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(170, 29);
            this.category.TabIndex = 36;
            this.category.UseSelectable = true;
            this.category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.category_MouseClick);
            // 
            // brands
            // 
            this.brands.FormattingEnabled = true;
            this.brands.ItemHeight = 23;
            this.brands.Location = new System.Drawing.Point(204, 147);
            this.brands.Name = "brands";
            this.brands.Size = new System.Drawing.Size(170, 29);
            this.brands.TabIndex = 37;
            this.brands.UseSelectable = true;
            this.brands.MouseClick += new System.Windows.Forms.MouseEventHandler(this.brands_MouseClick);
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.ItemHeight = 23;
            this.model.Location = new System.Drawing.Point(204, 187);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(170, 29);
            this.model.TabIndex = 38;
            this.model.UseSelectable = true;
            this.model.MouseClick += new System.Windows.Forms.MouseEventHandler(this.model_MouseClick);
            // 
            // reg
            // 
            // 
            // 
            // 
            this.reg.CustomButton.Image = null;
            this.reg.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.reg.CustomButton.Name = "";
            this.reg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.reg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.reg.CustomButton.TabIndex = 1;
            this.reg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reg.CustomButton.UseSelectable = true;
            this.reg.CustomButton.Visible = false;
            this.reg.Lines = new string[0];
            this.reg.Location = new System.Drawing.Point(204, 77);
            this.reg.MaxLength = 32767;
            this.reg.Name = "reg";
            this.reg.PasswordChar = '\0';
            this.reg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reg.SelectedText = "";
            this.reg.SelectionLength = 0;
            this.reg.SelectionStart = 0;
            this.reg.ShortcutsEnabled = true;
            this.reg.Size = new System.Drawing.Size(170, 23);
            this.reg.TabIndex = 39;
            this.reg.UseSelectable = true;
            this.reg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.reg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel7.Location = new System.Drawing.Point(11, 77);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(148, 23);
            this.metroLabel7.TabIndex = 40;
            this.metroLabel7.Text = "Registration number";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // NewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 453);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brands);
            this.Controls.Add(this.category);
            this.Controls.Add(this.save);
            this.Controls.Add(this.vEHICLEDataGridView);
            this.Controls.Add(this.mileage);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.rentprice);
            this.Controls.Add(this.production);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lnkLogOut);
            this.Name = "NewVehicle";
            this.Text = "NewVehicle";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.NewVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private MetroFramework.Controls.MetroTextBox mileage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox rentprice;
        private MetroFramework.Controls.MetroTextBox production;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private CARRENTALDataSetTableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vEHICLEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroTile save;
        private MetroFramework.Controls.MetroComboBox category;
        private MetroFramework.Controls.MetroComboBox brands;
        private MetroFramework.Controls.MetroComboBox model;
        private MetroFramework.Controls.MetroTextBox reg;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}