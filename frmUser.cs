using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectApp.Models.DataLayer;

namespace ProjectApp
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\IMSdb.mdf;Integrated Security=True";

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
                    string userID = txtID.Text;
                    string passwd = "password123";
                    string fname = txtFName.Text;
                    string lname = txtLName.Text;
                    string jobTitle = cBoxJob.SelectedItem.ToString();

                    using SqlConnection connection = new SqlConnection(connectionString);

                    string sql
                        = "INSERT INTO Users (UserId, Password, Firstname, Lastname, Job) "
                        + "VALUES (@UserId, @Password, @Fname, @Lname, @Job)";

                    using SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@UserId", userID);
                    command.Parameters.AddWithValue("@Password", passwd);
                    command.Parameters.AddWithValue("@Fname", fname);
                    command.Parameters.AddWithValue("@Lname", lname);
                    command.Parameters.AddWithValue("@Job", jobTitle);
                    connection.Open();
                    command.ExecuteNonQuery();
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
                    using var db = new IMSContext();
                    string target = txtSearch.Text.ToLower();

                    var results = db.Users
                        .Where(u => u.UserId.ToLower().Contains(target))
                        .ToList();

                    dgViewUsers.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = dgViewUsers.SelectedRows[0];
            string userID = selectedRow.Cells["UserId"].Value.ToString();
            using var db = new IMSContext();
            var user = db.Users.FirstOrDefault(u => u.UserId.Equals(userID));
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                MessageBox.Show("User Removed!");
            }
        }
    }
}
