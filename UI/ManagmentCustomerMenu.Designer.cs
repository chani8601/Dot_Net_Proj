namespace UI
{
    partial class ManagmentCustomerMenu
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ShowAllCustomerBtn = new Button();
            panel1 = new Panel();
            UploadCustomerBtn = new Button();
            AddCustomerBtn = new Button();
            DeleteCustomerBtn = new Button();
            PhoneTextBox = new TextBox();
            AddressTextBox = new TextBox();
            NameTextBox = new TextBox();
            jbh = new TextBox();
            PhoneText = new Label();
            AddressText = new Label();
            NameText = new Label();
            IdText = new Label();
            tabPage2 = new TabPage();
            UpdateProductBtn = new Button();
            ShowAllProductBtn = new Button();
            DeleteProductBtn = new Button();
            AddProductBtn = new Button();
            numericUpDownPPrice = new NumericUpDown();
            numericUpDownPCategory = new NumericUpDown();
            PNameTxt = new TextBox();
            PIdTxt = new TextBox();
            PPriceTxt = new Label();
            PAmountTxt = new Label();
            PCategoryText = new Label();
            PNameText = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPCategory).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ShowAllCustomerBtn);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(UploadCustomerBtn);
            tabPage1.Controls.Add(AddCustomerBtn);
            tabPage1.Controls.Add(DeleteCustomerBtn);
            tabPage1.Controls.Add(PhoneTextBox);
            tabPage1.Controls.Add(AddressTextBox);
            tabPage1.Controls.Add(NameTextBox);
            tabPage1.Controls.Add(jbh);
            tabPage1.Controls.Add(PhoneText);
            tabPage1.Controls.Add(AddressText);
            tabPage1.Controls.Add(NameText);
            tabPage1.Controls.Add(IdText);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // ShowAllCustomerBtn
            // 
            ShowAllCustomerBtn.Location = new Point(451, 276);
            ShowAllCustomerBtn.Name = "ShowAllCustomerBtn";
            ShowAllCustomerBtn.Size = new Size(120, 23);
            ShowAllCustomerBtn.TabIndex = 12;
            ShowAllCustomerBtn.Text = "Show all Customer";
            ShowAllCustomerBtn.UseVisualStyleBackColor = true;
            //ShowAllCustomerBtn.Click += this.ShowAllCustomerBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(266, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 209);
            panel1.TabIndex = 11;
            // 
            // UploadCustomerBtn
            // 
            UploadCustomerBtn.Location = new Point(324, 276);
            UploadCustomerBtn.Name = "UploadCustomerBtn";
            UploadCustomerBtn.Size = new Size(121, 23);
            UploadCustomerBtn.TabIndex = 10;
            UploadCustomerBtn.Text = "Upload Customer";
            UploadCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.Location = new Point(182, 276);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(126, 23);
            AddCustomerBtn.TabIndex = 9;
            AddCustomerBtn.Text = "Add Customer";
            AddCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerBtn
            // 
            DeleteCustomerBtn.Location = new Point(47, 276);
            DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            DeleteCustomerBtn.Size = new Size(116, 23);
            DeleteCustomerBtn.TabIndex = 8;
            DeleteCustomerBtn.Text = "Delete Customer";
            DeleteCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(105, 218);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(100, 23);
            PhoneTextBox.TabIndex = 7;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(105, 184);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(105, 154);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // jbh
            // 
            jbh.Location = new Point(105, 125);
            jbh.Name = "jbh";
            jbh.Size = new Size(100, 23);
            jbh.TabIndex = 4;
            // 
            // PhoneText
            // 
            PhoneText.AutoSize = true;
            PhoneText.Location = new Point(47, 221);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(44, 15);
            PhoneText.TabIndex = 3;
            PhoneText.Text = "Phone:";
            // 
            // AddressText
            // 
            AddressText.AutoSize = true;
            AddressText.Location = new Point(47, 187);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(52, 15);
            AddressText.TabIndex = 2;
            AddressText.Text = "Address:";
            AddressText.Click += label3_Click;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(47, 157);
            NameText.Name = "NameText";
            NameText.Size = new Size(42, 15);
            NameText.TabIndex = 1;
            NameText.Text = "Name:";
            NameText.Click += label2_Click;
            // 
            // IdText
            // 
            IdText.AutoSize = true;
            IdText.Location = new Point(47, 126);
            IdText.Name = "IdText";
            IdText.Size = new Size(20, 15);
            IdText.TabIndex = 0;
            IdText.Text = "Id:";
            IdText.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(UpdateProductBtn);
            tabPage2.Controls.Add(ShowAllProductBtn);
            tabPage2.Controls.Add(DeleteProductBtn);
            tabPage2.Controls.Add(AddProductBtn);
            tabPage2.Controls.Add(numericUpDownPPrice);
            tabPage2.Controls.Add(numericUpDownPCategory);
            tabPage2.Controls.Add(PNameTxt);
            tabPage2.Controls.Add(PIdTxt);
            tabPage2.Controls.Add(PPriceTxt);
            tabPage2.Controls.Add(PAmountTxt);
            tabPage2.Controls.Add(PCategoryText);
            tabPage2.Controls.Add(PNameText);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.Location = new Point(188, 326);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(108, 23);
            UpdateProductBtn.TabIndex = 12;
            UpdateProductBtn.Text = "Update Product";
            UpdateProductBtn.UseVisualStyleBackColor = true;
            // 
            // ShowAllProductBtn
            // 
            ShowAllProductBtn.Location = new Point(188, 297);
            ShowAllProductBtn.Name = "ShowAllProductBtn";
            ShowAllProductBtn.Size = new Size(108, 23);
            ShowAllProductBtn.TabIndex = 11;
            ShowAllProductBtn.Text = "Show all Product";
            ShowAllProductBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(66, 326);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(109, 23);
            DeleteProductBtn.TabIndex = 10;
            DeleteProductBtn.Text = "Delete Product";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(66, 297);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(109, 23);
            AddProductBtn.TabIndex = 9;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += button1_Click;
            // 
            // numericUpDownPPrice
            // 
            numericUpDownPPrice.Location = new Point(143, 243);
            numericUpDownPPrice.Name = "numericUpDownPPrice";
            numericUpDownPPrice.Size = new Size(120, 23);
            numericUpDownPPrice.TabIndex = 8;
            // 
            // numericUpDownPCategory
            // 
            numericUpDownPCategory.Location = new Point(143, 214);
            numericUpDownPCategory.Name = "numericUpDownPCategory";
            numericUpDownPCategory.Size = new Size(120, 23);
            numericUpDownPCategory.TabIndex = 7;
            numericUpDownPCategory.ValueChanged += numericUpDownPCategory_ValueChanged;
            // 
            // PNameTxt
            // 
            PNameTxt.Location = new Point(143, 150);
            PNameTxt.Name = "PNameTxt";
            PNameTxt.Size = new Size(100, 23);
            PNameTxt.TabIndex = 6;
            // 
            // PIdTxt
            // 
            PIdTxt.Location = new Point(143, 115);
            PIdTxt.Name = "PIdTxt";
            PIdTxt.Size = new Size(100, 23);
            PIdTxt.TabIndex = 5;
            // 
            // PPriceTxt
            // 
            PPriceTxt.AutoEllipsis = true;
            PPriceTxt.AutoSize = true;
            PPriceTxt.Location = new Point(72, 245);
            PPriceTxt.Name = "PPriceTxt";
            PPriceTxt.Size = new Size(36, 15);
            PPriceTxt.TabIndex = 4;
            PPriceTxt.Text = "Price:";
            // 
            // PAmountTxt
            // 
            PAmountTxt.AutoSize = true;
            PAmountTxt.Location = new Point(66, 216);
            PAmountTxt.Name = "PAmountTxt";
            PAmountTxt.Size = new Size(54, 15);
            PAmountTxt.TabIndex = 3;
            PAmountTxt.Text = "Amount:";
            // 
            // PCategoryText
            // 
            PCategoryText.AutoSize = true;
            PCategoryText.Location = new Point(66, 185);
            PCategoryText.Name = "PCategoryText";
            PCategoryText.Size = new Size(58, 15);
            PCategoryText.TabIndex = 2;
            PCategoryText.Text = "Category:";
            // 
            // PNameText
            // 
            PNameText.AutoSize = true;
            PNameText.Location = new Point(66, 153);
            PNameText.Name = "PNameText";
            PNameText.Size = new Size(42, 15);
            PNameText.TabIndex = 1;
            PNameText.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 117);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            label1.Click += label1_Click_1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(790, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(790, 421);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Show All";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ManagmentCustomerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ManagmentCustomerMenu";
            Text = "ManagmentMenu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label IdText;
        private Label AddressText;
        private Label NameText;
        private TextBox PhoneTextBox;
        private TextBox AddressTextBox;
        private TextBox NameTextBox;
        private TextBox jbh;
        private Label PhoneText;
        private Button UploadCustomerBtn;
        private Button AddCustomerBtn;
        private Button DeleteCustomerBtn;
        private Label PAmountTxt;
        private Label PCategoryText;
        private Label PNameText;
        private Label label1;
        private Label PPriceTxt;
        private NumericUpDown numericUpDownPCategory;
        private TextBox PNameTxt;
        private TextBox PIdTxt;
        private Panel panel1;
        private Button UpdateProductBtn;
        private Button ShowAllProductBtn;
        private Button DeleteProductBtn;
        private Button AddProductBtn;
        private NumericUpDown numericUpDownPPrice;
        private Button ShowAllCustomerBtn;
        private TabPage tabPage4;
    }
}