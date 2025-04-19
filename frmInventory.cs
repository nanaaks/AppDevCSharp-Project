using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using ProjectApp.Models.DataLayer;

namespace ProjectApp
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        string userRole = frmLogin.userRole;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\IMSdb.mdf;Integrated Security=True";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newForm = new frmItem();
            newForm.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using var db = new IMSContext();

            var items = db.Items
                             .OrderBy(i => i.ItemName)
                             .ToList();

            dgViewItems.DataSource = items;
            dgViewItems.Columns["Orders"].Visible = false;
        }

        private bool isValidThreshold()
        {
            bool result = true;
            string err = "";
            err += Validator.IsPresent(txtThreshold.Text, txtThreshold.Tag.ToString());
            err += Validator.IsInt32(txtThreshold.Text, txtThreshold.Tag.ToString());
            err += Validator.IsPresent(txtID.Text, txtID.Tag.ToString());
            err += Validator.IsInt32(txtID.Text, txtID.Tag.ToString());

            if (err != "")
            {
                result = false;
                MessageBox.Show(err, "Invalid Entry");
            }
            return result;
        }

        private void btnThreshold_Click(object sender, EventArgs e)
        {
            if (userRole.Equals("Junior Associate"))
            {
                MessageBox.Show("Access Denied!\nNotify Senior Associate or Manager!");
            }
            else if (isValidThreshold())
            {
                int itemID = Convert.ToInt32(txtID.Text);
                int threshold = Convert.ToInt32(txtThreshold.Text);

                using SqlConnection connection = new SqlConnection(connectionString);

                string sql = "UPDATE Items SET Threshold = @threshold WHERE ItemID = @itemid";

                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@threshold", threshold);
                command.Parameters.AddWithValue("@itemid", itemID);
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Reorder Threshold Updated!");
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
                        //Search by Item ID
                        case 0:
                            int itemID = Convert.ToInt32(txtSearch.Text);

                            var idResults = db.Items
                                .Where(i => i.ItemId == itemID)
                                .ToList();

                            dgViewItems.DataSource = idResults;
                            break;

                        //Search by Item Name
                        case 1:
                            string itemName = txtSearch.Text.ToLower();

                            var nameResults = db.Items
                                .Where(i => i.ItemName.ToLower().Contains(itemName))
                                .ToList();

                            dgViewItems.DataSource = nameResults;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = dgViewItems.SelectedRows[0];
            int itemID = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);
            using var db = new IMSContext();
            var item = db.Items.FirstOrDefault(i => i.ItemId == itemID);
            if (item != null)
            {
                db.Items.Remove(item);
                db.SaveChanges();
                MessageBox.Show("Item Removed!");
            }
        }
    }
}
