namespace CarManagement.Admin.UI
{
    partial class Cars
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCar1km = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarOdeometer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarFPD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCarClear = new System.Windows.Forms.Button();
            this.btnCarSave = new System.Windows.Forms.Button();
            this.grdCars = new System.Windows.Forms.DataGridView();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_managementDataSet = new CarManagement.car_managementDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarSearch = new System.Windows.Forms.TextBox();
            this.txtCarQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.carTableAdapter = new CarManagement.car_managementDataSetTableAdapters.CarTableAdapter();
            this.txtID = new System.Windows.Forms.Label();
            this.btnInsertOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg. No";
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(147, 99);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(209, 34);
            this.txtCarReg.TabIndex = 2;
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(147, 144);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(209, 34);
            this.txtCarBrand.TabIndex = 4;
            this.txtCarBrand.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCar1km
            // 
            this.txtCar1km.Location = new System.Drawing.Point(147, 194);
            this.txtCar1km.Name = "txtCar1km";
            this.txtCar1km.Size = new System.Drawing.Size(209, 34);
            this.txtCar1km.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fee(1KM)";
            // 
            // txtCarOdeometer
            // 
            this.txtCarOdeometer.Location = new System.Drawing.Point(147, 244);
            this.txtCarOdeometer.Name = "txtCarOdeometer";
            this.txtCarOdeometer.Size = new System.Drawing.Size(209, 34);
            this.txtCarOdeometer.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Odeometer";
            // 
            // txtCarFPD
            // 
            this.txtCarFPD.Location = new System.Drawing.Point(586, 144);
            this.txtCarFPD.Name = "txtCarFPD";
            this.txtCarFPD.Size = new System.Drawing.Size(209, 34);
            this.txtCarFPD.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "FPD";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(586, 95);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(209, 34);
            this.txtCarModel.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Model";
            // 
            // btnCarClear
            // 
            this.btnCarClear.Location = new System.Drawing.Point(549, 232);
            this.btnCarClear.Name = "btnCarClear";
            this.btnCarClear.Size = new System.Drawing.Size(120, 52);
            this.btnCarClear.TabIndex = 13;
            this.btnCarClear.Text = "Clear";
            this.btnCarClear.UseVisualStyleBackColor = true;
            this.btnCarClear.Click += new System.EventHandler(this.btnCarClear_Click);
            // 
            // btnCarSave
            // 
            this.btnCarSave.Location = new System.Drawing.Point(675, 232);
            this.btnCarSave.Name = "btnCarSave";
            this.btnCarSave.Size = new System.Drawing.Size(120, 52);
            this.btnCarSave.TabIndex = 14;
            this.btnCarSave.Text = "Save";
            this.btnCarSave.UseVisualStyleBackColor = true;
            this.btnCarSave.Click += new System.EventHandler(this.btnCarSave_Click);
            // 
            // grdCars
            // 
            this.grdCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCars.Location = new System.Drawing.Point(14, 366);
            this.grdCars.Name = "grdCars";
            this.grdCars.RowHeadersWidth = 51;
            this.grdCars.RowTemplate.Height = 24;
            this.grdCars.Size = new System.Drawing.Size(813, 241);
            this.grdCars.TabIndex = 15;
            this.grdCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCars_CellClick);
            this.grdCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCars_CellContentClick);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.car_managementDataSet;
            // 
            // car_managementDataSet
            // 
            this.car_managementDataSet.DataSetName = "car_managementDataSet";
            this.car_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search";
            // 
            // txtCarSearch
            // 
            this.txtCarSearch.Location = new System.Drawing.Point(377, 315);
            this.txtCarSearch.Name = "txtCarSearch";
            this.txtCarSearch.Size = new System.Drawing.Size(209, 34);
            this.txtCarSearch.TabIndex = 17;
            // 
            // txtCarQty
            // 
            this.txtCarQty.Location = new System.Drawing.Point(586, 191);
            this.txtCarQty.Name = "txtCarQty";
            this.txtCarQty.Size = new System.Drawing.Size(209, 34);
            this.txtCarQty.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Qty";
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(50, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 27);
            this.txtID.TabIndex = 20;
            this.txtID.Text = "ID";
            this.txtID.Visible = false;
            // 
            // btnInsertOpen
            // 
            this.btnInsertOpen.Location = new System.Drawing.Point(422, 232);
            this.btnInsertOpen.Name = "btnInsertOpen";
            this.btnInsertOpen.Size = new System.Drawing.Size(120, 52);
            this.btnInsertOpen.TabIndex = 21;
            this.btnInsertOpen.Text = "Insert";
            this.btnInsertOpen.UseVisualStyleBackColor = true;
            this.btnInsertOpen.Visible = false;
            this.btnInsertOpen.Click += new System.EventHandler(this.btnInsertOpen_Click);
            // 
            // Cars
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnInsertOpen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCarQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCarSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdCars);
            this.Controls.Add(this.btnCarSave);
            this.Controls.Add(this.btnCarClear);
            this.Controls.Add(this.txtCarFPD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCarOdeometer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCar1km);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(841, 628);
            this.MinimumSize = new System.Drawing.Size(841, 628);
            this.Name = "Cars";
            this.Size = new System.Drawing.Size(841, 628);
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCar1km;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarOdeometer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarFPD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCarClear;
        private System.Windows.Forms.Button btnCarSave;
        private System.Windows.Forms.DataGridView grdCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarSearch;
        private System.Windows.Forms.TextBox txtCarQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeometerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeperdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private car_managementDataSet car_managementDataSet;
        private car_managementDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btnInsertOpen;
    }
}
