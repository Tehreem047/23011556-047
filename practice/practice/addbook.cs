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
    public partial class addbook : Form
    {
        public addbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books newBook = new Books()
            {
                Title = bnam.Text,
                Author = anam.Text,
                IsAvailable = true
            };
            LibraryData.Bookss.Add(newBook);
            MessageBox.Show("Book Added!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dash dash1 = new dash();
            dash1.Show();
            this.Hide();
        }
    }
}
