﻿namespace myCarRental
{
    partial class Reservationreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservationreport));
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(5, 22);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(73, 41);
            this.lnkLogOut.TabIndex = 8;
            this.lnkLogOut.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkLogOut.UseCustomBackColor = true;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(5, 63);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "C:\\Users\\Blessings\\Documents\\Visual Studio 2015\\Projects\\CARRENTAL PROJECT\\Databa" +
    "seManagementSystems\\CrystalReport11.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(926, 462);
            this.crystalReportViewer1.TabIndex = 9;
            // 
            // Reservationreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 525);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lnkLogOut);
            this.Name = "Reservationreport";
            this.Text = "Reservationreport";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}