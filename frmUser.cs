using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectApp.Models.DataLayer;

namespace ProjectApp
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }


        private bool isValid()
        {
            bool result = true;
            string err = "";

            err += Validator.IsPresent(txtID.Text, txtID.Tag.ToString());
            err += Validator.IsPresent(txtFName.Text, txtFName.Tag.ToString());
            err += Validator.IsPresent(txtLName.Text, txtLName.Tag.ToString());
            err += Validator.IsValidSelection(cBoxJob.SelectedIndex, cBoxJob.Tag.ToString());

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            using var db = new IMSContext();

            var users = db.Users
                             .OrderBy(i => i.Firstname)
                             .ToList();

            dgViewUsers.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    string passwwd = "password123";
                    string jobTitle = cBoxJob.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private bool isValidSearch()
        {
            bool result = true;
            string err = "";

            err += Validator.IsPresent(txtSearch.Text, txtSearch.Tag.ToString());

            if (err != "")
            {
                result = false;
                MessageBox.Show(err, "Invalid Entry");
            }
            return result;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidSearch())
                {
                    string target = txtSearch.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }
    }
}
