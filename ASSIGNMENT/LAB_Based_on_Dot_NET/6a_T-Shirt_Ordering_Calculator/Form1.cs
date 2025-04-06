using System;

using System.Windows.Forms;

namespace _6a_T_Shirt_Ordering_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Small", "Medium", "Large" });
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number of T-Shirts.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSize = comboBox1.SelectedItem.ToString();
            string promoCode = textBox2.Text.Trim();

            int basePrice = 0;

            switch (selectedSize)
            {
                case "Small":
                    basePrice = 125;
                    break;
                case "Medium":
                    basePrice = 175;
                    break;
                case "Large":
                    basePrice = 250;
                    break;
                default:
                    basePrice = 0;
                    break;
            }

            double totalPrice = basePrice * quantity;

        
            if (promoCode.Equals("TRUEBLUE", StringComparison.OrdinalIgnoreCase))
            {
                totalPrice *= 0.90; 
            }

            double gstAmount = totalPrice * 0.09;
            double finalAmount = totalPrice + gstAmount;

            label5.Text = $"Final Amount (including 9% GST)1: ₹{finalAmount:F2}";
        }

     
    }
}

