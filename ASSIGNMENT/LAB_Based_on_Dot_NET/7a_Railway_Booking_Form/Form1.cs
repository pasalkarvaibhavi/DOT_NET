using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _7a_Railway_Booking_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Sleeper", "AC 3-Tier", "AC 2-Tier", "AC 1-Tier" });
            comboBox1.SelectedIndex = 0; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) ||
               string.IsNullOrWhiteSpace(textBox4.Text) ||
               string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(textBox2.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passengerName = textBox1.Text;
            string departure =textBox3.Text;
            string destination = textBox5.Text;
            string travelClass = comboBox1.SelectedItem.ToString();
            string seatPreference = radioButton1.Checked ? "Window" : radioButton2.Checked ? "Middle" : "Aisle";
            DateTime journeyDate = dateTimePicker1.Value;
            bool mealIncluded = checkBox1.Checked;
            int baseFare;
            switch (travelClass)
            {
                case "Sleeper":
                    baseFare = 500;
                    break;
                case "AC 3-Tier":
                    baseFare = 1000;
                    break;
                case "AC 2-Tier":
                    baseFare = 1500;
                    break;
                case "AC 1-Tier":
                    baseFare = 2000;
                    break;
                default:
                    baseFare = 500;
                    break;
            }

            int mealCharge = mealIncluded ? 200 : 0;
            int totalFare = baseFare + mealCharge;

            // Display output
            label11.Text = $"Booking Confirmed!\n" +
                $"Passenger: {passengerName}\n" +
                $"Age: {age}\n" +
                $"From: {departure} → To: {destination}\n" +
                $"Class: {travelClass} | Seat: {seatPreference}\n" +
                $"Date: {journeyDate.ToShortDateString()}\n" +
                $"Meal Included: {(mealIncluded ? "Yes" : "No")}\n" +
                $"Total Fare: ₹{totalFare}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            label11.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
