using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagmentMenu : Form
    {
        public ManagmentMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManagmentProductMenu().ShowDialog();
        }

        private void CustomerMenuBtn_Click(object sender, EventArgs e)
        {
            new ManagmentCustomerMenu().ShowDialog();
        }

        private void SaleMenuBtn_Click(object sender, EventArgs e)
        {
            new ManagmentSaleMenu().ShowDialog();
        }
    }
}
