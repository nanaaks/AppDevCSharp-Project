namespace ProjectApp
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            btnApprove = new Button();
            btnExit = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            gBoxFilter = new GroupBox();
            rbtnApproved = new RadioButton();
            rbtnCanceled = new RadioButton();
            rbtnNew = new RadioButton();
            rbtnDelivery = new RadioButton();
            rbtnRestock = new RadioButton();
            label6 = new Label();
            btnView = new Button();
            dgViewOrders = new DataGridView();
            btnCancel = new Button();
            cBoxSearch = new ComboBox();
            gBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewOrders).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.Location = new Point(244, 527);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(85, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Order";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnApprove
            // 
            btnApprove.Anchor = AnchorStyles.None;
            btnApprove.Location = new Point(406, 527);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(96, 23);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve Order";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Location = new Point(589, 581);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(441, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(142, 23);
            txtSearch.TabIndex = 15;
            txtSearch.Tag = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(589, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // gBoxFilter
            // 
            gBoxFilter.Anchor = AnchorStyles.None;
            gBoxFilter.Controls.Add(rbtnApproved);
            gBoxFilter.Controls.Add(rbtnCanceled);
            gBoxFilter.Controls.Add(rbtnNew);
            gBoxFilter.Controls.Add(rbtnDelivery);
            gBoxFilter.Controls.Add(rbtnRestock);
            gBoxFilter.Location = new Point(22, 12);
            gBoxFilter.Name = "gBoxFilter";
            gBoxFilter.Size = new Size(393, 51);
            gBoxFilter.TabIndex = 17;
            gBoxFilter.TabStop = false;
            gBoxFilter.Text = "Filter by type of order or order status";
            // 
            // rbtnApproved
            // 
            rbtnApproved.AutoSize = true;
            rbtnApproved.Location = new Point(313, 22);
            rbtnApproved.Name = "rbtnApproved";
            rbtnApproved.Size = new Size(77, 19);
            rbtnApproved.TabIndex = 32;
            rbtnApproved.TabStop = true;
            rbtnApproved.Text = "Approved";
            rbtnApproved.UseVisualStyleBackColor = true;
            // 
            // rbtnCanceled
            // 
            rbtnCanceled.AutoSize = true;
            rbtnCanceled.Location = new Point(233, 22);
            rbtnCanceled.Name = "rbtnCanceled";
            rbtnCanceled.Size = new Size(74, 19);
            rbtnCanceled.TabIndex = 31;
            rbtnCanceled.TabStop = true;
            rbtnCanceled.Text = "Canceled";
            rbtnCanceled.UseVisualStyleBackColor = true;
            // 
            // rbtnNew
            // 
            rbtnNew.AutoSize = true;
            rbtnNew.Location = new Point(151, 22);
            rbtnNew.Name = "rbtnNew";
            rbtnNew.Size = new Size(76, 19);
            rbtnNew.TabIndex = 30;
            rbtnNew.TabStop = true;
            rbtnNew.Text = "New Item";
            rbtnNew.UseVisualStyleBackColor = true;
            // 
            // rbtnDelivery
            // 
            rbtnDelivery.AutoSize = true;
            rbtnDelivery.Location = new Point(78, 22);
            rbtnDelivery.Name = "rbtnDelivery";
            rbtnDelivery.Size = new Size(67, 19);
            rbtnDelivery.TabIndex = 29;
            rbtnDelivery.TabStop = true;
            rbtnDelivery.Text = "Delivery";
            rbtnDelivery.UseVisualStyleBackColor = true;
            // 
            // rbtnRestock
            // 
            rbtnRestock.AutoSize = true;
            rbtnRestock.Location = new Point(6, 22);
            rbtnRestock.Name = "rbtnRestock";
            rbtnRestock.Size = new Size(66, 19);
            rbtnRestock.TabIndex = 28;
            rbtnRestock.TabStop = true;
            rbtnRestock.Text = "Restock";
            rbtnRestock.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 12);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 18;
            label6.Text = "Search By:";
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.None;
            btnView.Location = new Point(22, 527);
            btnView.Name = "btnView";
            btnView.Size = new Size(149, 23);
            btnView.TabIndex = 18;
            btnView.Text = "View Order History";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dgViewOrders
            // 
            dgViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewOrders.Location = new Point(22, 87);
            dgViewOrders.Name = "dgViewOrders";
            dgViewOrders.Size = new Size(642, 434);
            dgViewOrders.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(568, 527);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel Order";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cBoxSearch
            // 
            cBoxSearch.FormattingEnabled = true;
            cBoxSearch.Items.AddRange(new object[] { "Order No", "Order Date", "Item ID", "Item Name" });
            cBoxSearch.Location = new Point(441, 30);
            cBoxSearch.Name = "cBoxSearch";
            cBoxSearch.Size = new Size(140, 23);
            cBoxSearch.TabIndex = 21;
            cBoxSearch.Tag = "Search Criteria";
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 625);
            Controls.Add(cBoxSearch);
            Controls.Add(btnCancel);
            Controls.Add(dgViewOrders);
            Controls.Add(btnView);
            Controls.Add(gBoxFilter);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnApprove);
            Controls.Add(btnCreate);
            Name = "frmOrders";
            Text = "Orders";
            gBoxFilter.ResumeLayout(false);
            gBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnApprove;
        private Button btnExit;
        private TextBox txtSearch;
        private Button btnSearch;
        private GroupBox gBoxFilter;
        private Label label6;
        private RadioButton rbtnApproved;
        private RadioButton rbtnCanceled;
        private RadioButton rbtnNew;
        private RadioButton rbtnDelivery;
        private RadioButton rbtnRestock;
        private Button btnView;
        private DataGridView dgViewOrders;
        private Button btnCancel;
        private ComboBox cBoxSearch;
    }
}