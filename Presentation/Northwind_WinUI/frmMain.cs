using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        readonly CategoryServices categoryServices = new CategoryServices();
        readonly CustomerServices customerServices = new CustomerServices();
        readonly EmployeeServices employeeServices = new EmployeeServices();
        readonly OrderDetailServices orderDetailServices = new OrderDetailServices();
        readonly OrderServices orderServices = new OrderServices();
        readonly ProductServices productServices = new ProductServices();
        readonly ShipperServices shipperServices = new ShipperServices();
        readonly SupplierServices supplierServices = new SupplierServices();
        private void frmMain_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn addColumn = new DataGridViewImageColumn();
            addColumn.HeaderText = "";
            addColumn.Name = "add";
            addColumn.Width = 30;
            addColumn.Image = new Bitmap(Properties.Resources.addition);
            addColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            addColumn.FillWeight = 20;
            dgvNorthwind.Columns.Insert(0, addColumn);
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = SystemColors.Control;
            var retVal = categoryServices.GetAllCategory();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Categories;
            else
                MessageBox.Show(retVal.ErrorMessage);
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = SystemColors.ButtonFace;
            var retVal = customerServices.GetAllCustomers();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Customers;
            else
                MessageBox.Show(retVal.ErrorMessage);
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = SystemColors.ControlLight;
            var retVal = employeeServices.GetAllEmployees();

            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Employees;
            else
                MessageBox.Show(retVal.ErrorMessage);
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = Color.LightGray;
            var retVal = orderDetailServices.GetAllOrderDetails();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.OrderDetails;
            else
                MessageBox.Show(retVal.ErrorMessage);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = SystemColors.Menu;
            var retVal = orderServices.GetAllOrders();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Orders;
            else
                MessageBox.Show(retVal.ErrorMessage);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = SystemColors.MenuBar;
            var retVal = productServices.GetAllProducts();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Products;
            else
                MessageBox.Show(retVal.ErrorMessage);
        }

        private void btnShippers_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = Color.Gainsboro;
            var retVal = shipperServices.GetAllShippers();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Shippers;
            else
                MessageBox.Show(retVal.ErrorMessage);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            dgvNorthwind.BackgroundColor = Color.WhiteSmoke;
            var retVal = supplierServices.GetAllSuppliers();
            if (retVal.IsValid)
                dgvNorthwind.DataSource = retVal.Suppliers;
            else
                MessageBox.Show(retVal.ErrorMessage);

        }

        private void dgvNorthwind_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv != null && dgv.CurrentCell.ColumnIndex == 0)
            {
                if (dgv.BackgroundColor == SystemColors.Control)
                {
                    frmCategoryOperation frm = new frmCategoryOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = categoryServices.GetAllCategory();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Categories;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }

                }
                else if (dgv.BackgroundColor == SystemColors.ButtonFace)
                {
                    frmCustomerOperation frm = new frmCustomerOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = customerServices.GetAllCustomers();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Customers;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.ControlLight)
                {
                    frmEmployeeOperation frm = new frmEmployeeOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = employeeServices.GetAllEmployees();

                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Employees;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.Menu)
                {
                    frmOrderOperation frm = new frmOrderOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = orderServices.GetAllOrders();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Orders;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.MenuBar)
                {
                    frmProductOperation frm = new frmProductOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = productServices.GetAllProducts();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Products;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }

                }
                else if (dgv.BackgroundColor == Color.Gainsboro)
                {
                    frmShipperOperation frm = new frmShipperOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = shipperServices.GetAllShippers();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Shippers;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }

                }
                else if (dgv.BackgroundColor == Color.WhiteSmoke)
                {
                    frmSupplierOperation frm = new frmSupplierOperation();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = supplierServices.GetAllSuppliers();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Suppliers;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
            }
            else
            {
                if (dgv.BackgroundColor == SystemColors.Control)
                {
                    CategoryDto categoryDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as CategoryDto;

                    frmCategoryOperation frm = new frmCategoryOperation
                    {
                        Category = categoryDto
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = categoryServices.GetAllCategory();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Categories;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.ButtonFace)
                {
                    CustomerDto customerDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as CustomerDto;

                    frmCustomerOperation frm = new frmCustomerOperation
                    {
                        Customer = customerDto
                    };
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = customerServices.GetAllCustomers();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Customers;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.ControlLight)
                {
                    EmployeeDto employeeDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as EmployeeDto;

                    frmEmployeeOperation frm = new frmEmployeeOperation
                    {
                        Employee = employeeDto
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = employeeServices.GetAllEmployees();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Employees;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.Menu)
                {
                    OrderDto orderDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as OrderDto;

                    frmOrderOperation frm = new frmOrderOperation
                    {
                        Order = orderDto
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = orderServices.GetAllOrders();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Orders;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == SystemColors.MenuBar)
                {
                    ProductDto productDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as ProductDto;

                    frmProductOperation frm = new frmProductOperation
                    {
                        Product = productDto
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = productServices.GetAllProducts();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Products;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }

                }
                else if (dgv.BackgroundColor == Color.Gainsboro)
                {
                    ShipperDto shipperDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as ShipperDto;

                    frmShipperOperation frm = new frmShipperOperation
                    {
                        Shipper = shipperDto
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = shipperServices.GetAllShippers();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Shippers;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }
                }
                else if (dgv.BackgroundColor == Color.WhiteSmoke)
                {
                    SupplierDto supplierDto = dgvNorthwind.Rows[e.RowIndex].DataBoundItem as SupplierDto;

                    frmSupplierOperation frm = new frmSupplierOperation
                    {
                        Supplier = supplierDto
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var retVal = supplierServices.GetAllSuppliers();
                        if (retVal.IsValid)
                            dgvNorthwind.DataSource = retVal.Suppliers;
                        else
                            MessageBox.Show(retVal.ErrorMessage);
                    }

                }
            }
        }
    }
}
