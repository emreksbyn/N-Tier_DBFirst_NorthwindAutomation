using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmOrderOperation : Form
    {
        public frmOrderOperation()
        {
            InitializeComponent();
        }

        OrderServices orderServices = new OrderServices();
        public OrderDto Order { get; set; }

        private void frmOrderOperation_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = false;

            if (Order != null)
            {
                txtOrderID.Text = Order.CustomerID.ToString();
                txtCustomerID.Text = Order.CustomerID;
                txtEmployeeID.Text = Order.EmployeeID.ToString();
                dtOrderDate.Value = Order.OrderDate.Value;
                dtRequiredDate.Value = Order.RequiredDate.Value;
                dtShippedDate.Value = Order.ShippedDate.Value;
                txtShipVia.Text = Order.ShipVia.ToString();
                txtFreight.Text = Order.Freight.ToString();
                txtShipName.Text = Order.ShipName;
                txtShipAddress.Text = Order.ShipAddress;
                txtShipCity.Text = Order.ShipCity;
                txtShipRegion.Text = Order.ShipRegion;
                txtShipPostalCode.Text = Order.ShipPostalCode;
                txtShipCountry.Text = Order.ShipCountry;

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (Order != null)
            {

            }
            else
            {
                Order = new OrderDto
                {
                    CustomerID = txtCustomerID.Text,
                    EmployeeID = int.Parse(txtEmployeeID.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDate = dtOrderDate.Value,
                    RequiredDate = dtRequiredDate.Value,
                    ShipAddress = txtShipAddress.Text,
                    ShipCity = txtShipCity.Text,
                    ShipCountry = txtShipCountry.Text,
                    ShipName = txtShipName.Text,
                    ShippedDate = dtShippedDate.Value,
                    ShipPostalCode = txtShipPostalCode.Text,
                    ShipRegion = txtShipRegion.Text,
                    ShipVia = int.Parse(txtShipVia.Text)
                };

                orderServices.AddOrder(Order);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
