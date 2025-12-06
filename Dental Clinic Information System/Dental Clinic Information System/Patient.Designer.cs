namespace Dental_Clinic_Information_System
{
    partial class Patient
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            nam = new TextBox();
            ag = new TextBox();
            add = new TextBox();
            gend = new TextBox();
            cont = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            sear = new TextBox();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 82);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 136);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 235);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 188);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 35);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 235);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 6;
            label7.Text = "Contact";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 176);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(497, 222);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 8;
            // 
            // nam
            // 
            nam.Location = new Point(122, 35);
            nam.Name = "nam";
            nam.Size = new Size(250, 27);
            nam.TabIndex = 10;
            // 
            // ag
            // 
            ag.Location = new Point(122, 82);
            ag.Name = "ag";
            ag.Size = new Size(250, 27);
            ag.TabIndex = 11;
            // 
            // add
            // 
            add.Location = new Point(122, 136);
            add.Name = "add";
            add.Size = new Size(250, 27);
            add.TabIndex = 12;
            // 
            // gend
            // 
            gend.Location = new Point(122, 185);
            gend.Name = "gend";
            gend.Size = new Size(196, 27);
            gend.TabIndex = 14;
            // 
            // cont
            // 
            cont.Location = new Point(122, 235);
            cont.Name = "cont";
            cont.Size = new Size(196, 27);
            cont.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(16, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 365);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(16, 420);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(148, 420);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 21;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(549, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(598, 490);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 313);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 23;
            label10.Text = "Search patient";
            // 
            // sear
            // 
            sear.Location = new Point(148, 306);
            sear.Name = "sear";
            sear.Size = new Size(224, 27);
            sear.TabIndex = 24;
            // 
            // button5
            // 
            button5.Location = new Point(278, 365);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 25;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(278, 420);
            button6.Name = "button6";
            button6.Size = new Size(115, 29);
            button6.TabIndex = 26;
            button6.Text = "Nvigation bar ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 514);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(sear);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cont);
            Controls.Add(gend);
            Controls.Add(add);
            Controls.Add(ag);
            Controls.Add(nam);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Patient";
            Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox nam;
        private TextBox ag;
        private TextBox add;
        private TextBox gend;
        private TextBox cont;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label10;
        private TextBox sear;
        private Button button5;
        private Button button6;
    }
}