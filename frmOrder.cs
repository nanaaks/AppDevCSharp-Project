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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        string status = "Pending";

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Created!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtDate.Clear();
            txtType.Clear();
            txtID.Clear();
            txtName.Clear();
        }
    }
}
