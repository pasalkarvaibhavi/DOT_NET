using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Windows_Form_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(Price.Text);
                int quantity = int.Parse(Quantity.Text);
                double discount = double.Parse(Discount.Text);
                double tax = double.Parse(Tax.Text);

                double subtotal = price * quantity;
                double discountAmount = (subtotal * discount) / 100;
                double taxAmount = ((subtotal - discountAmount) * tax) / 100;
                double totalPrice = subtotal - discountAmount + taxAmount;

                result.Text = $"Total Price: ${totalPrice:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
