namespace iPhone_calculater

{
    public partial class Form1 : Form
    {
        string CalTotal;
        int num1;
        int num2;
        string option;
        int resultt;
        public Form1()
        {
            InitializeComponent();
        }
        //number

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        //Operator
        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(result.Text);

            result.Text = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(result.Text);

            result.Text = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(result.Text);

            result.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(result.Text);

            result.Text = "";
        }
        //calcul
        private void EQQbutton_Click(object sender, EventArgs e)
        {

               num2 = int.Parse(result.Text);


                if (option.Equals("+"))
                    resultt = num1 + num2;

                if (option.Equals("-"))
                    resultt = num1 - num2;

                if (option.Equals("*"))
                    resultt= num1 * num2;

                if (option.Equals("/"))
                    resultt = num1 / num2;

                result.Text = resultt + "";
            }

        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Text="";
            resultt = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}