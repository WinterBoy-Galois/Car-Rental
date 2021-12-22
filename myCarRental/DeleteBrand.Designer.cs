namespace myCarRental
{
    partial class DeleteBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBrand));
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.bRANDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRANDTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.BRANDTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.bRANDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbybrand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
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
            this.bRANDDataGridView.Location = new System.Drawing.Point(168, 63);
            this.bRANDDataGridView.Name = "bRANDDataGridView";
            this.bRANDDataGridView.ReadOnly = true;
            this.bRANDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bRANDDataGridView.Size = new System.Drawing.Size(269, 228);
            this.bRANDDataGridView.TabIndex = 1;
            this.bRANDDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bRANDDataGridView_CellContentClick);
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
            // searchbybrand
            // 
            // 
            // 
            // 
            this.searchbybrand.CustomButton.Image = null;
            this.searchbybrand.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.searchbybrand.CustomButton.Name = "";
            this.searchbybrand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchbybrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchbybrand.CustomButton.TabIndex = 1;
            this.searchbybrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchbybrand.CustomButton.UseSelectable = true;
            this.searchbybrand.CustomButton.Visible = false;
            this.searchbybrand.Lines = new string[0];
            this.searchbybrand.Location = new System.Drawing.Point(264, 322);
            this.searchbybrand.MaxLength = 32767;
            this.searchbybrand.Name = "searchbybrand";
            this.searchbybrand.PasswordChar = '\0';
            this.searchbybrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchbybrand.SelectedText = "";
            this.searchbybrand.SelectionLength = 0;
            this.searchbybrand.SelectionStart = 0;
            this.searchbybrand.ShortcutsEnabled = true;
            this.searchbybrand.Size = new System.Drawing.Size(249, 23);
            this.searchbybrand.TabIndex = 2;
            this.searchbybrand.UseSelectable = true;
            this.searchbybrand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchbybrand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchbybrand.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 326);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "search by brand name";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(7, 23);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 27;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // DeleteBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 503);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.searchbybrand);
            this.Controls.Add(this.bRANDDataGridView);
            this.Name = "DeleteBrand";
            this.Text = "DeleteBrand";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DeleteBrand_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DeleteBrand_MouseDoubleClick);
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
        private MetroFramework.Controls.MetroTextBox searchbybrand;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink lnkLogOut;
    }
}