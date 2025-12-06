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
    public partial class homeform : Form
    {

        public homeform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add addme = new add();
            addme.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view see = new view();
            see.Show();
            this.Hide();
        }
    }
}
