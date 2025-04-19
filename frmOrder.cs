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

namespace ProjectApp
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\IMSdb.mdf;Integrated Security=True";

        private bool isValid()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtNum.Text, txtNum.Tag.ToString());
            errorMessage += Validator.IsPresent(txtDate.Text, txtDate.Tag.ToString());
            errorMessage += Validator.IsPresent(txtType.Text, txtType.Tag.ToString());
            errorMessage += Validator.IsPresent(txtID.Text, txtID.Tag.ToString());
            errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    int orderNo = Convert.ToInt32(txtNum.Text);
                    DateTime orderDate = Convert.ToDateTime(txtDate.Text);
                    string orderType = txtType.Text;
                    string orderStatus = "Pending";
                    int itemID = Convert.ToInt32(txtID.Text);
                    string itemName = txtName.Text;

                    using SqlConnection connection = new SqlConnection(connectionString);

                    string sql
                        = "INSERT INTO Orders (OrderNo, OrderDate, OrderType, OrderStatus, ItemID, ItemName) "
                        + "VALUES (@orderno, @orderdate, @ordertype, @orderstatus, @itemid, @itemname)";

                    using SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@orderno", orderNo);
                    command.Parameters.AddWithValue("@orderdate", orderDate);
                    command.Parameters.AddWithValue("@ordertype", orderType);
                    command.Parameters.AddWithValue("@orderstatus", orderStatus);
                    command.Parameters.AddWithValue("@itemid", itemID);
                    command.Parameters.AddWithValue("@itemname", itemName);
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Order Created!");
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
