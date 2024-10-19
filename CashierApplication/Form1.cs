using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string itemName = txt_item.Text;
            double price = Convert.ToDouble(txt_price.Text);
            int quantity = Convert.ToInt32(txt_quantity.Text);
            double discount = Convert.ToDouble(txt_discount.Text);

            // Initialize the DiscountedItem object
            discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            // Calculate total price and display in lbl_total
            double totalPrice = discountedItem.getTotalPrice();
            lbl_total.Text = totalPrice.ToString("F2"); // Display as formatted number
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (discountedItem != null)
            {
                // Retrieve payment amount from txt_payment
                double payment = Convert.ToDouble(txt_payment.Text);

                // Set payment and calculate change
                discountedItem.setPayment(payment);

                // Display change in lbl_change
                double change = discountedItem.getChange();
                lbl_change.Text = change.ToString("F2"); // Display as formatted number
            }
            else
            {
                MessageBox.Show("Please compute the total price first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

namespace ItemNamespace
{
    abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }

    class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount * 0.01; // Convert percentage to decimal
            this.discounted_price = item_price - (item_price * this.item_discount); // Calculate discounted price
        }

        public override double getTotalPrice()
        {
            return this.discounted_price * item_quantity; // Total price after discount
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
            this.change = payment_amount - getTotalPrice(); // Calculate change
        }

        public double getChange()
        {
            return this.change; // Return the computed change
        }
    }
}
