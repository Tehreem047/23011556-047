namespace practice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            passwd = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 112);
            label1.Name = "label1";
            label1.Padding = new Padding(15);
            label1.Size = new Size(147, 50);
            label1.TabIndex = 0;
            label1.Text = "Enter your name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 230);
            label2.Name = "label2";
            label2.Padding = new Padding(15);
            label2.Size = new Size(102, 50);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // name
            // 
            name.Location = new Point(366, 124);
            name.Margin = new Padding(8);
            name.Name = "name";
            name.Size = new Size(338, 27);
            name.TabIndex = 2;
            // 
            // passwd
            // 
            passwd.Location = new Point(388, 241);
            passwd.Name = "passwd";
            passwd.Size = new Size(125, 27);
            passwd.TabIndex = 3;
            // 
            // login
            // 
            login.Location = new Point(305, 341);
            login.Name = "login";
            login.Padding = new Padding(15);
            login.Size = new Size(171, 97);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(login);
            Controls.Add(passwd);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox passwd;
        private Button login;
    }
}
