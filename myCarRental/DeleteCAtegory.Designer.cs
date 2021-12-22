namespace myCarRental
{
    partial class DeleteCAtegory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCAtegory));
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.cARRENTALDataSet = new myCarRental.CARRENTALDataSet();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYTableAdapter = new myCarRental.CARRENTALDataSetTableAdapters.CATEGORYTableAdapter();
            this.tableAdapterManager = new myCarRental.CARRENTALDataSetTableAdapters.TableAdapterManager();
            this.cATEGORYDataGridView = new System.Windows.Forms.DataGridView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.lnkLogOut.Location = new System.Drawing.Point(2, 17);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 17;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
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
            this.cATEGORYDataGridView.Location = new System.Drawing.Point(191, 74);
            this.cATEGORYDataGridView.Name = "cATEGORYDataGridView";
            this.cATEGORYDataGridView.ReadOnly = true;
            this.cATEGORYDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cATEGORYDataGridView.Size = new System.Drawing.Size(441, 220);
            this.cATEGORYDataGridView.TabIndex = 18;
            this.cATEGORYDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cATEGORYDataGridView_CellContentClick);
            this.cATEGORYDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cATEGORYDataGridView_MouseDoubleClick);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(253, 349);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(362, 23);
            this.metroTextBox1.TabIndex = 19;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(23, 349);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "search by category name";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
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
            // DeleteCAtegory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.cATEGORYDataGridView);
            this.Controls.Add(this.lnkLogOut);
            this.Name = "DeleteCAtegory";
            this.Text = "DeleteCAtegory";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DeleteCAtegory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private CARRENTALDataSet cARRENTALDataSet;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private CARRENTALDataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private CARRENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cATEGORYDataGridView;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}