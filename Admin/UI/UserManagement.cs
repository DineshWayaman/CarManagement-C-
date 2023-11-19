using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement.Admin.UI
{
    public partial class UserManagement : UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Config.connectionString);
        private string userId;

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            if(btnUserSave.Text == "Save")
            {

            }
        }
    }
}
