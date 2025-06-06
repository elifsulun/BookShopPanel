using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionStructures
{
    public partial class BookShopIfElse : Form
    {
        public BookShopIfElse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            double discount = 0.00;
            double price = 0.00;

            count = Convert.ToInt16(textBox1.Text);

            if (count >0 && count <= 20)
            {
                discount = 0.2; // 20% discount for 20 or fewer books
                price = 8 * count * (1 - discount);
            }
            else if (count >20 && count <= 40)
            {
                discount = 0.4; // 40% discount for more than 20 and up to 40 books
                price = 8 * count * (1 - discount);
            }
            else
            {
                discount = 0.5; // 50% discount for more than 40 books
                price = 8 * count * (1 - discount);
            }

            label3.Text= "₺ " + price.ToString("0.00") + " with " + (discount * 100).ToString("0.00") + "% discount.";
        }
    }
}
