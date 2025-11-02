using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            book book = new book();
            book.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calogin cal = new calogin();
            cal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
