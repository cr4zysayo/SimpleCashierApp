using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCashierApp
{
    public partial class Calculator : Form
    {
        public class Item
        {
            protected string itemName;
            protected double price;

            public Item(string itemName, double price)
            {
                this.itemName = itemName;
                this.price = price;
            }

            public virtual double CalculateTotal(int quantity)
            {
                return price * quantity;
            }
        }
        public class DiscountedItem : Item
        {
            private double discountPercentage;

            public DiscountedItem(string itemName, double price, double discountPercentage) : base(itemName, price)
            {
                this.discountPercentage = discountPercentage;
            }

            public override double CalculateTotal(int quantity)
            {
                double discountedPrice = price - (price * discountPercentage / 100);
                return discountedPrice * quantity;
            }
        }
            public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void item1_TextChanged(object sender, EventArgs e)
        {

        }

        private void discount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void price1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = item1.Text;
            double price = double.Parse(price1.Text);
            double discountPercentage = double.Parse(discount1.Text);
            int quantity = int.Parse(quantity1.Text);

            Item item = new DiscountedItem(itemName, price, discountPercentage);
            double totalAmount = item.CalculateTotal(quantity);

            Tamount1.Text = totalAmount.ToString("C2");
        }

        private void Preceived1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemName = item1.Text;
            double price = double.Parse(price1.Text);
            double discountPercentage = double.Parse(discount1.Text);
            int quantity = int.Parse(quantity1.Text);
            double payment = double.Parse(Preceived1.Text);

            Item item = new DiscountedItem(itemName, price, discountPercentage);
            double totalAmount = item.CalculateTotal(quantity);

            Tamount1.Text = totalAmount.ToString("C2");
            double change = payment - totalAmount;
            Tchange1.Text = change.ToString("C2");
        }

        private void Tchange1_Click(object sender, EventArgs e)
        {

        }

        private void Tamount1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
// James Vladimir Z. Gacis