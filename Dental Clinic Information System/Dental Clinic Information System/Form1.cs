namespace Dental_Clinic_Information_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(nam.Text=="admin"&& passwd.Text == "123"){
                navig nav = new navig();
                nav.Show();
                this.Hide();

            }
        }
    }
}
