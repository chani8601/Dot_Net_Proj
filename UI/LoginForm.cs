using System;
using System.Windows.Forms;
using BIApi;

namespace UI
{
    public partial class LoginForm : Form
    {
        private IBI bl = BIApi.Factory.Get();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            bool isClubMember = bl.Customer.IsCustomerExist(customerId);

            if (!isClubMember)
                MessageBox.Show("Customer not found. You will enter as a guest.");

            new CustomerForm(customerId, isClubMember).ShowDialog();
            this.Close();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            new CustomerForm(0, false).ShowDialog();
            this.Close();
        }
    }
}
