namespace myCarRental
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.categorydescription = new MetroFramework.Controls.MetroTextBox();
            this.categoryname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.categoryid = new MetroFramework.Controls.MetroTextBox();
            this.save = new MetroFramework.Controls.MetroTile();
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.CATEGORYTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.cATEGORYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(3, 16);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 16;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // categorydescription
            // 
            // 
            // 
            // 
            this.categorydescription.CustomButton.Image = null;
            this.categorydescription.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.categorydescription.CustomButton.Name = "";
            this.categorydescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.categorydescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categorydescription.CustomButton.TabIndex = 1;
            this.categorydescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categorydescription.CustomButton.UseSelectable = true;
            this.categorydescription.CustomButton.Visible = false;
            this.categorydescription.Lines = new string[0];
            this.categorydescription.Location = new System.Drawing.Point(196, 164);
            this.categorydescription.MaxLength = 32767;
            this.categorydescription.Name = "categorydescription";
            this.categorydescription.PasswordChar = '\0';
            this.categorydescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categorydescription.SelectedText = "";
            this.categorydescription.SelectionLength = 0;
            this.categorydescription.SelectionStart = 0;
            this.categorydescription.ShortcutsEnabled = true;
            this.categorydescription.Size = new System.Drawing.Size(221, 23);
            this.categorydescription.TabIndex = 22;
            this.categorydescription.UseSelectable = true;
            this.categorydescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categorydescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // categoryname
            // 
            // 
            // 
            // 
            this.categoryname.CustomButton.Image = null;
            this.categoryname.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.categoryname.CustomButton.Name = "";
            this.categoryname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.categoryname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categoryname.CustomButton.TabIndex = 1;
            this.categoryname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categoryname.CustomButton.UseSelectable = true;
            this.categoryname.CustomButton.Visible = false;
            this.categoryname.Lines = new string[0];
            this.categoryname.Location = new System.Drawing.Point(196, 124);
            this.categoryname.MaxLength = 32767;
            this.categoryname.Name = "categoryname";
            this.categoryname.PasswordChar = '\0';
            this.categoryname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categoryname.SelectedText = "";
            this.categoryname.SelectionLength = 0;
            this.categoryname.SelectionStart = 0;
            this.categoryname.ShortcutsEnabled = true;
            this.categoryname.Size = new System.Drawing.Size(221, 23);
            this.categoryname.TabIndex = 21;
            this.categoryname.UseSelectable = true;
            this.categoryname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel6.Location = new System.Drawing.Point(5, 164);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(159, 23);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Category Description";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel5.Location = new System.Drawing.Point(5, 124);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(131, 23);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Category Name";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(3, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 23);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Category ID";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // categoryid
            // 
            // 
            // 
            // 
            this.categoryid.CustomButton.Image = null;
            this.categoryid.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.categoryid.CustomButton.Name = "";
            this.categoryid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.categoryid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categoryid.CustomButton.TabIndex = 1;
            this.categoryid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categoryid.CustomButton.UseSelectable = true;
            this.categoryid.CustomButton.Visible = false;
            this.categoryid.Lines = new string[0];
            this.categoryid.Location = new System.Drawing.Point(196, 83);
            this.categoryid.MaxLength = 32767;
            this.categoryid.Name = "categoryid";
            this.categoryid.PasswordChar = '\0';
            this.categoryid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categoryid.SelectedText = "";
            this.categoryid.SelectionLength = 0;
            this.categoryid.SelectionStart = 0;
            this.categoryid.ShortcutsEnabled = true;
            this.categoryid.Size = new System.Drawing.Size(221, 23);
            this.categoryid.TabIndex = 17;
            this.categoryid.UseSelectable = true;
            this.categoryid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // save
            // 
            this.save.ActiveControl = null;
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save.Location = new System.Drawing.Point(5, 253);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(202, 130);
            this.save.TabIndex = 23;
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
            // cARRENTALDataSet
            // 
            this.cARRENTALDataSet.DataSetName = "CARRENTALDataSet";
            this.cARRENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.cARRENTALDataSet;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BRANDTableAdapter = null;
            this.tableAdapterManager.CATEGORYTableAdapter = this.cATEGORYTableAdapter;
            this.tableAdapterManager.CITYTableAdapter = null;
            this.tableAdapterManager.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager.LOCATIONSTableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.RENTALTableAdapter = null;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VEHICLETableAdapter = null;
            // 
            // cATEGORYDataGridView
            // 
            this.cATEGORYDataGridView.AutoGenerateColumns = false;
            this.cATEGORYDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.cATEGORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cATEGORYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cATEGORYDataGridView.DataSource = this.cATEGORYBindingSource;
            this.cATEGORYDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.cATEGORYDataGridView.Location = new System.Drawing.Point(423, 83);
            this.cATEGORYDataGridView.Name = "cATEGORYDataGridView";
            this.cATEGORYDataGridView.ReadOnly = true;
            this.cATEGORYDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cATEGORYDataGridView.Size = new System.Drawing.Size(442, 220);
            this.cATEGORYDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CAT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CAT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CAT_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "CAT_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CATEGORY_DESCRIPTION";
            this.dataGridViewTextBoxColumn3.HeaderText = "CATEGORY_DESCRIPTION";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 528);
            this.Controls.Add(this.cATEGORYDataGridView);
            this.Controls.Add(this.save);
            this.Controls.Add(this.categorydescription);
            this.Controls.Add(this.categoryname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.categoryid);
            this.Controls.Add(this.lnkLogOut);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private MetroFramework.Controls.MetroTextBox categorydescription;
        private MetroFramework.Controls.MetroTextBox categoryname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox categoryid;
        private MetroFramework.Controls.MetroTile save;
        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private CARRENTALDataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cATEGORYDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}