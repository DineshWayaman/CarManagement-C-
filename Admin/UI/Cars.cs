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
using System.Xml.Linq;

namespace CarManagement.Admin.UI
{


    public partial class Cars : UserControl
    {
        public Cars()
        {
            InitializeComponent();

    }


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2R1JK2K;Initial Catalog=car_management;Integrated Security=True;");
        private string carId;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarSave_Click(object sender, EventArgs e)
        {

        conn.Open();


            if(btnCarSave.Text == "Save")
            {

                if(txtCarReg.Text == "" || txtCarBrand.Text == "" || txtCarModel.Text == "" || txtCar1km.Text == "" || txtCarFPD.Text == "" || txtCarQty.Text == "")
                {
                    MessageBox.Show("All feileds are mandatory");
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("insert into Car (reg_no, brand, model, kmfee, odeometer, feeperday, qty) values ('" + txtCarReg.Text + "', '" + txtCarBrand.Text + "', '" + txtCarModel.Text + "', '" + decimal.Parse(txtCar1km.Text) + "', '" + decimal.Parse(txtCarOdeometer.Text) + "', '" + decimal.Parse(txtCarFPD.Text) + "', '" + int.Parse(txtCarQty.Text) + "')", conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Added Successfully");
                        bindCarData();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();

                    }

                }


                

            }
            else if(btnCarSave.Text == "Update")
            {


                if (txtCarReg.Text == "" || txtCarBrand.Text == "" || txtCarModel.Text == "" || txtCar1km.Text == "" || txtCarFPD.Text == "" || txtCarQty.Text == "")
                {
                    MessageBox.Show("All feileds are mandatory");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update Car set reg_no = '" + txtCarReg.Text + "', brand='" + txtCarBrand.Text + "', model='" + txtCarModel.Text + "', kmfee='" + decimal.Parse(txtCar1km.Text) + "', odeometer='" + txtCarOdeometer.Text + "', feeperday='" + txtCarFPD.Text + "', qty='" + txtCarQty.Text + "' where id='" + int.Parse(carId) + "'", conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car Updated Successfully");
                        bindCarData();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();

                    }
                }


               
            }
           







        }

        public void bindCarData()
        {
            SqlCommand cmd = new SqlCommand("select * from Car", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grdCars.DataSource = dt;
            
        }

        private void Cars_Load(object sender, EventArgs e)
        {

            bindCarData();

            
        }

        private void grdCars_CellContentClick(object sender, DataGridViewCellEventArgs e)

       
        {

           
        }

        private void grdCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("I'm in");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdCars.Rows[e.RowIndex];
                carId = row.Cells["ID"].Value.ToString();
                txtCarReg.Text = row.Cells["reg_no"].Value.ToString();
                txtCarBrand.Text = row.Cells["brand"].Value.ToString();
                txtCarModel.Text = row.Cells["model"].Value.ToString();
                txtCar1km.Text = row.Cells["kmfee"].Value.ToString();
                txtCarOdeometer.Text = row.Cells["odeometer"].Value.ToString();
                txtCarFPD.Text = row.Cells["feeperday"].Value.ToString();
                txtCarQty.Text = row.Cells["qty"].Value.ToString();

                btnCarSave.Text = "Update";
                btnCarClear.Text = "Delete";
                btnInsertOpen.Visible = true;


            }
        }

        private void btnCarClear_Click(object sender, EventArgs e)
        {
            

            if(btnCarClear.Text == "Clear") {
                clearTextBoxes();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete Car where id='" + int.Parse(carId) + "'", conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    bindCarData();
                    clearTextBoxes();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();

                }
            }
           
        }

        public void clearTextBoxes()
        {
            txtCarBrand.Text = "";
            txtCar1km.Text = "";
            txtCarFPD.Text = "";
            txtCarModel.Text = "";
            txtCarOdeometer.Text = "";
            txtCarQty.Text = "";
            txtCarReg.Text = "";
        }

        private void btnInsertOpen_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            btnInsertOpen.Visible = false;
            btnCarClear.Text = "Clear";
            btnCarSave.Text = "Save";
        }
    }
}
