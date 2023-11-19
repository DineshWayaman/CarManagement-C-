using CarManagement.Admin.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement.Admin
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private Cars carsController = new Cars();
        private Customers customerController = new Customers();
        private UserManagement userManagementController = new UserManagement();


        
        private void viewCarPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlController.Controls.Clear();
            pnlController.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void removeCarPanel(UserControl userControl)
        {
            pnlController.Controls.Remove(userControl);
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            pnlController.Visible = true;
            viewCarPanel(carsController);
        }

        private void mnHome_Click(object sender, EventArgs e)
        {
            removeCarPanel(carsController);
            pnlController.Visible=false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            pnlController.Visible = true;
            viewCarPanel(customerController);
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {

        }

        private void btnRental_Click(object sender, EventArgs e)
        {

        }

        private void btnUserMan_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlController.Visible = true;
            removeCarPanel(carsController);
            viewCarPanel(userManagementController);
        }
    }
}
