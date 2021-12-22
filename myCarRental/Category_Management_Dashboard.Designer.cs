namespace myCarRental
{
    partial class Category_Management_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Management_Dashboard));
            this.CategoryTile = new MetroFramework.Controls.MetroTile();
            this.VehicleTile = new MetroFramework.Controls.MetroTile();
            this.RentalTile = new MetroFramework.Controls.MetroTile();
            this.ReservationTile = new MetroFramework.Controls.MetroTile();
            this.CustomerTile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // CategoryTile
            // 
            this.CategoryTile.ActiveControl = null;
            this.CategoryTile.BackColor = System.Drawing.Color.Red;
            this.CategoryTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CategoryTile.Location = new System.Drawing.Point(362, 385);
            this.CategoryTile.Name = "CategoryTile";
            this.CategoryTile.Size = new System.Drawing.Size(194, 133);
            this.CategoryTile.TabIndex = 10;
            this.CategoryTile.Text = "Add Vehicle Brand";
            this.CategoryTile.TileImage = ((System.Drawing.Image)(resources.GetObject("CategoryTile.TileImage")));
            this.CategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CategoryTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CategoryTile.UseCustomBackColor = true;
            this.CategoryTile.UseCustomForeColor = true;
            this.CategoryTile.UseSelectable = true;
            this.CategoryTile.UseStyleColors = true;
            this.CategoryTile.UseTileImage = true;
            this.CategoryTile.Click += new System.EventHandler(this.CategoryTile_Click);
            // 
            // VehicleTile
            // 
            this.VehicleTile.ActiveControl = null;
            this.VehicleTile.BackColor = System.Drawing.Color.Red;
            this.VehicleTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VehicleTile.Location = new System.Drawing.Point(97, 237);
            this.VehicleTile.Name = "VehicleTile";
            this.VehicleTile.Size = new System.Drawing.Size(206, 133);
            this.VehicleTile.TabIndex = 9;
            this.VehicleTile.Text = "MODEL MANAGEMENT";
            this.VehicleTile.TileImage = ((System.Drawing.Image)(resources.GetObject("VehicleTile.TileImage")));
            this.VehicleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.VehicleTile.UseCustomBackColor = true;
            this.VehicleTile.UseCustomForeColor = true;
            this.VehicleTile.UseSelectable = true;
            this.VehicleTile.UseStyleColors = true;
            this.VehicleTile.UseTileImage = true;
            this.VehicleTile.Click += new System.EventHandler(this.VehicleTile_Click);
            // 
            // RentalTile
            // 
            this.RentalTile.ActiveControl = null;
            this.RentalTile.BackColor = System.Drawing.Color.Red;
            this.RentalTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RentalTile.Location = new System.Drawing.Point(636, 73);
            this.RentalTile.Name = "RentalTile";
            this.RentalTile.Size = new System.Drawing.Size(194, 137);
            this.RentalTile.TabIndex = 8;
            this.RentalTile.Text = "Update vehicle Category";
            this.RentalTile.TileImage = ((System.Drawing.Image)(resources.GetObject("RentalTile.TileImage")));
            this.RentalTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RentalTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.RentalTile.UseCustomBackColor = true;
            this.RentalTile.UseCustomForeColor = true;
            this.RentalTile.UseSelectable = true;
            this.RentalTile.UseStyleColors = true;
            this.RentalTile.UseTileImage = true;
            this.RentalTile.Click += new System.EventHandler(this.RentalTile_Click);
            // 
            // ReservationTile
            // 
            this.ReservationTile.ActiveControl = null;
            this.ReservationTile.BackColor = System.Drawing.Color.Red;
            this.ReservationTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReservationTile.Location = new System.Drawing.Point(362, 73);
            this.ReservationTile.Name = "ReservationTile";
            this.ReservationTile.Size = new System.Drawing.Size(194, 137);
            this.ReservationTile.TabIndex = 7;
            this.ReservationTile.Text = "Delete Vehicle Category";
            this.ReservationTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ReservationTile.TileImage")));
            this.ReservationTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ReservationTile.UseCustomBackColor = true;
            this.ReservationTile.UseCustomForeColor = true;
            this.ReservationTile.UseSelectable = true;
            this.ReservationTile.UseStyleColors = true;
            this.ReservationTile.UseTileImage = true;
            this.ReservationTile.Click += new System.EventHandler(this.ReservationTile_Click);
            // 
            // CustomerTile
            // 
            this.CustomerTile.ActiveControl = null;
            this.CustomerTile.BackColor = System.Drawing.Color.Red;
            this.CustomerTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerTile.Location = new System.Drawing.Point(97, 73);
            this.CustomerTile.Name = "CustomerTile";
            this.CustomerTile.Size = new System.Drawing.Size(206, 137);
            this.CustomerTile.TabIndex = 6;
            this.CustomerTile.Text = "Add Vehicle Category";
            this.CustomerTile.TileImage = ((System.Drawing.Image)(resources.GetObject("CustomerTile.TileImage")));
            this.CustomerTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CustomerTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CustomerTile.UseCustomBackColor = true;
            this.CustomerTile.UseCustomForeColor = true;
            this.CustomerTile.UseSelectable = true;
            this.CustomerTile.UseTileImage = true;
            this.CustomerTile.Click += new System.EventHandler(this.CustomerTile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Red;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroTile1.Location = new System.Drawing.Point(97, 385);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(206, 133);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "Delete Vehicle Brand";
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
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.Red;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroTile3.Location = new System.Drawing.Point(636, 385);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(194, 133);
            this.metroTile3.TabIndex = 14;
            this.metroTile3.Text = "Update Vehicle Brand";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(13, 23);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 15;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // Category_Management_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 530);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.CategoryTile);
            this.Controls.Add(this.VehicleTile);
            this.Controls.Add(this.RentalTile);
            this.Controls.Add(this.ReservationTile);
            this.Controls.Add(this.CustomerTile);
            this.Name = "Category_Management_Dashboard";
            this.Text = "Category_Management_Dashboard";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile CategoryTile;
        private MetroFramework.Controls.MetroTile VehicleTile;
        private MetroFramework.Controls.MetroTile RentalTile;
        private MetroFramework.Controls.MetroTile ReservationTile;
        private MetroFramework.Controls.MetroTile CustomerTile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLink lnkLogOut;
    }
}