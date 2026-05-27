using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagmentMenu : Form
    {
        public ManagmentMenu()
        {
            InitializeComponent();

            string imagePath = Path.Combine(Application.StartupPath, "Images", "logo.png");
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            ProductMenuBtn.BringToFront();
            CustomerMenuBtn.BringToFront();
            SaleMenuBtn.BringToFront();
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
