using System;
using System.Windows.Forms;
using BIApi;
using BO;

namespace UI
{
    public partial class ManagmentCustomerMenu : Form
    {
        private IBI bl = BIApi.Factory.Get();

        public ManagmentCustomerMenu()
        {
            InitializeComponent();
            LoadAllCustomers(dataGridView1);
            LoadAllCustomers(dataGridView2);
            LoadAllCustomers(dataGridView3);
            LoadAllCustomers(dataGridView4);

            AddCustomerBtn.Click += AddCustomerBtn_Click;
            UpdateCustomerBtn.Click += UpdateCustomerBtn_Click;
            button1.Click += DeleteCustomerBtn_Click;
            jbh.Visible = false;
            IdText.Visible = false;
            tabControl1.SelectedIndexChanged += (s, e) =>
            {
                LoadAllCustomers(dataGridView1);
                LoadAllCustomers(dataGridView2);
                LoadAllCustomers(dataGridView3);
                LoadAllCustomers(dataGridView4);
            };
        }

        private void LoadAllCustomers(DataGridView grid)
        {
            grid.DataSource = bl.Customer.ReadAll();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = bl.Customer.ReadAll().Count + 1;
                bl.Customer.Create(new Customer
                {
                    Customer_Id = id,
                    Customer_Name = NameTextBox.Text,
                    Customer_Address = AddressTextBox.Text,
                    Customer_Phone = PhoneTextBox.Text ?? ""
                });
                MessageBox.Show("Customer added successfully!");
                LoadAllCustomers(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(PIdTxt.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            try
            {
                bl.Customer.Update(new Customer
                {
                    Customer_Id = id,
                    Customer_Name = PNameTxt.Text,
                    Customer_Address = TextBoxCUpdateAdress.Text,
                    Customer_Phone = TextBoxCUpdatePhone.Text ?? ""
                });
                MessageBox.Show("Customer updated successfully!");
                LoadAllCustomers(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ChooseCustomrtTxt.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            try
            {
                bl.Customer.Delete(id);
                MessageBox.Show("Customer deleted successfully!");
                LoadAllCustomers(dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void IdText_Click(object sender, EventArgs e)
        {

        }
    }
}
