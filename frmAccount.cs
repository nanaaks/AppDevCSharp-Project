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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            bool result = true;
            string err = "";

            err += Validator.IsPresent(txtPwdCurrent.Text, txtPwdCurrent.Tag.ToString());
            err += Validator.IsPresent(txtPwdNew.Text, txtPwdNew.Tag.ToString());
            err += Validator.IsPresent(txtPwdReentry.Text, txtPwdReentry.Tag.ToString());

            if (err != "")
            {
                result = false;
                MessageBox.Show(err, "Invalid Entry");
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    string oldpasswd = txtPwdCurrent.Text;
                    string newpasswd = txtPwdNew.Text;

                    // Check if password is correct
                    //TODO

                    // Check if New Password and Reenter Password match
                    if (!(newpasswd.Equals(txtPwdReentry.Text)))
                    {
                        throw new Exception("New Password and Reenter Password must match!");
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
    }
}
