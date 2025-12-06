using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Information_System
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navig nav = new navig();
            nav.Show();
            this.Hide();
        }
    }
}
