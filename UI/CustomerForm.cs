using System;
using System.Drawing;
using System.Windows.Forms;
using BIApi;
using BO;

namespace UI
{
    public partial class CustomerForm : Form
    {
        private double totalPrice = 0;

        private IBI bl = BIApi.Factory.Get();

        public CustomerForm()
        {
            InitializeComponent();
            LoadProducts();
            btnPay.Click += (s, e) => CloseOrder();
        }

        private void LoadProducts()
        {
            productsPanelInCus.Controls.Clear();

            var products = bl.Product.ReadAll();

            foreach (var p in products)
            {
                if (p == null) continue;

                AddProductCard(p);
            }
        }

        // ✔ עבודה נכונה עם BO.Product
        private void AddProductCard(Product p)
        {
            Panel card = new Panel();
            card.Width = 220;
            card.Height = 180;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(15);

            Label lblName = new Label();
            lblName.Text = p.Product_Name;
            lblName.Font = new Font("Arial", 16, FontStyle.Bold);
            lblName.Top = 20;
            lblName.Left = 20;
            lblName.AutoSize = true;

            Label lblPrice = new Label();
            lblPrice.Text = "₪" + p.Product_Price;
            lblPrice.Font = new Font("Arial", 14);
            lblPrice.Top = 70;
            lblPrice.Left = 20;
            lblPrice.AutoSize = true;

            Label lblStock = new Label();
            lblStock.Text = "Stock: " + p.Product_Amount;
            lblStock.Font = new Font("Arial", 10);
            lblStock.Top = 95;
            lblStock.Left = 20;
            lblStock.AutoSize = true;

            Button btnAdd = new Button();
            btnAdd.Text = "Add To Cart";
            btnAdd.Width = 150;
            btnAdd.Height = 40;
            btnAdd.Top = 120;
            btnAdd.Left = 20;

            btnAdd.Click += (sender, e) =>
            {
                AddToCart(p);
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);
            card.Controls.Add(btnAdd);

            productsPanelInCus.Controls.Add(card);
        }

        private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddToCart(Product p)
        {
            if (p.Product_Amount <= 0)
            {
                MessageBox.Show("Product out of stock!");
                return;
            }
            double price = p.Product_Price;
            cartGrid.Rows.Add(p.Product_Id, p.Product_Name, 1, price, "", price);
            totalPrice += price;
            lblTotal.Text = "Total: ₪" + totalPrice;
        }

        private void CloseOrder()
        {
            if (cartGrid.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty!");
                return;
            }

            try
            {
                foreach (DataGridViewRow row in cartGrid.Rows)
                {
                    int id = int.Parse(row.Cells["ColumnId"].Value.ToString());
                    int quantity = int.Parse(row.Cells["Column1Quantity"].Value.ToString());

                    Product product = bl.Product.Read(id);
                    product.Product_Amount -= quantity;
                    bl.Product.Update(product);
                }

                MessageBox.Show($"Order closed! Total: ₪{totalPrice}");
                cartGrid.Rows.Clear();
                totalPrice = 0;
                lblTotal.Text = "Total: ₪0";
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing order: " + ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            LoadProducts();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}