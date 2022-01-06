using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmProductOperation : Form
    {
        public frmProductOperation()
        {
            InitializeComponent();
        }

        ProductServices productServices = new ProductServices();
        public ProductDto Product { get; set; }

        private void frmProductOperation_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            if (Product != null)
            {
                txtProductID.Text = Product.ProductID.ToString();
                txtProductName.Text = Product.ProductName;
                txtSupplierID.Text = Product.SupplierID.ToString();
                txtCategoryID.Text = Product.CategoryID.ToString();
                txtQuantityPerUnit.Text = Product.QuantityPerUnit.ToString();
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
                txtUnitsInOrder.Text = Product.UnitsOnOrder.ToString();
                txtReorderLevel.Text = Product.ReorderLevel.ToString();
                txtDiscontinued.Text = Product.Discontinued.ToString();
                txtDiscontinued.Text = Product.Discontinued.ToString();

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (Product != null)
            {

            }
            else
            {
                Product = new ProductDto
                {
                    ProductName = txtProductName.Text,
                    SupplierID = int.Parse(txtSupplierID.Text),
                    CategoryID = int.Parse(txtCategoryID.Text),
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = short.Parse(txtUnitsInStock.Text),
                    UnitsOnOrder = short.Parse(txtUnitsInOrder.Text),
                    ReorderLevel = short.Parse(txtReorderLevel.Text),
                    Discontinued = bool.Parse(txtDiscontinued.Text)
                };

                productServices.AddProduct(Product);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
