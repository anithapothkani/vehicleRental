namespace vehicle_rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string uname = txtuname.Text;

            string pass = txtpass.Text;

            if (uname.Equals("admin") && pass.Equals("123"))
            {


                Main m = new Main();
                this.Hide();
                m.Show();


            }
            else
            {

                MessageBox.Show("Username or password donot match");

                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
                           }







        }
    }
}
