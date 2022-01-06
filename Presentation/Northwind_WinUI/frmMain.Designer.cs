namespace Northwind_WinUI
{
    partial class frmMain
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
            this.groupBoxNorthwind = new System.Windows.Forms.GroupBox();
            this.dgvNorthwind = new System.Windows.Forms.DataGridView();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnShippers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.groupBoxNorthwind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNorthwind)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNorthwind
            // 
            this.groupBoxNorthwind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNorthwind.Controls.Add(this.dgvNorthwind);
            this.groupBoxNorthwind.Location = new System.Drawing.Point(7, 61);
            this.groupBoxNorthwind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxNorthwind.Name = "groupBoxNorthwind";
            this.groupBoxNorthwind.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxNorthwind.Size = new System.Drawing.Size(1000, 431);
            this.groupBoxNorthwind.TabIndex = 0;
            this.groupBoxNorthwind.TabStop = false;
            this.groupBoxNorthwind.Text = "Tables :";
            // 
            // dgvNorthwind
            // 
            this.dgvNorthwind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNorthwind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNorthwind.Location = new System.Drawing.Point(4, 17);
            this.dgvNorthwind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvNorthwind.Name = "dgvNorthwind";
            this.dgvNorthwind.RowHeadersWidth = 51;
            this.dgvNorthwind.Size = new System.Drawing.Size(992, 411);
            this.dgvNorthwind.TabIndex = 0;
            this.dgvNorthwind.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNorthwind_CellDoubleClick);
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(12, 12);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(119, 43);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(136, 12);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(119, 43);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(260, 12);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(119, 43);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(384, 12);
            this.btnOrderDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(119, 43);
            this.btnOrderDetails.TabIndex = 1;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(508, 12);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(119, 43);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(632, 12);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(119, 43);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnShippers
            // 
            this.btnShippers.Location = new System.Drawing.Point(756, 12);
            this.btnShippers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShippers.Name = "btnShippers";
            this.btnShippers.Size = new System.Drawing.Size(119, 43);
            this.btnShippers.TabIndex = 1;
            this.btnShippers.Text = "Shippers";
            this.btnShippers.UseVisualStyleBackColor = true;
            this.btnShippers.Click += new System.EventHandler(this.btnShippers_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(879, 12);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(119, 43);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1011, 495);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnShippers);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.groupBoxNorthwind);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Tablolar";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxNorthwind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNorthwind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNorthwind;
        private System.Windows.Forms.DataGridView dgvNorthwind;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnShippers;
        private System.Windows.Forms.Button btnSuppliers;
    }
}