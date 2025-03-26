namespace Final_Project__Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        String option;
        int result;


        private void button1_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b9.Text;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Totalbox.Text = Totalbox.Text + b0.Text;
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(Totalbox.Text);

            Totalbox.Clear();
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(Totalbox.Text);

            Totalbox.Clear();
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(Totalbox.Text);

            Totalbox.Clear();
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(Totalbox.Text);

            Totalbox.Clear();
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(Totalbox.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            Totalbox.Text = result + "";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Totalbox.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
