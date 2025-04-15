namespace FinActZapatero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            c1.setName(textBox1.Text);
            c1.setDaysWorked(Convert.ToDouble(textBox2.Text));

            c1.setRatePerDay(Convert.ToDouble(textBox3.Text));
            label6.Text = c1.getGreeting();
            label7.Text = Convert.ToString(c1.getGrossPay());

            c1.setPagIbig(Convert.ToDouble(textBox4.Text));
            c1.setSSS(Convert.ToDouble(textBox5.Text));
            c1.setPhilHealth(Convert.ToDouble(textBox6.Text));

            label10.Text = Convert.ToString(c1.getTotalDeduction());
            label11.Text = Convert.ToString(c1.getNetPay());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
