using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Dinesh")
            {
                if(txtPassword.Text == "1234")
                {
                    this.Hide();
                    Admin.MainMenu mainMenu = new Admin.MainMenu();
                    mainMenu.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Wrong User Name");
            }
        }
    }
}
