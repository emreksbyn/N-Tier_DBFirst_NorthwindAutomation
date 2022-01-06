using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmSupplierOperation : Form
    {
        public frmSupplierOperation()
        {
            InitializeComponent();
        }

        SupplierServices supplierServices = new SupplierServices();
        public SupplierDto Supplier { get; set; }

        private void frmSupplierOperation_Load(object sender, EventArgs e)
        {
            txtSupplierID.Enabled = false;

            if (Supplier != null)
            {
                txtSupplierID.Text = Supplier.SupplierID.ToString();
                txtCompanyName.Text = Supplier.CompanyName;
                txtContactName.Text = Supplier.ContactName;
                txtContactTitle.Text = Supplier.ContactTitle;
                txtAdres.Text = Supplier.Address;
                txtCity.Text = Supplier.City;
                txtRegion.Text = Supplier.Region;
                txtPostalCode.Text = Supplier.PostalCode;
                txtCountry.Text = Supplier.Country;
                txtPhone.Text = Supplier.Phone;
                txtFax.Text = Supplier.Fax;

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (Supplier != null)
            {

            }
            else
            {
                Supplier = new SupplierDto
                {
                    Address = txtAdres.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactName.Text,
                    Country = txtCountry.Text,
                    Fax = txtFax.Text,
                    Phone = txtPhone.Text,
                    PostalCode = txtPostalCode.Text,
                    Region = txtRegion.Text
                };

                supplierServices.AddSupllier(Supplier);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
