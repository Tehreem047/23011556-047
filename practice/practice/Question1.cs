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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is question1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nam.Text=="admin"&& passwd.Text == "123")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
