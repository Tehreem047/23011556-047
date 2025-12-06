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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(name.Text == "admin" && passwd.Text == "123")
            {
                dash dashb = new dash();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
