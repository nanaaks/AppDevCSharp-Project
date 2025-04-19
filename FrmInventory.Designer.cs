namespace ProjectApp
{
    partial class frmInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnRemove = new Button();
            btnExit = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            btnSearch = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            btnShow = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            dgViewItems = new DataGridView();
            cBoxSearch = new ComboBox();
            txtThreshold = new TextBox();
            btnThreshold = new Button();
            label1 = new Label();
            txtID = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewItems).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Location = new Point(687, 480);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 22);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Location = new Point(782, 481);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(89, 22);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Location = new Point(798, 536);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(73, 22);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(17, 34);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Total:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Location = new Point(672, 58);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(121, 23);
            txtSearch.TabIndex = 7;
            txtSearch.Tag = "Search";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(129, 34);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 8;
            label3.Text = "Low Stock:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(199, 31);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 23);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(672, 12);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 10;
            label4.Text = "Search By:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(59, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 23);
            textBox3.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Location = new Point(796, 57);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(6, 22);
            button3.Name = "button3";
            button3.Size = new Size(76, 23);
            button3.TabIndex = 14;
            button3.Text = "Expired";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(97, 22);
            button4.Name = "button4";
            button4.Size = new Size(76, 23);
            button4.TabIndex = 16;
            button4.Text = "Low Stock";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 54);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter By";
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.None;
            btnShow.Location = new Point(29, 481);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(89, 23);
            btnShow.TabIndex = 18;
            btnShow.Text = "Show Items";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(275, 34);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 19;
            label5.Text = "Expired:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Control;
            textBox4.Location = new Point(329, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(48, 23);
            textBox4.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(242, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 69);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Overview";
            // 
            // dgViewItems
            // 
            dgViewItems.Anchor = AnchorStyles.None;
            dgViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewItems.Location = new Point(29, 86);
            dgViewItems.Name = "dgViewItems";
            dgViewItems.Size = new Size(842, 388);
            dgViewItems.TabIndex = 25;
            // 
            // cBoxSearch
            // 
            cBoxSearch.Anchor = AnchorStyles.None;
            cBoxSearch.FormattingEnabled = true;
            cBoxSearch.Items.AddRange(new object[] { "Item No", "Item Name" });
            cBoxSearch.Location = new Point(672, 30);
            cBoxSearch.Name = "cBoxSearch";
            cBoxSearch.Size = new Size(121, 23);
            cBoxSearch.TabIndex = 26;
            cBoxSearch.Tag = "Search Criteria";
            // 
            // txtThreshold
            // 
            txtThreshold.Anchor = AnchorStyles.None;
            txtThreshold.Location = new Point(395, 507);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(100, 23);
            txtThreshold.TabIndex = 28;
            txtThreshold.Tag = "New Threshold";
            // 
            // btnThreshold
            // 
            btnThreshold.Anchor = AnchorStyles.None;
            btnThreshold.Location = new Point(395, 536);
            btnThreshold.Name = "btnThreshold";
            btnThreshold.Size = new Size(138, 23);
            btnThreshold.TabIndex = 29;
            btnThreshold.Text = "Set Reorder Threshold";
            btnThreshold.UseVisualStyleBackColor = true;
            btnThreshold.Click += btnThreshold_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(341, 485);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 30;
            label1.Text = "Item ID:";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Location = new Point(395, 481);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 31;
            txtID.Tag = "Item ID";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(299, 510);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 32;
            label6.Tag = "";
            label6.Text = "New Threshold:";
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 569);
            Controls.Add(label6);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnThreshold);
            Controls.Add(txtThreshold);
            Controls.Add(cBoxSearch);
            Controls.Add(dgViewItems);
            Controls.Add(groupBox2);
            Controls.Add(btnShow);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(btnExit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInventory";
            Text = "Inventory Management";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private Button btnExit;
        private Label label2;
        private TextBox txtSearch;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button btnSearch;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Button btnShow;
        private Label label5;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private DataGridView dgViewItems;
        private ComboBox cBoxSearch;
        private TextBox txtThreshold;
        private Button btnThreshold;
        private Label label1;
        private TextBox txtID;
        private Label label6;
    }
}
