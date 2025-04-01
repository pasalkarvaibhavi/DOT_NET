using System;
using System.Windows.Forms;

namespace DelegateBasedCalculator
{
    public partial class Form1 : Form
    {
        public delegate double MathOperation(double a, double b);

        public Form1()
        {
            InitializeComponent();
        }

        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => a - b;
        public double Mul(double a, double b) => a * b;
        public double Div(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return a / b;
        }

        private bool ValidateInput(out double num1, out double num2)
        {
            num1 = num2 = 0;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(textBox1.Text, out num1) || !double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("Invalid number format!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void PerformOperation(MathOperation operation)
        {
            if (ValidateInput(out double num1, out double num2))
            {
                try
                {
                    double result = operation(num1, num2);
                    textBox3.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) => PerformOperation(Add);
        private void button2_Click(object sender, EventArgs e) => PerformOperation(Sub);
        private void button3_Click(object sender, EventArgs e) => PerformOperation(Mul);
        private void button4_Click(object sender, EventArgs e) => PerformOperation(Div);

       
    }
}
