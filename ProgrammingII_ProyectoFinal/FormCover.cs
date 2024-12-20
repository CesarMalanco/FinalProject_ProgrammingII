using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinalProject
{
    public partial class FormCover : Form
    {
        public FormCover()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FormLoginPage loginPage = new FormLoginPage();  // Create instance for login page
            this.Hide(); // Hide cover
            loginPage.ShowDialog(); // Show login page
        }
    }
}
