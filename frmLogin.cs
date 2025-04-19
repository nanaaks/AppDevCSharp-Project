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
using System.Configuration;


namespace ProjectApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string userName = "";
        public static string userRole = "";

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\IMSdb.mdf;Integrated Security=True";

        private bool isValid()
        {
            bool result = true;
            string err = "";

            err += Validator.IsPresent(txtUser.Text, txtUser.Tag.ToString());
            err += Validator.IsPresent(txtPass.Text, txtPass.Tag.ToString());

            if (err != "")
            {
                result = false;
                MessageBox.Show(err, "Invalid Entry");
            }
                return result;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    string userid = txtUser.Text;
                    string password = txtPass.Text;

                    using SqlConnection connection = new SqlConnection(connectionString);

                    string query
                        = "SELECT Firstname, Job "
                        + "FROM Users "
                        + "WHERE UserId = @userid "
                        + "AND Password = @password";

                    using SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userid", userid);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                    if (reader.Read())
                    {
                        userName = reader["Firstname"].ToString();
                        userRole = reader["Job"].ToString();
                        MessageBox.Show("Login Successful!");
                        var newForm = new frmMain();
                        newForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtUser.Clear();
                        txtPass.Clear();
                        MessageBox.Show("Incorrect Username/Password");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
