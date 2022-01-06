using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmCategoryOperation : Form
    {
        public frmCategoryOperation()
        {
            InitializeComponent();
        }


        CategoryServices categoryServices = new CategoryServices();
        public CategoryDto Category { get; set; }

        private void frmCategoryOperation_Load(object sender, EventArgs e)
        {
            txtCategoryID.Enabled = false;

            if (Category != null)
            {
                txtCategoryID.Text = Category.CategoryID.ToString();
                txtCategoryName.Text = Category.CategoryName;
                txtDescription.Text = Category.Description;

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (Category != null)
            {
            }
            else
            {
                Category = new CategoryDto
                {
                    CategoryName = txtCategoryName.Text,
                    Description = txtDescription.Text
                };
                categoryServices.AddCategory(Category);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
