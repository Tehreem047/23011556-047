namespace practice
{
    partial class add
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
            label3 = new Label();
            age = new TextBox();
            clas = new TextBox();
            nam = new TextBox();
            save = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 88);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Nme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 130);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 171);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // age
            // 
            age.Location = new Point(255, 164);
            age.Name = "age";
            age.Size = new Size(125, 27);
            age.TabIndex = 3;
            // 
            // clas
            // 
            clas.Location = new Point(255, 123);
            clas.Name = "clas";
            clas.Size = new Size(125, 27);
            clas.TabIndex = 4;
            // 
            // nam
            // 
            nam.Location = new Point(255, 85);
            nam.Name = "nam";
            nam.Size = new Size(125, 27);
            nam.TabIndex = 5;
            // 
            // save
            // 
            save.Location = new Point(272, 249);
            save.Name = "save";
            save.Size = new Size(108, 58);
            save.TabIndex = 6;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // exit
            // 
            exit.Location = new Point(436, 249);
            exit.Name = "exit";
            exit.Size = new Size(114, 58);
            exit.TabIndex = 7;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(save);
            Controls.Add(nam);
            Controls.Add(clas);
            Controls.Add(age);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add";
            Text = "add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox age;
        private TextBox clas;
        private TextBox nam;
        private Button save;
        private Button exit;
    }
}