using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();

            // The cashier account
            cashier = new Cashier("Amado", "password", "Prince Travis Amado", "Marketing Department");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            // credential validation
            if (cashier.ValidateCredentials(username, password))
            {
                MessageBox.Show($"Welcome {cashier.fullName} from {cashier.department}!");
                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
