using System;
using System.Windows.Forms;
using BIApi;
using BO;

namespace UI
{
    public partial class ManagmentProductMenu : Form
    {
        private IBI bl = BIApi.Factory.Get();

        public ManagmentProductMenu()
        {
            InitializeComponent();

            comboBox_PCreateCategory.DataSource = Enum.GetValues(typeof(DO.category));
            comboBox1.DataSource = Enum.GetValues(typeof(DO.category));
            textBox_PcreateId.Visible = false;
            label_PCreateId.Visible = false;

            comboBox_PShow_All_category.Items.Add("All");
            foreach (DO.category cat in Enum.GetValues(typeof(DO.category)))
                comboBox_PShow_All_category.Items.Add(cat);
            comboBox_PShow_All_category.SelectedIndex = 0;
            comboBox_PShow_All_category.SelectedIndexChanged += (s, e) =>
            {
                if (comboBox_PShow_All_category.SelectedItem?.ToString() == "All")
                    dataGridView4.DataSource = bl.Product.ReadAll();
                else
                    dataGridView4.DataSource = bl.Product.ReadAll(p => p.Product_Category == (DO.category)comboBox_PShow_All_category.SelectedItem);
            };

            LoadAllProducts(dataGridView1);
            LoadAllProducts(dataGridView2);
            LoadAllProducts(dataGridView3);
            LoadAllProducts(dataGridView4);

            button_AddProduct.Click += AddProduct_Click;
            button1.Click += UpdateProduct_Click;
            PDeleteBtn.Click += DeleteProduct_Click;

            tabControl1.SelectedIndexChanged += (s, e) =>
            {
                LoadAllProducts(dataGridView1);
                LoadAllProducts(dataGridView2);
                LoadAllProducts(dataGridView3);
                LoadAllProducts(dataGridView4);
            };
        }

        private void LoadAllProducts(DataGridView grid)
        {
            grid.DataSource = bl.Product.ReadAll();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = bl.Product.ReadAll().Count + 100;
                bl.Product.Create(new Product
                {
                    Product_Id = id,
                    Product_Name = textBox_PCreateName.Text,
                    Product_Category = (DO.category)comboBox_PCreateCategory.SelectedItem!,
                    Product_Amount = (int)numericUpDown_PCreateAmount.Value,
                    Product_Price = (double)numericUpDown_PCreatePrice.Value,
                    SaleInProduct = new System.Collections.Generic.List<Product>()
                });
                MessageBox.Show("Product added successfully!");
                LoadAllProducts(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            try
            {
                bl.Product.Update(new Product
                {
                    Product_Id = id,
                    Product_Name = textBox2.Text,
                    Product_Category = (DO.category)comboBox1.SelectedItem!,
                    Product_Amount = (int)numericUpDown1.Value,
                    Product_Price = (double)numericUpDown2.Value,
                    SaleInProduct = new System.Collections.Generic.List<Product>()
                });
                MessageBox.Show("Product updated successfully!");
                LoadAllProducts(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            try
            {
                bl.Product.Delete(id);
                MessageBox.Show("Product deleted successfully!");
                LoadAllProducts(dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
