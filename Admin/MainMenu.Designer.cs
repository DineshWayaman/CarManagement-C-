namespace CarManagement.Admin
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnUserMan = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnlAdminHome = new System.Windows.Forms.Panel();
            this.pnlController = new System.Windows.Forms.Panel();
            this.mnUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlAdminHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHome,
            this.mnUserManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHome
            // 
            this.mnHome.Name = "mnHome";
            this.mnHome.Size = new System.Drawing.Size(64, 24);
            this.mnHome.Text = "Home";
            this.mnHome.Click += new System.EventHandler(this.mnHome_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Car Rental Management System";
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(115, 138);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(185, 105);
            this.btnCars.TabIndex = 9;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnCus
            // 
            this.btnCus.Location = new System.Drawing.Point(363, 138);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(185, 105);
            this.btnCus.TabIndex = 10;
            this.btnCus.Text = "Customers";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(610, 138);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(185, 105);
            this.btnDriver.TabIndex = 11;
            this.btnDriver.Text = "Driver Managment";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(115, 293);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(185, 105);
            this.btnRental.TabIndex = 12;
            this.btnRental.Text = "Rental Management";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 105);
            this.button5.TabIndex = 13;
            this.button5.Text = "Customers";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnUserMan
            // 
            this.btnUserMan.Location = new System.Drawing.Point(610, 293);
            this.btnUserMan.Name = "btnUserMan";
            this.btnUserMan.Size = new System.Drawing.Size(185, 105);
            this.btnUserMan.TabIndex = 14;
            this.btnUserMan.Text = "User Managment";
            this.btnUserMan.UseVisualStyleBackColor = true;
            this.btnUserMan.Click += new System.EventHandler(this.btnUserMan_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(301, 470);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(310, 105);
            this.btnSales.TabIndex = 15;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // pnlAdminHome
            // 
            this.pnlAdminHome.Controls.Add(this.pnlController);
            this.pnlAdminHome.Controls.Add(this.btnSales);
            this.pnlAdminHome.Controls.Add(this.btnUserMan);
            this.pnlAdminHome.Controls.Add(this.button5);
            this.pnlAdminHome.Controls.Add(this.btnRental);
            this.pnlAdminHome.Controls.Add(this.btnDriver);
            this.pnlAdminHome.Controls.Add(this.btnCus);
            this.pnlAdminHome.Controls.Add(this.btnCars);
            this.pnlAdminHome.Controls.Add(this.label1);
            this.pnlAdminHome.Location = new System.Drawing.Point(56, 29);
            this.pnlAdminHome.MaximumSize = new System.Drawing.Size(911, 628);
            this.pnlAdminHome.MinimumSize = new System.Drawing.Size(911, 628);
            this.pnlAdminHome.Name = "pnlAdminHome";
            this.pnlAdminHome.Size = new System.Drawing.Size(911, 628);
            this.pnlAdminHome.TabIndex = 0;
            // 
            // pnlController
            // 
            this.pnlController.Location = new System.Drawing.Point(27, 0);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(911, 628);
            this.pnlController.TabIndex = 16;
            this.pnlController.Visible = false;
            // 
            // mnUserManagement
            // 
            this.mnUserManagement.Name = "mnUserManagement";
            this.mnUserManagement.Size = new System.Drawing.Size(144, 24);
            this.mnUserManagement.Text = "User Management";
            this.mnUserManagement.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1035, 665);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlAdminHome);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAdminHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnUserMan;
        private System.Windows.Forms.Panel pnlAdminHome;
        private System.Windows.Forms.Panel pnlController;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.ToolStripMenuItem mnUserManagement;
    }
}