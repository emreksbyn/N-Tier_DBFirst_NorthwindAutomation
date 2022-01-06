using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmCustomerOperation : Form
    {
        public frmCustomerOperation()
        {
            InitializeComponent();
        }

        CustomerServices customerServices = new CustomerServices();
        public CustomerDto Customer { get; set; }

        private void frmCustomerOperation_Load(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            if (Customer != null)
            {
                txtCustomerID.Text = Customer.CustomerID;
                txtCompanyName.Text = Customer.CompanyName;
                txtContactName.Text = Customer.ContactName;
                txtContactTitle.Text = Customer.ContactTitle;
                txtAdres.Text = Customer.Address;
                txtCity.Text = Customer.City;
                txtRegion.Text = Customer.Region;
                txtPostalCode.Text = Customer.PostalCode;
                txtCountry.Text = Customer.Country;
                txtPhone.Text = Customer.Phone;
                txtFax.Text = Customer.Fax;

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {

            }
            else
            {
                Customer = new CustomerDto
                {
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAdres.Text,
                    City = txtCity.Text,
                    Region = txtRegion.Text,
                    PostalCode = txtPostalCode.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    Fax = txtFax.Text
                };

                customerServices.AddCustomer(Customer);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
