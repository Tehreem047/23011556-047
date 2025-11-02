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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Sdata.History;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calform calf = new calform();
            calf.Show();
            this.Hide();
        }
    }
}
