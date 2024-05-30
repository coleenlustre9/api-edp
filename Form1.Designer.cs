namespace api_act8_lustre
{
    partial class Form1
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
            panel1 = new Panel();
            label9 = new Label();
            btnGetAccounts = new Button();
            dataGridView1 = new DataGridView();
            btnPostAccount = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPostUser = new Button();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            txtUserUsername = new TextBox();
            txtUserNamee = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnGetUsers = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnGetAccounts);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnPostAccount);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 371);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(313, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 28);
            label9.TabIndex = 13;
            label9.Text = "ACCOUNTS";
            // 
            // btnGetAccounts
            // 
            btnGetAccounts.Location = new Point(387, 300);
            btnGetAccounts.Name = "btnGetAccounts";
            btnGetAccounts.Size = new Size(337, 47);
            btnGetAccounts.TabIndex = 11;
            btnGetAccounts.Text = "GET ACCOUNTS";
            btnGetAccounts.UseVisualStyleBackColor = true;
            btnGetAccounts.Click += btnGetAccounts_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(337, 221);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPostAccount
            // 
            btnPostAccount.Location = new Point(20, 300);
            btnPostAccount.Name = "btnPostAccount";
            btnPostAccount.Size = new Size(340, 47);
            btnPostAccount.TabIndex = 10;
            btnPostAccount.Text = "POST ACCOUNT";
            btnPostAccount.UseVisualStyleBackColor = true;
            btnPostAccount.Click += btnPostAccount_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 245);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(124, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(236, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 27);
            txtName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(124, 51);
            txtId.Name = "txtId";
            txtId.Size = new Size(236, 27);
            txtId.TabIndex = 5;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 245);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 192);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 144);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 51);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // btnPostUser
            // 
            btnPostUser.Location = new Point(20, 188);
            btnPostUser.Name = "btnPostUser";
            btnPostUser.Size = new Size(340, 47);
            btnPostUser.TabIndex = 11;
            btnPostUser.Text = "POST USER";
            btnPostUser.UseVisualStyleBackColor = true;
            btnPostUser.Click += btnPostUser_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(txtUserUsername);
            panel2.Controls.Add(txtUserNamee);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnGetUsers);
            panel2.Controls.Add(btnPostUser);
            panel2.Location = new Point(12, 462);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 262);
            panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(387, 33);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(337, 122);
            dataGridView2.TabIndex = 20;
            // 
            // txtUserUsername
            // 
            txtUserUsername.Location = new Point(125, 110);
            txtUserUsername.Name = "txtUserUsername";
            txtUserUsername.Size = new Size(236, 27);
            txtUserUsername.TabIndex = 19;
            // 
            // txtUserNamee
            // 
            txtUserNamee.Location = new Point(125, 54);
            txtUserNamee.Name = "txtUserNamee";
            txtUserNamee.Size = new Size(236, 27);
            txtUserNamee.TabIndex = 18;
            txtUserNamee.TextChanged += txtUserNamee_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 113);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 16;
            label8.Text = "USERNAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 57);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 15;
            label7.Text = "NAME";
            // 
            // btnGetUsers
            // 
            btnGetUsers.Location = new Point(387, 188);
            btnGetUsers.Name = "btnGetUsers";
            btnGetUsers.Size = new Size(337, 47);
            btnGetUsers.TabIndex = 13;
            btnGetUsers.Text = "GET USERS";
            btnGetUsers.UseVisualStyleBackColor = true;
            btnGetUsers.Click += btnGetUsers_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(351, 431);
            label10.Name = "label10";
            label10.Size = new Size(72, 28);
            label10.TabIndex = 14;
            label10.Text = "USERS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 744);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PHP API - LUSTRE, COLEEN R.";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnPostAccount;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtName;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnGetAccounts;
        private Button btnPostUser;
        private Button btnGetUsers;
        private DataGridView dataGridView2;
        private TextBox txtUserUsername;
        private TextBox txtUserNamee;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}
