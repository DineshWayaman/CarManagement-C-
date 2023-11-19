using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{
    public partial class Config : Component
    {
        public Config()
        {
            InitializeComponent();
        }

        public Config(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public static string connectionString = "Data Source=DESKTOP-2R1JK2K;Initial Catalog=car_management;Integrated Security=True;";
       


    }
}
