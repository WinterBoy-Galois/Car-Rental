namespace myCarRental
{
    partial class DeleteCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomer));
            this.back = new MetroFramework.Controls.MetroLink();
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
            this.Searchbyphone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageSize = 32;
            this.back.Location = new System.Drawing.Point(4, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(69, 42);
            this.back.TabIndex = 0;
            this.back.UseCustomBackColor = true;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            this.cUSTOMERSDataGridView.Location = new System.Drawing.Point(4, 59);
            this.cUSTOMERSDataGridView.Name = "cUSTOMERSDataGridView";
            this.cUSTOMERSDataGridView.ReadOnly = true;
            this.cUSTOMERSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cUSTOMERSDataGridView.Size = new System.Drawing.Size(870, 290);
            this.cUSTOMERSDataGridView.TabIndex = 2;
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
            // Searchbyphone
            // 
            // 
            // 
            // 
            this.Searchbyphone.CustomButton.Image = null;
            this.Searchbyphone.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.Searchbyphone.CustomButton.Name = "";
            this.Searchbyphone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Searchbyphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Searchbyphone.CustomButton.TabIndex = 1;
            this.Searchbyphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Searchbyphone.CustomButton.UseSelectable = true;
            this.Searchbyphone.CustomButton.Visible = false;
            this.Searchbyphone.Lines = new string[0];
            this.Searchbyphone.Location = new System.Drawing.Point(201, 367);
            this.Searchbyphone.MaxLength = 32767;
            this.Searchbyphone.Name = "Searchbyphone";
            this.Searchbyphone.PasswordChar = '\0';
            this.Searchbyphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Searchbyphone.SelectedText = "";
            this.Searchbyphone.SelectionLength = 0;
            this.Searchbyphone.SelectionStart = 0;
            this.Searchbyphone.ShortcutsEnabled = true;
            this.Searchbyphone.Size = new System.Drawing.Size(329, 23);
            this.Searchbyphone.TabIndex = 4;
            this.Searchbyphone.UseSelectable = true;
            this.Searchbyphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Searchbyphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Searchbyphone.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroLabel1.Location = new System.Drawing.Point(4, 367);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Search by phonenumber";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 493);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Searchbyphone);
            this.Controls.Add(this.cUSTOMERSDataGridView);
            this.Controls.Add(this.back);
            this.Name = "DeleteCustomer";
            this.Text = "       DeleteCustomer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DeleteCustomer_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.cARRENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink back;
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
        private MetroFramework.Controls.MetroTextBox Searchbyphone;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}