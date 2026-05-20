using System;
using System.Windows.Forms;
using BIApi;
using BO;

namespace UI
{
    public partial class ManagmentSaleMenu : Form
    {
        private IBI bl = BIApi.Factory.Get();

        public ManagmentSaleMenu()
        {
            InitializeComponent();

            LoadAllSales(dataGridView1);
            LoadAllSales(dataGridView2);
            LoadAllSales(dataGridView3);
            LoadAllSales(dataGridView4);
            textBox1.Visible = false;
            label2.Visible = false;

            button1.Click += AddSale_Click;
            button2.Click += UpdateSale_Click;

            var btnDelete = new Button { Text = "Delete Sale", Width = 160, Height = 35, Left = 37, Top = 240 };
            btnDelete.Click += DeleteSale_Click;
            tabPage3.Controls.Add(btnDelete);

            tabControl1.SelectedIndexChanged += (s, e) =>
            {
                LoadAllSales(dataGridView1);
                LoadAllSales(dataGridView2);
                LoadAllSales(dataGridView3);
                LoadAllSales(dataGridView4);
            };
        }

        private void LoadAllSales(DataGridView grid)
        {
            grid.DataSource = bl.Sale.ReadAll();
        }

        private void AddSale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int productId))
            {
                MessageBox.Show("Invalid Product ID.");
                return;
            }
            try
            {
                int id = bl.Sale.ReadAll().Count + 200;
                bl.Sale.Create(new Sale
                {
                    SaleId = id,
                    ProductId = productId,
                    MinAmountSale = (int)numericUpDown1.Value,
                    Price_Sale = (double)numericUpDown2.Value,
                    If_All_Customers = checkBox1.Checked,
                    Date_Start_Sale = dateTimePicker2.Value,
                    DateEndSale = dateTimePicker1.Value
                });
                MessageBox.Show("Sale added successfully!");
                LoadAllSales(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateSale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int saleId) || !int.TryParse(textBox3.Text, out int productId))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            try
            {
                bl.Sale.Update(new Sale
                {
                    SaleId = saleId,
                    ProductId = productId,
                    MinAmountSale = (int)numericUpDown4.Value,
                    Price_Sale = (double)numericUpDown3.Value,
                    If_All_Customers = checkBox2.Checked,
                    Date_Start_Sale = dateTimePicker3.Value,
                    DateEndSale = dateTimePicker4.Value
                });
                MessageBox.Show("Sale updated successfully!");
                LoadAllSales(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteSale_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            try
            {
                bl.Sale.Delete(id);
                MessageBox.Show("Sale deleted successfully!");
                LoadAllSales(dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
