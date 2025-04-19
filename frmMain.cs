using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string userRole = frmLogin.userRole;

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = frmLogin.userName;
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            var newForm = new frmInventory();
            newForm.Show();
            this.Close();
        }

        private void btnOM_Click(object sender, EventArgs e)
        {
            var newForm = new frmOrders();
            newForm.Show();
            this.Close();
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            if (!userRole.Equals("Manager"))
            {
                MessageBox.Show("Access Denied!\nOnly Managers can access user info!");
            }
            else
            {
                var newForm = new frmUser();
                newForm.Show();
                this.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var newForm = new frmLogin();
            newForm.Show();
            this.Close();
        }

        private void btnAM_Click(object sender, EventArgs e)
        {
            var newForm = new frmAccount();
            newForm.Show();
            this.Close();
        }
    }
}
