namespace ProjectApp
{
    partial class frmOrder
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
            txtType = new TextBox();
            label8 = new Label();
            txtDate = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            btnClear = new Button();
            btnConfirm = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtNum = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtType
            // 
            txtType.Anchor = AnchorStyles.None;
            txtType.Location = new Point(120, 124);
            txtType.Name = "txtType";
            txtType.Size = new Size(110, 23);
            txtType.TabIndex = 38;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(39, 127);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 37;
            label8.Text = "Order Type:";
            // 
            // txtDate
            // 
            txtDate.Anchor = AnchorStyles.None;
            txtDate.Location = new Point(120, 73);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(110, 23);
            txtDate.TabIndex = 36;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(39, 76);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 35;
            label7.Text = "Order Date:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(208, 270);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.Location = new Point(120, 270);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(32, 270);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(82, 22);
            btnConfirm.TabIndex = 32;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.Location = new Point(120, 175);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(110, 23);
            txtID.TabIndex = 30;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(120, 226);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 28;
            // 
            // txtNum
            // 
            txtNum.Anchor = AnchorStyles.None;
            txtNum.Location = new Point(120, 25);
            txtNum.Margin = new Padding(3, 2, 3, 2);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(110, 23);
            txtNum.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(39, 178);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 24;
            label4.Text = "Item ID:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(39, 229);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 23;
            label2.Text = "Item Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 22;
            label1.Text = "Order No:";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 307);
            Controls.Add(txtType);
            Controls.Add(label8);
            Controls.Add(txtDate);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtNum);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrder";
            Text = "Enter Order Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox6;
        private Button button4;
        private TextBox txtType;
        private Label label8;
        private TextBox txtDate;
        private Label label7;
        private Button btnCancel;
        private Button btnClear;
        private Button btnConfirm;
        private TextBox textBox5;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtNum;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}