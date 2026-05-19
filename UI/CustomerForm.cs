using System;
using System.Drawing;
using System.Windows.Forms;
using BIApi;
using BO;

namespace UI
{
    public partial class CustomerForm : Form
    {
        private IBI bl = BIApi.Factory.Get();
        private Order order;

        public CustomerForm(int customerId, bool isClubMember)
        {
            InitializeComponent();
            order = new Order { club = isClubMember, products = new System.Collections.Generic.List<ProductInOrder>(), final_price = 0 };
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

        private void AddProductCard(Product p)
        {
            var activeSales = bl.Sale.ReadAll(s =>
                s != null &&
                s.ProductId == p.Product_Id &&
                s.Date_Start_Sale <= DateTime.Now &&
                s.DateEndSale >= DateTime.Now &&
                (s.If_All_Customers || order.club));

            Panel card = new Panel();
            card.Width = 220;
            card.Height = 200;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(15);

            Label lblName = new Label { Text = p.Product_Name, Font = new Font("Arial", 16, FontStyle.Bold), Top = 10, Left = 10, AutoSize = true };
            Label lblPrice = new Label { Text = "₪" + p.Product_Price, Font = new Font("Arial", 14), Top = 50, Left = 10, AutoSize = true };
            Label lblStock = new Label { Text = "Stock: " + p.Product_Amount, Font = new Font("Arial", 10), Top = 80, Left = 10, AutoSize = true };

            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStock);

            if (activeSales != null && activeSales.Count > 0)
            {
                var sale = activeSales[0];
                Label lblSale = new Label
                {
                    Text = $"SALE: ₪{sale.Price_Sale} for {sale.MinAmountSale}+",
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    ForeColor = Color.Red,
                    Top = 100,
                    Left = 10,
                    AutoSize = true
                };
                card.Controls.Add(lblSale);
            }

            Button btnAdd = new Button { Text = "Add To Cart", Width = 150, Height = 35, Top = 150, Left = 10 };
            btnAdd.Click += (sender, e) => AddToCart(p);
            card.Controls.Add(btnAdd);

            productsPanelInCus.Controls.Add(card);
        }

        private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void AddToCart(Product p)
        {
            if (p.Product_Amount <= 0)
            {
                MessageBox.Show("Product out of stock!");
                return;
            }

            try
            {
                bl.Order.AddProductToOrder(order, p.Product_Id, 1);
                RefreshCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshCart()
        {
            cartGrid.Rows.Clear();
            foreach (var item in order.products)
                cartGrid.Rows.Add(item.id, item.name, item.amount, item.basic_price, item.sales?.Count > 0 ? "Yes" : "No", item.final_price);

            lblTotal.Text = $"Total: ₪{order.final_price}";
        }

        private void CloseOrder()
        {
            if (order.products.Count == 0)
            {
                MessageBox.Show("The cart is empty!");
                return;
            }

            try
            {
                bl.Order.DoOrder(order);
                MessageBox.Show($"Order closed! Total: ₪{order.final_price}");
                order = new Order { club = order.club, products = new System.Collections.Generic.List<ProductInOrder>(), final_price = 0 };
                cartGrid.Rows.Clear();
                lblTotal.Text = "Total: ₪0";
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing order: " + ex.Message);
            }
        }
    }
}
