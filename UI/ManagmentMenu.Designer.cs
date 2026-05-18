namespace UI
{
    partial class ManagmentMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductMenuBtn = new Button();
            SaleMenuBtn = new Button();
            CustomerMenuBtn = new Button();
            SuspendLayout();
            // 
            // ProductMenuBtn
            // 
            ProductMenuBtn.Location = new Point(78, 146);
            ProductMenuBtn.Name = "ProductMenuBtn";
            ProductMenuBtn.Size = new Size(157, 75);
            ProductMenuBtn.TabIndex = 0;
            ProductMenuBtn.Text = "Product";
            ProductMenuBtn.UseVisualStyleBackColor = true;
            ProductMenuBtn.Click += button1_Click;
            // 
            // SaleMenuBtn
            // 
            SaleMenuBtn.Location = new Point(78, 55);
            SaleMenuBtn.Name = "SaleMenuBtn";
            SaleMenuBtn.Size = new Size(157, 67);
            SaleMenuBtn.TabIndex = 1;
            SaleMenuBtn.Text = "Sale";
            SaleMenuBtn.UseVisualStyleBackColor = true;
            SaleMenuBtn.Click += SaleMenuBtn_Click;
            // 
            // CustomerMenuBtn
            // 
            CustomerMenuBtn.Location = new Point(78, 254);
            CustomerMenuBtn.Name = "CustomerMenuBtn";
            CustomerMenuBtn.Size = new Size(157, 72);
            CustomerMenuBtn.TabIndex = 2;
            CustomerMenuBtn.Text = "Customer";
            CustomerMenuBtn.UseVisualStyleBackColor = true;
            CustomerMenuBtn.Click += CustomerMenuBtn_Click;
            // 
            // ManagmentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerMenuBtn);
            Controls.Add(SaleMenuBtn);
            Controls.Add(ProductMenuBtn);
            Name = "ManagmentMenu";
            Text = "ManagmentMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button ProductMenuBtn;
        private Button SaleMenuBtn;
        private Button CustomerMenuBtn;
    }
}