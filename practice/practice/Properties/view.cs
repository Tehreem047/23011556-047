using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice.Properties
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            var borrowed = LibraryData.Bookss.FindAll(b => !b.IsAvailable);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = borrowed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dash dash1 = new dash();
            dash1.Show();
            this.Hide();
        }
    }
}
