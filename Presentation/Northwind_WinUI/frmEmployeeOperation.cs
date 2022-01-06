using Northwind_BusinessLayer.Dtos;
using Northwind_BusinessLayer.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmEmployeeOperation : Form
    {
        public frmEmployeeOperation()
        {
            InitializeComponent();
        }

        EmployeeServices employeeServices = new EmployeeServices();
        public EmployeeDto Employee { get; set; }

        private void frmEmployeeOperation_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Enabled = false;
            var reportsTo = employeeServices.GetAllEmployees().Employees.Select(x => x.ReportsTo).Distinct();

            cmbReportsTo.DataSource = employeeServices.GetAllEmployees().Employees.Where(x => reportsTo.Contains(x.EmployeeID)).Select(s => new { EmployeeID = s.EmployeeID, FullName = s.FirstName + " " + s.LastName }).ToList();

            cmbReportsTo.ValueMember = "EmployeeID";
            cmbReportsTo.DisplayMember = "FullName";
            if (Employee != null)
            {
                if (Employee.ReportsTo.HasValue)
                {
                    cmbReportsTo.SelectedValue = Employee.ReportsTo.Value;
                }
                txtEmployeeID.Text = Employee.EmployeeID.ToString();
                txtFirstName.Text = Employee.FirstName;
                txtLastName.Text = Employee.LastName;
                txtTitle.Text = Employee.Title;
                dtBirthDate.Value = Employee.BirthDate.Value;
                dtHireDate.Value = Employee.HireDate.Value;
                txtAdres.Text = Employee.Address;
                txtCity.Text = Employee.City;
                txtRegion.Text = Employee.Region;
                txtPostalCode.Text = Employee.PostalCode;
                txtCountry.Text = Employee.Country;
                txtHomePhone.Text = Employee.HomePhone;
                txtExtension.Text = Employee.Extension;
                txtNotes.Text = Employee.Notes;

                btnKaydetGuncelle.Text = "Güncelle";
            }
            else
                btnKaydetGuncelle.Text = "Kaydet";
        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if(Employee != null)
            { }
            else
            {
                Employee = new EmployeeDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtBirthDate.Value,
                    HireDate = dtHireDate.Value,
                    Address = txtAdres.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Extension = txtExtension.Text,
                    HomePhone = txtHomePhone.Text,
                    Notes = txtNotes.Text,
                    PostalCode = txtPostalCode.Text,
                    Region = txtRegion.Text,
                    ReportsTo = cmbReportsTo.SelectedValue != null ? int.Parse(cmbReportsTo.SelectedValue.ToString()) : new int?(),
                    Title = txtTitle.Text
                };

                employeeServices.AddEmployee(Employee);
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
