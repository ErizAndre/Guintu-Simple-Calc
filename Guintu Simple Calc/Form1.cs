using System.Data;

namespace Guintu_Simple_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
            {

                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "1";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            string equation = TxtDisplay.Text;
            try
            {

                var result = new DataTable().Compute(equation, null);
                TxtDisplay.Text = result.ToString();
            }
            catch (Exception)
            {
                TxtDisplay.Text = "Error";
            }
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "2";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "7";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "2";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            TxtDisplay.Text = TxtDisplay.Text + "+";

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "/";
        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
