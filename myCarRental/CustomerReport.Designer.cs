namespace myCarRental
{
    partial class CustomerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReport));
            this.DashBoardLink = new MetroFramework.Controls.MetroLink();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.SuspendLayout();
            // 
            // DashBoardLink
            // 
            this.DashBoardLink.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DashBoardLink.Image = ((System.Drawing.Image)(resources.GetObject("DashBoardLink.Image")));
            this.DashBoardLink.ImageSize = 32;
            this.DashBoardLink.Location = new System.Drawing.Point(2, 13);
            this.DashBoardLink.Name = "DashBoardLink";
            this.DashBoardLink.Size = new System.Drawing.Size(70, 41);
            this.DashBoardLink.TabIndex = 6;
            this.DashBoardLink.UseCustomBackColor = true;
            this.DashBoardLink.UseSelectable = true;
            this.DashBoardLink.Click += new System.EventHandler(this.DashBoardLink_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(23, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "C:\\Users\\Blessings\\Documents\\Visual Studio 2015\\Projects\\CARRENTAL PROJECT\\Databa" +
    "seManagementSystems\\CrystalReport2.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(896, 361);
            this.crystalReportViewer1.TabIndex = 7;
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 530);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.DashBoardLink);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink DashBoardLink;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
    }
}