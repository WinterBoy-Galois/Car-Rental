namespace myCarRental
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.CustomerTile = new MetroFramework.Controls.MetroTile();
            this.ReservationTile = new MetroFramework.Controls.MetroTile();
            this.RentalTile = new MetroFramework.Controls.MetroTile();
            this.VehicleTile = new MetroFramework.Controls.MetroTile();
            this.CategoryTile = new MetroFramework.Controls.MetroTile();
            this.ChangePasswordTile = new MetroFramework.Controls.MetroTile();
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // CustomerTile
            // 
            this.CustomerTile.ActiveControl = null;
            this.CustomerTile.BackColor = System.Drawing.Color.Red;
            this.CustomerTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerTile.Location = new System.Drawing.Point(34, 88);
            this.CustomerTile.Name = "CustomerTile";
            this.CustomerTile.Size = new System.Drawing.Size(193, 125);
            this.CustomerTile.TabIndex = 0;
            this.CustomerTile.Text = "Customer Management";
            this.CustomerTile.TileImage = ((System.Drawing.Image)(resources.GetObject("CustomerTile.TileImage")));
            this.CustomerTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CustomerTile.UseCustomBackColor = true;
            this.CustomerTile.UseCustomForeColor = true;
            this.CustomerTile.UseSelectable = true;
            this.CustomerTile.UseTileImage = true;
            this.CustomerTile.Click += new System.EventHandler(this.CustomerTile_Click);
            // 
            // ReservationTile
            // 
            this.ReservationTile.ActiveControl = null;
            this.ReservationTile.BackColor = System.Drawing.Color.Red;
            this.ReservationTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReservationTile.Location = new System.Drawing.Point(299, 88);
            this.ReservationTile.Name = "ReservationTile";
            this.ReservationTile.Size = new System.Drawing.Size(194, 125);
            this.ReservationTile.TabIndex = 1;
            this.ReservationTile.Text = "Reservation Management";
            this.ReservationTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ReservationTile.TileImage")));
            this.ReservationTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ReservationTile.UseCustomBackColor = true;
            this.ReservationTile.UseCustomForeColor = true;
            this.ReservationTile.UseSelectable = true;
            this.ReservationTile.UseStyleColors = true;
            this.ReservationTile.UseTileImage = true;
            this.ReservationTile.Click += new System.EventHandler(this.ReservationTile_Click);
            // 
            // RentalTile
            // 
            this.RentalTile.ActiveControl = null;
            this.RentalTile.BackColor = System.Drawing.Color.Red;
            this.RentalTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RentalTile.Location = new System.Drawing.Point(582, 88);
            this.RentalTile.Name = "RentalTile";
            this.RentalTile.Size = new System.Drawing.Size(194, 125);
            this.RentalTile.TabIndex = 2;
            this.RentalTile.Text = "Rental Management";
            this.RentalTile.TileImage = ((System.Drawing.Image)(resources.GetObject("RentalTile.TileImage")));
            this.RentalTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.RentalTile.UseCustomBackColor = true;
            this.RentalTile.UseCustomForeColor = true;
            this.RentalTile.UseSelectable = true;
            this.RentalTile.UseStyleColors = true;
            this.RentalTile.UseTileImage = true;
            this.RentalTile.Click += new System.EventHandler(this.RentalTile_Click);
            // 
            // VehicleTile
            // 
            this.VehicleTile.ActiveControl = null;
            this.VehicleTile.BackColor = System.Drawing.Color.Red;
            this.VehicleTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VehicleTile.Location = new System.Drawing.Point(34, 270);
            this.VehicleTile.Name = "VehicleTile";
            this.VehicleTile.Size = new System.Drawing.Size(193, 118);
            this.VehicleTile.TabIndex = 3;
            this.VehicleTile.Text = "Vehicle Management";
            this.VehicleTile.TileImage = ((System.Drawing.Image)(resources.GetObject("VehicleTile.TileImage")));
            this.VehicleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.VehicleTile.UseCustomBackColor = true;
            this.VehicleTile.UseCustomForeColor = true;
            this.VehicleTile.UseSelectable = true;
            this.VehicleTile.UseStyleColors = true;
            this.VehicleTile.UseTileImage = true;
            this.VehicleTile.Click += new System.EventHandler(this.VehicleTile_Click);
            // 
            // CategoryTile
            // 
            this.CategoryTile.ActiveControl = null;
            this.CategoryTile.BackColor = System.Drawing.Color.Red;
            this.CategoryTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CategoryTile.Location = new System.Drawing.Point(299, 270);
            this.CategoryTile.Name = "CategoryTile";
            this.CategoryTile.Size = new System.Drawing.Size(194, 118);
            this.CategoryTile.TabIndex = 4;
            this.CategoryTile.Text = "Category Management";
            this.CategoryTile.TileImage = ((System.Drawing.Image)(resources.GetObject("CategoryTile.TileImage")));
            this.CategoryTile.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CategoryTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CategoryTile.UseCustomBackColor = true;
            this.CategoryTile.UseCustomForeColor = true;
            this.CategoryTile.UseSelectable = true;
            this.CategoryTile.UseStyleColors = true;
            this.CategoryTile.UseTileImage = true;
            this.CategoryTile.Click += new System.EventHandler(this.CategoryTile_Click);
            // 
            // ChangePasswordTile
            // 
            this.ChangePasswordTile.ActiveControl = null;
            this.ChangePasswordTile.BackColor = System.Drawing.Color.Red;
            this.ChangePasswordTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePasswordTile.Location = new System.Drawing.Point(582, 270);
            this.ChangePasswordTile.Name = "ChangePasswordTile";
            this.ChangePasswordTile.Size = new System.Drawing.Size(194, 118);
            this.ChangePasswordTile.TabIndex = 5;
            this.ChangePasswordTile.Text = "Change Password";
            this.ChangePasswordTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ChangePasswordTile.TileImage")));
            this.ChangePasswordTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ChangePasswordTile.UseCustomBackColor = true;
            this.ChangePasswordTile.UseCustomForeColor = true;
            this.ChangePasswordTile.UseSelectable = true;
            this.ChangePasswordTile.UseStyleColors = true;
            this.ChangePasswordTile.UseTileImage = true;
            this.ChangePasswordTile.Click += new System.EventHandler(this.ChangePasswordTile_Click);
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(11, 22);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(57, 34);
            this.lnkLogOut.TabIndex = 6;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(799, 479);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.ChangePasswordTile);
            this.Controls.Add(this.CategoryTile);
            this.Controls.Add(this.VehicleTile);
            this.Controls.Add(this.RentalTile);
            this.Controls.Add(this.ReservationTile);
            this.Controls.Add(this.CustomerTile);
            this.Name = "Dashboard";
            this.Resizable = false;
            this.Text = "        Dashboard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile CustomerTile;
        private MetroFramework.Controls.MetroTile ReservationTile;
        private MetroFramework.Controls.MetroTile RentalTile;
        private MetroFramework.Controls.MetroTile VehicleTile;
        private MetroFramework.Controls.MetroTile CategoryTile;
        private MetroFramework.Controls.MetroTile ChangePasswordTile;
        private MetroFramework.Controls.MetroLink lnkLogOut;
    }
}