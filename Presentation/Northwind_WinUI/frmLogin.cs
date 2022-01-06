using System;
using System.Windows.Forms;

namespace Northwind_WinUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }
    }
}
