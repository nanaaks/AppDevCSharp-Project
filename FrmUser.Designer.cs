namespace ProjectApp
{
    partial class frmUser
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
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            label3 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnExit = new Button();
            btnShow = new Button();
            btnReset = new Button();
            txtID = new TextBox();
            label4 = new Label();
            dgViewUsers = new DataGridView();
            label5 = new Label();
            cBoxJob = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Location = new Point(614, 241);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Location = new Point(776, 241);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.Location = new Point(695, 241);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(614, 109);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(615, 151);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // txtFName
            // 
            txtFName.Anchor = AnchorStyles.None;
            txtFName.Location = new Point(681, 106);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(171, 23);
            txtFName.TabIndex = 6;
            txtFName.Tag = "First Name";
            // 
            // txtLName
            // 
            txtLName.Anchor = AnchorStyles.None;
            txtLName.Location = new Point(681, 148);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(171, 23);
            txtLName.TabIndex = 7;
            txtLName.Tag = "Last Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(628, 67);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "User ID:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Location = new Point(122, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 23);
            txtSearch.TabIndex = 9;
            txtSearch.Tag = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Location = new Point(292, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Tag = "";
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Location = new Point(777, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.None;
            btnShow.Location = new Point(41, 361);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(92, 23);
            btnShow.TabIndex = 13;
            btnShow.Text = "Show All Users";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.Location = new Point(755, 294);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 23);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset Password";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Location = new Point(681, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 23);
            txtID.TabIndex = 16;
            txtID.Tag = "User ID";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(41, 42);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 17;
            label4.Text = "Search by ID:";
            // 
            // dgViewUsers
            // 
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new Point(41, 67);
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.Size = new Size(543, 290);
            dgViewUsers.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(621, 196);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 19;
            label5.Text = "Job Title:";
            // 
            // cBoxJob
            // 
            cBoxJob.Anchor = AnchorStyles.None;
            cBoxJob.FormattingEnabled = true;
            cBoxJob.Items.AddRange(new object[] { "Manager", "Senior Associate", "Junior Associate" });
            cBoxJob.Location = new Point(681, 193);
            cBoxJob.Name = "cBoxJob";
            cBoxJob.Size = new Size(170, 23);
            cBoxJob.TabIndex = 20;
            cBoxJob.Tag = "Job Title";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 404);
            Controls.Add(cBoxJob);
            Controls.Add(label5);
            Controls.Add(dgViewUsers);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(btnReset);
            Controls.Add(btnShow);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "frmUser";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private TextBox txtFName;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnExit;
        private Button btnShow;
        private Button btnReset;
        private TextBox txtID;
        private Label label4;
        private DataGridView dgViewUsers;
        private Label label5;
        private ComboBox cBoxJob;
    }
}