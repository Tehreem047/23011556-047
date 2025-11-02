namespace practice
{
    partial class calogin
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nam = new TextBox();
            passwd = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(292, 324);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 68);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 1;
            label1.Text = "Tehreem\"s Calculator Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 159);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 200);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // nam
            // 
            nam.Location = new Point(333, 152);
            nam.Name = "nam";
            nam.Size = new Size(125, 27);
            nam.TabIndex = 4;
            // 
            // passwd
            // 
            passwd.Location = new Point(333, 200);
            passwd.Name = "passwd";
            passwd.Size = new Size(125, 27);
            passwd.TabIndex = 5;
            // 
            // calogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwd);
            Controls.Add(nam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "calogin";
            Text = "calogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nam;
        private TextBox passwd;
    }
}