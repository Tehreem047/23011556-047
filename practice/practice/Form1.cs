namespace practice
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string input1 = name.Text;
            string input2 = passwd.Text;
            if(input1 =="pakarmy" && input2 == "roger1")
            {
                homeform home = new homeform();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
