using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class dash : Form
    {
        public dash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbook add = new addbook();
            add.Show();
            this.Hide();





        }

        private void button4_Click(object sender, EventArgs e)
        {
            book book1 = new book();
            book1.Show();
            this.Hide();
        }
    }
}
