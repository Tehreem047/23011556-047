namespace Dental_Clinic_Information_System
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
            label1 = new Label();
            label2 = new Label();
            nam = new TextBox();
            passwd = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(256, 137);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(256, 200);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // nam
            // 
            nam.BackColor = Color.LightCyan;
            nam.Location = new Point(375, 138);
            nam.Name = "nam";
            nam.Size = new Size(179, 27);
            nam.TabIndex = 2;
            // 
            // passwd
            // 
            passwd.BackColor = Color.LightCyan;
            passwd.Location = new Point(375, 200);
            passwd.Name = "passwd";
            passwd.Size = new Size(179, 27);
            passwd.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(332, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(195, 49);
            label3.Name = "label3";
            label3.Size = new Size(413, 28);
            label3.TabIndex = 5;
            label3.Text = "Enter your credentials to login into the system";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(passwd);
            Controls.Add(nam);
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
        private TextBox nam;
        private TextBox passwd;
        private Button button1;
        private Label label3;
    }
}
