namespace ProjectApp
{
    partial class frmItem
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtItemNo = new TextBox();
            txtItemName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnConfirm = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            label7 = new Label();
            txtExDate = new TextBox();
            label8 = new Label();
            txtCategory = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(82, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Item No:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(67, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Item Name:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(71, 170);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Unit Price:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(76, 223);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity:";
            // 
            // txtItemNo
            // 
            txtItemNo.Anchor = AnchorStyles.None;
            txtItemNo.Location = new Point(141, 31);
            txtItemNo.Margin = new Padding(3, 2, 3, 2);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(110, 23);
            txtItemNo.TabIndex = 6;
            txtItemNo.Tag = "Item Number";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.None;
            txtItemName.Location = new Point(141, 76);
            txtItemName.Margin = new Padding(3, 2, 3, 2);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(110, 23);
            txtItemName.TabIndex = 7;
            txtItemName.Tag = "Item Name";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.None;
            txtQuantity.Location = new Point(141, 215);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 8;
            txtQuantity.Tag = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.Location = new Point(141, 167);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 9;
            txtPrice.Tag = "Unit Price";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(37, 318);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(82, 22);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.Location = new Point(125, 318);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(213, 318);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(67, 269);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 15;
            label7.Text = "Expiry Date:";
            // 
            // txtExDate
            // 
            txtExDate.Anchor = AnchorStyles.None;
            txtExDate.Location = new Point(141, 266);
            txtExDate.Name = "txtExDate";
            txtExDate.Size = new Size(110, 23);
            txtExDate.TabIndex = 16;
            txtExDate.Tag = "Expiry Date";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(74, 122);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 17;
            label8.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.None;
            txtCategory.Location = new Point(141, 119);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(110, 23);
            txtCategory.TabIndex = 18;
            txtCategory.Tag = "Category";
            // 
            // frmItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 351);
            Controls.Add(txtCategory);
            Controls.Add(label8);
            Controls.Add(txtExDate);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(txtItemNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmItem";
            Text = "Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtItemNo;
        private TextBox txtItemName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnConfirm;
        private Button btnClear;
        private Button btnCancel;
        private Label label7;
        private TextBox txtExDate;
        private Label label8;
        private TextBox txtCategory;
    }
}