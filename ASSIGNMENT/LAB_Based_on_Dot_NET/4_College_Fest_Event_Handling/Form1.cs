using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_College_Fest_Event_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class College
        {
            public event EventHandler<int> CollegeFestEvent;

            public void OrganizeFest(int visitors)
            {
                CollegeFestEvent?.Invoke(this, visitors);
            }
        }

        public class Caterers
        {
            public int CalculateCateringCost(int visitors)
            {
                return visitors * 200; // ₹200 per plate
            }
        }

        public class Decorators
        {
            public int CalculateDecorationCost(int visitors)
            {
                return 10000 + (10 * visitors); // Base ₹10,000 + ₹10 per visitor
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int visitors) || visitors <= 0)
            {
                label4.Text = "Please enter a valid number of visitors.";
                return;
            }

            College college = new College();
            Caterers caterers = new Caterers();
            Decorators decorators = new Decorators();

            // Subscribing to event
            college.CollegeFestEvent += (s, v) =>
            {
                int cateringCost = caterers.CalculateCateringCost(v);
                int decorationCost = decorators.CalculateDecorationCost(v);
              label4.Text = $"Total Catering Cost: ₹{cateringCost}\nTotal Decoration Cost: ₹{decorationCost}\nGrand Total: ₹{cateringCost + decorationCost}";
            };

            // Trigger event
            college.OrganizeFest(visitors);
        }
    }
}
