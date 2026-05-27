using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            string imagePath = Path.Combine(Application.StartupPath, "Images", "logo.png");
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            button1.BringToFront();
            button2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManagmentMenu().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }
    }
}
