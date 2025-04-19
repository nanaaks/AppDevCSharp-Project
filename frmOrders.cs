using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using ProjectApp.Models.DataLayer;

namespace ProjectApp
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        string userRole = frmLogin.userRole;

        private bool isValid()
        {
            bool result = true;
            string err = "";
            err += Validator.IsValidSelection(cBoxSearch.SelectedIndex, cBoxSearch.Tag.ToString());
            err += Validator.IsPresent(txtSearch.Text, txtSearch.Tag.ToString());

            if (err != "")
            {
                result = false;
                MessageBox.Show(err, "Invalid Entry");
            }
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var newForm = new frmMain();
            newForm.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using var db = new IMSContext();

            var orders = db.Orders
                             .OrderBy(o => o.OrderDate)
                             .ToList();

            dgViewOrders.DataSource = orders;
            dgViewOrders.Columns["Item"].Visible = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newForm = new frmOrder();
            newForm.Show();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (userRole.Equals("Junior Associate"))
            {
                MessageBox.Show("Access Denied!\nNotify Senior Associate or Manager!");
            }
            else
            {
                MessageBox.Show("Order Approved!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (userRole.Equals("Junior Associate"))
            {
                MessageBox.Show("Access Denied!\nNotify Senior Associate or Manager!");
            }
            else
            {
                MessageBox.Show("Order Canceled!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    using var db = new IMSContext();
                    int searchby = cBoxSearch.SelectedIndex;

                    switch (searchby)
                    {
                        //Search by Order No
                        case 0:
                            int orderNo = Convert.ToInt32(txtSearch.Text);

                            var numResults = db.Orders
                                .Where(o => o.OrderNo == orderNo)
                                .ToList();

                            dgViewOrders.DataSource = numResults;
                            break;

                        //Search by Order Date
                        case 1:
                            DateTime orderDate = Convert.ToDateTime(txtSearch.Text);

                            var dateResults = db.Orders
                                .Where(o => o.OrderDate == orderDate)
                                .ToList();

                            dgViewOrders.DataSource = dateResults;
                            break;

                        //Search by Item ID
                        case 2:
                            int itemID = Convert.ToInt32(txtSearch.Text);

                            var idResults = db.Orders
                                .Where(o => o.ItemId == itemID)
                                .ToList();

                            dgViewOrders.DataSource = idResults;
                            break;

                        //Search by Item Name
                        case 3:
                            string itemName = txtSearch.Text.ToLower();

                            var nameResults = db.Orders
                                .Where(o => o.ItemName.ToLower().Contains(itemName))
                                .ToList();

                            dgViewOrders.DataSource = nameResults;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void rbtnRestock_CheckedChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
