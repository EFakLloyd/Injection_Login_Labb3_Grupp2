namespace Injection_Login
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblQuery = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(134, 37);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(621, 31);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(134, 98);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(616, 31);
            txtPass.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(28, 211);
            button1.Name = "button1";
            button1.Size = new Size(199, 68);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 101);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // lblQuery
            // 
            lblQuery.AutoSize = true;
            lblQuery.Location = new Point(28, 163);
            lblQuery.Name = "lblQuery";
            lblQuery.Size = new Size(83, 25);
            lblQuery.TabIndex = 5;
            lblQuery.Text = "sqlQuery";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(28, 304);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(164, 25);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "You are logged out";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblQuery);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label lblQuery;
        private Label lblStatus;
    }
}
