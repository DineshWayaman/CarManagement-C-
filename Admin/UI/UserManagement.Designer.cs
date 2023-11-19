namespace CarManagement.Admin.UI
{
    partial class UserManagement
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
            this.btnUserInsertOpen = new System.Windows.Forms.Button();
            this.carTableAdapter = new CarManagement.car_managementDataSetTableAdapters.CarTableAdapter();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_managementDataSet = new CarManagement.car_managementDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUserID = new System.Windows.Forms.Label();
            this.grdCars = new System.Windows.Forms.DataGridView();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUUname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserInsertOpen
            // 
            this.btnUserInsertOpen.Location = new System.Drawing.Point(420, 184);
            this.btnUserInsertOpen.Name = "btnUserInsertOpen";
            this.btnUserInsertOpen.Size = new System.Drawing.Size(120, 52);
            this.btnUserInsertOpen.TabIndex = 43;
            this.btnUserInsertOpen.Text = "Insert";
            this.btnUserInsertOpen.UseVisualStyleBackColor = true;
            this.btnUserInsertOpen.Visible = false;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(376, 267);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(209, 34);
            this.txtUserSearch.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 38;
            this.label6.Text = "Search";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            // 
            // car_managementDataSet
            // 
            this.car_managementDataSet.DataSetName = "car_managementDataSet";
            this.car_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.car_managementDataSet;
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Location = new System.Drawing.Point(50, 21);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(34, 27);
            this.txtUserID.TabIndex = 42;
            this.txtUserID.Text = "ID";
            this.txtUserID.Visible = false;
            // 
            // grdCars
            // 
            this.grdCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCars.Location = new System.Drawing.Point(13, 318);
            this.grdCars.Name = "grdCars";
            this.grdCars.RowHeadersWidth = 51;
            this.grdCars.RowTemplate.Height = 24;
            this.grdCars.Size = new System.Drawing.Size(813, 296);
            this.grdCars.TabIndex = 37;
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(673, 184);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(120, 52);
            this.btnUserSave.TabIndex = 36;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserClear
            // 
            this.btnUserClear.Location = new System.Drawing.Point(547, 184);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(120, 52);
            this.btnUserClear.TabIndex = 35;
            this.btnUserClear.Text = "Clear";
            this.btnUserClear.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Role";
            // 
            // txtUUname
            // 
            this.txtUUname.Location = new System.Drawing.Point(147, 194);
            this.txtUUname.Name = "txtUUname";
            this.txtUUname.Size = new System.Drawing.Size(209, 34);
            this.txtUUname.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(147, 144);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 34);
            this.txtUserName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name";
            // 
            // txtUserNIC
            // 
            this.txtUserNIC.Location = new System.Drawing.Point(147, 99);
            this.txtUserNIC.Name = "txtUserNIC";
            this.txtUserNIC.Size = new System.Drawing.Size(209, 34);
            this.txtUserNIC.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "NIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "User Management";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Renter"});
            this.cmbRole.Location = new System.Drawing.Point(586, 99);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(209, 35);
            this.cmbRole.TabIndex = 44;
            // 
            // UserManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnUserInsertOpen);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.grdCars);
            this.Controls.Add(this.btnUserSave);
            this.Controls.Add(this.btnUserClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUUname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserNIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(841, 628);
            this.MinimumSize = new System.Drawing.Size(841, 628);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(841, 628);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserInsertOpen;
        private car_managementDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private car_managementDataSet car_managementDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.DataGridView grdCars;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUUname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}
