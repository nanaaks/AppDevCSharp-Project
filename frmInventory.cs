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
                int threshold = Convert.ToInt32(txtThreshold.Text);
                MessageBox.Show("Reorder Threshold Updated!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    int searchby = cBoxSearch.SelectedIndex;

                    switch (searchby)
                    {
                        //Search by Item ID
                        case 0:
                            int itemID = Convert.ToInt32(txtSearch.Text);
                            break;

                        //Search by Item Name
                        case 1:
                            string itemName = txtSearch.Text;
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
    }
}
