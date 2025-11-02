using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using practice;

namespace practice
{

    public partial class add : Form
    {

        public add()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = nam.Text,
                Class = clas.Text

            };
            
            shareddata.students.Add(student);
            MessageBox.Show("Added successfully");
            this.Close();


        }

        private void exit_Click(object sender, EventArgs e)
        {
            
            homeform hom = new homeform();
            hom.Show();
            
        }
    }
}
