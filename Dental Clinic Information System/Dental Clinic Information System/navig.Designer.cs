namespace Dental_Clinic_Information_System
{
    partial class navig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(navig));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.GhostWhite;
            button1.Location = new Point(13, 61);
            button1.Name = "button1";
            button1.Size = new Size(159, 33);
            button1.TabIndex = 0;
            button1.Text = "Patient Mnagement";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Location = new Point(13, 100);
            button2.Name = "button2";
            button2.Size = new Size(159, 38);
            button2.TabIndex = 1;
            button2.Text = "Appointments";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Location = new Point(13, 144);
            button3.Name = "button3";
            button3.Size = new Size(159, 36);
            button3.TabIndex = 2;
            button3.Text = "Treatment Records";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Location = new Point(13, 309);
            button4.Name = "button4";
            button4.Size = new Size(159, 37);
            button4.TabIndex = 3;
            button4.Text = "Billing/Payments";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Location = new Point(13, 186);
            button5.Name = "button5";
            button5.Size = new Size(159, 35);
            button5.TabIndex = 4;
            button5.Text = "Staff management";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.Location = new Point(13, 227);
            button6.Name = "button6";
            button6.Size = new Size(159, 37);
            button6.TabIndex = 5;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Location = new Point(13, 270);
            button7.Name = "button7";
            button7.Size = new Size(159, 33);
            button7.TabIndex = 6;
            button7.Text = "Settings/User Profile";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(297, 28);
            label1.TabIndex = 10;
            label1.Text = "Smile Dental Information System";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(739, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 371);
            panel1.TabIndex = 11;
            // 
            // navig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1077, 534);
            Controls.Add(panel1);
            Name = "navig";
            Text = "navig";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Panel panel1;
    }
}