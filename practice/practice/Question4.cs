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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numb1 = Convert.ToDouble(num1.Text);
            double numb2 = Convert.ToDouble(num2.Text);
            double result = numb1 + numb2;
            Sdata.History.Add($"{numb1}+{numb2}={result}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history his = new history();
            his.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            calogin cal = new calogin();
            cal.Show();
            this.Hide();
        }
    }
}
