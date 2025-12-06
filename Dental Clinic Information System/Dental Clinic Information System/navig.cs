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
    public partial class navig : Form
    {
        public navig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient p1 = new Patient();
            p1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointments app = new Appointments();
            app.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Records rec = new Records();
            rec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bills bil = new Bills();
            bil.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            rep.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User us = new User();
            us.Show();
            this.Hide();
        }
    }
}
