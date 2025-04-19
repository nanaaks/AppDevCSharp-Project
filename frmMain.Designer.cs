namespace ProjectApp
{
    partial class frmMain
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
            btnIM = new Button();
            btnLogout = new Button();
            lblUser = new Label();
            btnAM = new Button();
            btnOM = new Button();
            btnUM = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(228, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Logged in as:";
            // 
            // btnIM
            // 
            btnIM.Anchor = AnchorStyles.None;
            btnIM.Location = new Point(57, 128);
            btnIM.Name = "btnIM";
            btnIM.Size = new Size(194, 30);
            btnIM.TabIndex = 1;
            btnIM.Text = "Inventory Management";
            btnIM.UseVisualStyleBackColor = true;
            btnIM.Click += btnIM_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.Location = new Point(294, 327);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.None;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(309, 23);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 15);
            lblUser.TabIndex = 5;
            lblUser.Text = "Username";
            // 
            // btnAM
            // 
            btnAM.Anchor = AnchorStyles.None;
            btnAM.Location = new Point(228, 41);
            btnAM.Name = "btnAM";
            btnAM.Size = new Size(141, 30);
            btnAM.TabIndex = 6;
            btnAM.Text = "Account Management";
            btnAM.UseVisualStyleBackColor = true;
            btnAM.Click += btnAM_Click;
            // 
            // btnOM
            // 
            btnOM.Anchor = AnchorStyles.None;
            btnOM.Location = new Point(57, 204);
            btnOM.Name = "btnOM";
            btnOM.Size = new Size(194, 30);
            btnOM.TabIndex = 7;
            btnOM.Text = "Order Management";
            btnOM.UseVisualStyleBackColor = true;
            btnOM.Click += btnOM_Click;
            // 
            // btnUM
            // 
            btnUM.Anchor = AnchorStyles.None;
            btnUM.Location = new Point(57, 281);
            btnUM.Name = "btnUM";
            btnUM.Size = new Size(194, 30);
            btnUM.TabIndex = 8;
            btnUM.Text = "User Management";
            btnUM.UseVisualStyleBackColor = true;
            btnUM.Click += btnUM_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 9;
            label3.Text = "Manage inventory and items";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 10;
            label4.Text = "Create and track orders";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 11;
            label5.Text = "Support and manage users";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 378);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnUM);
            Controls.Add(btnOM);
            Controls.Add(btnAM);
            Controls.Add(lblUser);
            Controls.Add(btnLogout);
            Controls.Add(btnIM);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "Main Menu";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIM;
        private Button btnLogout;
        private Label lblUser;
        private Button btnAM;
        private Button btnOM;
        private Button btnUM;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}