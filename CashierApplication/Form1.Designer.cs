namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_quantity = new TextBox();
            btn_compute = new Button();
            txt_payment = new TextBox();
            txt_item = new TextBox();
            txt_discount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_submit = new Button();
            label6 = new Label();
            lbl_total = new Label();
            txt_price = new TextBox();
            label8 = new Label();
            lbl_change = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(271, 65);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(48, 23);
            txt_quantity.TabIndex = 1;
            // 
            // btn_compute
            // 
            btn_compute.Location = new Point(119, 94);
            btn_compute.Name = "btn_compute";
            btn_compute.Size = new Size(75, 23);
            btn_compute.TabIndex = 2;
            btn_compute.Text = "Compute";
            btn_compute.UseVisualStyleBackColor = true;
            btn_compute.Click += btn_compute_Click;
            // 
            // txt_payment
            // 
            txt_payment.Location = new Point(120, 184);
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(118, 23);
            txt_payment.TabIndex = 3;
            // 
            // txt_item
            // 
            txt_item.Location = new Point(12, 36);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(182, 23);
            txt_item.TabIndex = 4;
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(200, 36);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(119, 23);
            txt_discount.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 18);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 6;
            label2.Text = "Discount(%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 70);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 9;
            label5.Text = "Payment received:";
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(244, 184);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 10;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 138);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 11;
            label6.Text = "Total amount: ";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(132, 138);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(34, 15);
            lbl_total.TabIndex = 12;
            lbl_total.Text = "00.00";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(52, 65);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(142, 23);
            txt_price.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 222);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 14;
            label8.Text = "Change: ";
            // 
            // lbl_change
            // 
            lbl_change.AutoSize = true;
            lbl_change.Location = new Point(120, 222);
            lbl_change.Name = "lbl_change";
            lbl_change.Size = new Size(34, 15);
            lbl_change.TabIndex = 15;
            lbl_change.Text = "00.00";
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 258);
            Controls.Add(lbl_change);
            Controls.Add(label8);
            Controls.Add(txt_price);
            Controls.Add(lbl_total);
            Controls.Add(label6);
            Controls.Add(btn_submit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_discount);
            Controls.Add(txt_item);
            Controls.Add(txt_payment);
            Controls.Add(btn_compute);
            Controls.Add(txt_quantity);
            Controls.Add(label1);
            Name = "frmPurchaseDiscountedItem";
            Text = "Buy discounted item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_quantity;
        private Button btn_compute;
        private TextBox txt_payment;
        private TextBox txt_item;
        private TextBox txt_discount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_submit;
        private Label label6;
        private Label lbl_total;
        private TextBox txt_price;
        private Label label8;
        private Label lbl_change;
    }
}
