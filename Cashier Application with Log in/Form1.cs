using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
            InitializeMenuStrip();
        }

        private void InitializeMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");

            ToolStripMenuItem logoutItem = new ToolStripMenuItem("Logout");
            logoutItem.Click += new EventHandler(logoutItem_Click);

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += new EventHandler(exitItem_Click);

            fileMenu.DropDownItems.Add(logoutItem);
            fileMenu.DropDownItems.Add(exitItem);

            menuStrip.Items.Add(fileMenu);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void logoutItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
            this.Close(); 
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            string itemName = txt_item.Text;
            double price = Convert.ToDouble(txt_price.Text);
            int quantity = Convert.ToInt32(txt_quantity.Text);
            double discount = Convert.ToDouble(txt_discount.Text);

            discountedItem = new DiscountedItem(itemName, price, quantity, discount);
            double totalPrice = discountedItem.getTotalPrice();
            lbl_total.Text = totalPrice.ToString("F2");
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (discountedItem != null)
            {
                double payment = Convert.ToDouble(txt_payment.Text); 
                discountedItem.setPayment(payment);      
                double change = discountedItem.getChange();
                lbl_change.Text = change.ToString("F2"); 
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
            this.item_discount = discount * 0.01;
            this.discounted_price = item_price - (item_price * this.item_discount); 
        }

        public override double getTotalPrice()
        {
            return this.discounted_price * item_quantity;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
            this.change = payment_amount - getTotalPrice();
        }

        public double getChange()
        {
            return this.change;
        }
    }
}
