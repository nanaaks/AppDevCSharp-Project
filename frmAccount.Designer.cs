namespace ProjectApp
{
    partial class frmAccount
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
            btnConfirm = new Button();
            txtPwdCurrent = new TextBox();
            txtPwdNew = new TextBox();
            label3 = new Label();
            txtPwdReentry = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(47, 61);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Current Password:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(61, 112);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "New Password:";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Location = new Point(47, 216);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtPwdCurrent
            // 
            txtPwdCurrent.Anchor = AnchorStyles.None;
            txtPwdCurrent.Location = new Point(154, 58);
            txtPwdCurrent.Name = "txtPwdCurrent";
            txtPwdCurrent.Size = new Size(100, 23);
            txtPwdCurrent.TabIndex = 3;
            txtPwdCurrent.Tag = "Current Password";
            // 
            // txtPwdNew
            // 
            txtPwdNew.Anchor = AnchorStyles.None;
            txtPwdNew.Location = new Point(154, 109);
            txtPwdNew.Name = "txtPwdNew";
            txtPwdNew.Size = new Size(100, 23);
            txtPwdNew.TabIndex = 4;
            txtPwdNew.Tag = "New Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(45, 165);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Reenter Password:";
            // 
            // txtPwdReentry
            // 
            txtPwdReentry.Anchor = AnchorStyles.None;
            txtPwdReentry.Location = new Point(154, 162);
            txtPwdReentry.Name = "txtPwdReentry";
            txtPwdReentry.Size = new Size(100, 23);
            txtPwdReentry.TabIndex = 6;
            txtPwdReentry.Tag = "Reenter Password";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(179, 216);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 270);
            Controls.Add(btnCancel);
            Controls.Add(txtPwdReentry);
            Controls.Add(label3);
            Controls.Add(txtPwdNew);
            Controls.Add(txtPwdCurrent);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAccount";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnConfirm;
        private TextBox txtPwdCurrent;
        private TextBox txtPwdNew;
        private Label label3;
        private TextBox txtPwdReentry;
        private Button btnCancel;
    }
}