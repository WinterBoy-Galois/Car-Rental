namespace myCarRental
{
    partial class UpdateBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBrand));
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.bRANDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANDTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.BRANDTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.bRANDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.save = new MetroFramework.Controls.MetroTile();
            this.brandname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.brandid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANDDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cARRENTALDataSet
            // 
            this.cARRENTALDataSet.DataSetName = "CARRENTALDataSet";
            this.cARRENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bRANDBindingSource
            // 
            this.bRANDBindingSource.DataMember = "BRAND";
            this.bRANDBindingSource.DataSource = this.cARRENTALDataSet;
            // 
            // bRANDTableAdapter
            // 
            this.bRANDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BRANDTableAdapter = this.bRANDTableAdapter;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
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
            // bRANDDataGridView
            // 
            this.bRANDDataGridView.AutoGenerateColumns = false;
            this.bRANDDataGridView.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.bRANDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bRANDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bRANDDataGridView.DataSource = this.bRANDBindingSource;
            this.bRANDDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRANDDataGridView.Location = new System.Drawing.Point(365, 87);
            this.bRANDDataGridView.Name = "bRANDDataGridView";
            this.bRANDDataGridView.ReadOnly = true;
            this.bRANDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bRANDDataGridView.Size = new System.Drawing.Size(242, 236);
            this.bRANDDataGridView.TabIndex = 1;
            this.bRANDDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bRANDDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BRAND_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BRAND_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BRAND_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "BRAND_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(8, 22);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 32;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // save
            // 
            this.save.ActiveControl = null;
            this.save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save.Location = new System.Drawing.Point(23, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(202, 130);
            this.save.TabIndex = 31;
            this.save.Text = "Update";
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
            // brandname
            // 
            // 
            // 
            // 
            this.brandname.CustomButton.Image = null;
            this.brandname.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.brandname.CustomButton.Name = "";
            this.brandname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandname.CustomButton.TabIndex = 1;
            this.brandname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandname.CustomButton.UseSelectable = true;
            this.brandname.CustomButton.Visible = false;
            this.brandname.Lines = new string[0];
            this.brandname.Location = new System.Drawing.Point(164, 188);
            this.brandname.MaxLength = 32767;
            this.brandname.Name = "brandname";
            this.brandname.PasswordChar = '\0';
            this.brandname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandname.SelectedText = "";
            this.brandname.SelectionLength = 0;
            this.brandname.SelectionStart = 0;
            this.brandname.ShortcutsEnabled = true;
            this.brandname.Size = new System.Drawing.Size(195, 23);
            this.brandname.TabIndex = 30;
            this.brandname.UseSelectable = true;
            this.brandname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.brandname.Click += new System.EventHandler(this.brandname_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel2.Location = new System.Drawing.Point(23, 192);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Brand Name";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // brandid
            // 
            // 
            // 
            // 
            this.brandid.CustomButton.Image = null;
            this.brandid.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.brandid.CustomButton.Name = "";
            this.brandid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandid.CustomButton.TabIndex = 1;
            this.brandid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandid.CustomButton.UseSelectable = true;
            this.brandid.CustomButton.Visible = false;
            this.brandid.Lines = new string[0];
            this.brandid.Location = new System.Drawing.Point(164, 102);
            this.brandid.MaxLength = 32767;
            this.brandid.Name = "brandid";
            this.brandid.PasswordChar = '\0';
            this.brandid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandid.SelectedText = "";
            this.brandid.SelectionLength = 0;
            this.brandid.SelectionStart = 0;
            this.brandid.ShortcutsEnabled = true;
            this.brandid.Size = new System.Drawing.Size(195, 23);
            this.brandid.TabIndex = 28;
            this.brandid.UseSelectable = true;
            this.brandid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Brand ID";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // UpdateBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 417);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.save);
            this.Controls.Add(this.brandname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.brandid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bRANDDataGridView);
            this.Name = "UpdateBrand";
            this.Text = "UpdateBrand";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UpdateBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANDDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource bRANDBindingSource;
        private CARRENTALDataSetTableAdapters.BRANDTableAdapter bRANDTableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bRANDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroLink lnkLogOut;
        private MetroFramework.Controls.MetroTile save;
        private MetroFramework.Controls.MetroTextBox brandname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox brandid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}