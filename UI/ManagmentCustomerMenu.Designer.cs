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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            AddCustomerBtn = new Button();
            PhoneTextBox = new TextBox();
            AddressTextBox = new TextBox();
            NameTextBox = new TextBox();
            jbh = new TextBox();
            PhoneText = new Label();
            AddressText = new Label();
            NameText = new Label();
            IdText = new Label();
            tabPage2 = new TabPage();
            UpdateCustomer = new Label();
            dataGridView2 = new DataGridView();
            TextBoxCUpdatePhone = new TextBox();
            TextBoxCUpdateAdress = new TextBox();
            UpdateCustomerBtn = new Button();
            PNameTxt = new TextBox();
            PIdTxt = new TextBox();
            PAmountTxt = new Label();
            PCategoryNameText = new Label();
            PNameText = new Label();
            label1 = new Label();
            DeleteCustomer = new TabPage();
            label3 = new Label();
            ChooseCustomrtLbl = new Label();
            ChooseCustomrtTxt = new TextBox();
            button1 = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            DeleteCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(DeleteCustomer);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(912, 599);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(AddCustomerBtn);
            tabPage1.Controls.Add(PhoneTextBox);
            tabPage1.Controls.Add(AddressTextBox);
            tabPage1.Controls.Add(NameTextBox);
            tabPage1.Controls.Add(jbh);
            tabPage1.Controls.Add(PhoneText);
            tabPage1.Controls.Add(AddressText);
            tabPage1.Controls.Add(NameText);
            tabPage1.Controls.Add(IdText);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(904, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 61);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 14;
            label2.Text = "Create Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(380, 251);
            dataGridView1.TabIndex = 13;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.Location = new Point(115, 373);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(171, 29);
            AddCustomerBtn.TabIndex = 12;
            AddCustomerBtn.Text = "Add Customer";
            AddCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(187, 285);
            PhoneTextBox.Margin = new Padding(3, 4, 3, 4);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(114, 27);
            PhoneTextBox.TabIndex = 7;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(187, 239);
            AddressTextBox.Margin = new Padding(3, 4, 3, 4);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(114, 27);
            AddressTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(187, 204);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(114, 27);
            NameTextBox.TabIndex = 5;
            // 
            // jbh
            // 
            jbh.Location = new Point(187, 166);
            jbh.Margin = new Padding(3, 4, 3, 4);
            jbh.Name = "jbh";
            jbh.Size = new Size(114, 27);
            jbh.TabIndex = 4;
            // 
            // PhoneText
            // 
            PhoneText.AutoSize = true;
            PhoneText.Location = new Point(106, 288);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(53, 20);
            PhoneText.TabIndex = 3;
            PhoneText.Text = "Phone:";
            // 
            // AddressText
            // 
            AddressText.AutoSize = true;
            AddressText.Location = new Point(106, 242);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(65, 20);
            AddressText.TabIndex = 2;
            AddressText.Text = "Address:";
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(106, 202);
            NameText.Name = "NameText";
            NameText.Size = new Size(52, 20);
            NameText.TabIndex = 1;
            NameText.Text = "Name:";
            // 
            // IdText
            // 
            IdText.AutoSize = true;
            IdText.Location = new Point(106, 161);
            IdText.Name = "IdText";
            IdText.Size = new Size(25, 20);
            IdText.TabIndex = 0;
            IdText.Text = "Id:";
            IdText.Click += IdText_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(UpdateCustomer);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(TextBoxCUpdatePhone);
            tabPage2.Controls.Add(TextBoxCUpdateAdress);
            tabPage2.Controls.Add(UpdateCustomerBtn);
            tabPage2.Controls.Add(PNameTxt);
            tabPage2.Controls.Add(PIdTxt);
            tabPage2.Controls.Add(PAmountTxt);
            tabPage2.Controls.Add(PCategoryNameText);
            tabPage2.Controls.Add(PNameText);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(904, 566);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomer
            // 
            UpdateCustomer.AutoSize = true;
            UpdateCustomer.Location = new Point(179, 51);
            UpdateCustomer.Name = "UpdateCustomer";
            UpdateCustomer.Size = new Size(125, 20);
            UpdateCustomer.TabIndex = 16;
            UpdateCustomer.Text = "Update Customer";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(367, 135);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(393, 258);
            dataGridView2.TabIndex = 15;
            // 
            // TextBoxCUpdatePhone
            // 
            TextBoxCUpdatePhone.Location = new Point(164, 265);
            TextBoxCUpdatePhone.Name = "TextBoxCUpdatePhone";
            TextBoxCUpdatePhone.Size = new Size(125, 27);
            TextBoxCUpdatePhone.TabIndex = 14;
            // 
            // TextBoxCUpdateAdress
            // 
            TextBoxCUpdateAdress.Location = new Point(163, 224);
            TextBoxCUpdateAdress.Name = "TextBoxCUpdateAdress";
            TextBoxCUpdateAdress.Size = new Size(125, 27);
            TextBoxCUpdateAdress.TabIndex = 13;
            // 
            // UpdateCustomerBtn
            // 
            UpdateCustomerBtn.Location = new Point(75, 406);
            UpdateCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            UpdateCustomerBtn.Size = new Size(202, 31);
            UpdateCustomerBtn.TabIndex = 12;
            UpdateCustomerBtn.Text = "Update Customer";
            UpdateCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // PNameTxt
            // 
            PNameTxt.Location = new Point(163, 175);
            PNameTxt.Margin = new Padding(3, 4, 3, 4);
            PNameTxt.Name = "PNameTxt";
            PNameTxt.Size = new Size(114, 27);
            PNameTxt.TabIndex = 6;
            // 
            // PIdTxt
            // 
            PIdTxt.Location = new Point(163, 135);
            PIdTxt.Margin = new Padding(3, 4, 3, 4);
            PIdTxt.Name = "PIdTxt";
            PIdTxt.Size = new Size(114, 27);
            PIdTxt.TabIndex = 5;
            // 
            // PAmountTxt
            // 
            PAmountTxt.AutoSize = true;
            PAmountTxt.Location = new Point(75, 267);
            PAmountTxt.Name = "PAmountTxt";
            PAmountTxt.Size = new Size(53, 20);
            PAmountTxt.TabIndex = 3;
            PAmountTxt.Text = "Phone:";
            // 
            // PCategoryNameText
            // 
            PCategoryNameText.AutoSize = true;
            PCategoryNameText.Location = new Point(75, 224);
            PCategoryNameText.Name = "PCategoryNameText";
            PCategoryNameText.Size = new Size(65, 20);
            PCategoryNameText.TabIndex = 2;
            PCategoryNameText.Text = "Address:";
            // 
            // PNameText
            // 
            PNameText.AutoSize = true;
            PNameText.Location = new Point(77, 180);
            PNameText.Name = "PNameText";
            PNameText.Size = new Size(52, 20);
            PNameText.TabIndex = 1;
            PNameText.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 138);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // DeleteCustomer
            // 
            DeleteCustomer.Controls.Add(label3);
            DeleteCustomer.Controls.Add(ChooseCustomrtLbl);
            DeleteCustomer.Controls.Add(ChooseCustomrtTxt);
            DeleteCustomer.Controls.Add(button1);
            DeleteCustomer.Controls.Add(dataGridView3);
            DeleteCustomer.Location = new Point(4, 29);
            DeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            DeleteCustomer.Name = "DeleteCustomer";
            DeleteCustomer.Padding = new Padding(3, 4, 3, 4);
            DeleteCustomer.Size = new Size(904, 566);
            DeleteCustomer.TabIndex = 2;
            DeleteCustomer.Text = "Delete";
            DeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 58);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Delete Customer";
            // 
            // ChooseCustomrtLbl
            // 
            ChooseCustomrtLbl.AutoSize = true;
            ChooseCustomrtLbl.Location = new Point(22, 219);
            ChooseCustomrtLbl.Name = "ChooseCustomrtLbl";
            ChooseCustomrtLbl.Size = new Size(158, 20);
            ChooseCustomrtLbl.TabIndex = 3;
            ChooseCustomrtLbl.Text = "Choose id of customrt:";
            // 
            // ChooseCustomrtTxt
            // 
            ChooseCustomrtTxt.Location = new Point(198, 212);
            ChooseCustomrtTxt.Name = "ChooseCustomrtTxt";
            ChooseCustomrtTxt.Size = new Size(125, 27);
            ChooseCustomrtTxt.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(104, 289);
            button1.Name = "button1";
            button1.Size = new Size(162, 29);
            button1.TabIndex = 1;
            button1.Text = "Delete Customer";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(393, 137);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(344, 245);
            dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(904, 566);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Show All";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 33);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 1;
            label4.Text = "Show All Customer";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(141, 103);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(600, 330);
            dataGridView4.TabIndex = 0;
            // 
            // ManagmentCustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagmentCustomerMenu";
            Text = "ManagmentMenu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            DeleteCustomer.ResumeLayout(false);
            DeleteCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage DeleteCustomer;
        private Label IdText;
        private Label AddressText;
        private Label NameText;
        private TextBox PhoneTextBox;
        private TextBox AddressTextBox;
        private TextBox NameTextBox;
        private TextBox jbh;
        private Label PhoneText;
        private Label PAmountTxt;
        private Label PCategoryNameText;
        private Label PNameText;
        private Label label1;
        private TextBox PNameTxt;
        private TextBox PIdTxt;
        private TabPage tabPage4;
        private Button AddCustomerBtn;
        private DataGridView dataGridView1;
        private Button UpdateCustomerBtn;
        private TextBox TextBoxCUpdatePhone;
        private TextBox TextBoxCUpdateAdress;
        private DataGridView dataGridView2;
        private Label ChooseCustomrtLbl;
        private TextBox ChooseCustomrtTxt;
        private Button button1;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Label label2;
        private Label UpdateCustomer;
        private Label label3;
        private Label label4;
    }
}