namespace practice
{
    partial class Question3
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
            namee = new Label();
            password = new Label();
            login = new Button();
            name = new TextBox();
            passwd = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 80);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter credentials to log into the account";
            // 
            // namee
            // 
            namee.AutoSize = true;
            namee.Location = new Point(242, 196);
            namee.Name = "namee";
            namee.Size = new Size(87, 20);
            namee.TabIndex = 1;
            namee.Text = "Enter Name";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(242, 227);
            password.Name = "password";
            password.Size = new Size(74, 20);
            password.TabIndex = 2;
            password.Text = "Enter Text";
            // 
            // login
            // 
            login.Location = new Point(328, 292);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 3;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // name
            // 
            name.Location = new Point(385, 189);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 4;
            // 
            // passwd
            // 
            passwd.Location = new Point(385, 227);
            passwd.Name = "passwd";
            passwd.Size = new Size(125, 27);
            passwd.TabIndex = 5;
            // 
            // book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwd);
            Controls.Add(name);
            Controls.Add(login);
            Controls.Add(password);
            Controls.Add(namee);
            Controls.Add(label1);
            Name = "book";
            Text = "book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label namee;
        private Label password;
        private Button login;
        private TextBox name;
        private TextBox passwd;
    }
}