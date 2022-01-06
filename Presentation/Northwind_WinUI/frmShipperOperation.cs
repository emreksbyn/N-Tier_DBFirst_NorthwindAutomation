using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmShipperOperation : Form
    {
        public frmShipperOperation()
        {
            InitializeComponent();
        }

        ShipperServices shipperServices = new ShipperServices();
        public ShipperDto Shipper { get; set; }

        private void frmShipperOperation_Load(object sender, EventArgs e)
        {
            txtShipperID.Enabled = false;

            if (Shipper != null)
            {
                txtShipperID.Text = Shipper.ShipperID.ToString();
                txtCompanyName.Text = Shipper.CompanyName;
                txtPhone.Text = Shipper.Phone;

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (Shipper != null)
            {

            }
            else
            {
                Shipper = new ShipperDto
                {
                    CompanyName = txtCompanyName.Text,
                    Phone = txtPhone.Text
                };

                shipperServices.AddShipper(Shipper);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
