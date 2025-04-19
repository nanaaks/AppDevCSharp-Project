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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\IMSdb.mdf;Integrated Security=True";

        private bool isValid()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtItemNo.Text, txtItemNo.Tag.ToString());
            errorMessage += Validator.IsPresent(txtItemName.Text, txtItemName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtCategory.Text, txtCategory.Tag.ToString());
            errorMessage += Validator.IsPresent(txtPrice.Text, txtPrice.Tag.ToString());
            errorMessage += Validator.IsPresent(txtQuantity.Text, txtQuantity.Tag.ToString());
            errorMessage += Validator.IsPresent(txtExDate.Text, txtExDate.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNo.Clear();
            txtItemName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtExDate.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    int itemID = Convert.ToInt32(txtItemNo.Text);
                    string itemName = txtItemName.Text;
                    string category = txtCategory.Text;
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    DateTime expiry = Convert.ToDateTime(txtExDate.Text);
                    int threshold = (int)(quantity * 0.3);
                    string stocklvl = "Nominal";

                    using SqlConnection connection = new SqlConnection(connectionString);

                    string sql
                        = "INSERT INTO Items (ItemID, ItemName, Category, Quantity, Price, ExpiryDate, Threshold, StockLvl) "
                        + "VALUES (@itemid, @itemname, @category, @quantity, @price, @expiry, @threshold, @stocklvl)";

                    using SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@itemid", itemID);
                    command.Parameters.AddWithValue("@itemname", itemName);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@expiry", expiry);
                    command.Parameters.AddWithValue("@threshold", threshold);
                    command.Parameters.AddWithValue("@stocklvl", stocklvl);
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
    }
}
