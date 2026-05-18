namespace UI
{
    partial class ManagmentProductMenu
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
            comboBox_PCreateCategory = new ComboBox();
            textBox_PCreateName = new TextBox();
            textBox_PcreateId = new TextBox();
            button_AddProduct = new Button();
            label_PCreatePrice = new Label();
            label_PCreateAmount = new Label();
            label_PCreateCategory = new Label();
            label_PCreateName = new Label();
            label_PCreateId = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            numericUpDown_PCreateAmount = new NumericUpDown();
            numericUpDown_PCreatePrice = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PCreateAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PCreatePrice).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numericUpDown_PCreatePrice);
            tabPage1.Controls.Add(numericUpDown_PCreateAmount);
            tabPage1.Controls.Add(comboBox_PCreateCategory);
            tabPage1.Controls.Add(textBox_PCreateName);
            tabPage1.Controls.Add(textBox_PcreateId);
            tabPage1.Controls.Add(button_AddProduct);
            tabPage1.Controls.Add(label_PCreatePrice);
            tabPage1.Controls.Add(label_PCreateAmount);
            tabPage1.Controls.Add(label_PCreateCategory);
            tabPage1.Controls.Add(label_PCreateName);
            tabPage1.Controls.Add(label_PCreateId);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox_PCreateCategory
            // 
            comboBox_PCreateCategory.FormattingEnabled = true;
            comboBox_PCreateCategory.Location = new Point(129, 123);
            comboBox_PCreateCategory.Name = "comboBox_PCreateCategory";
            comboBox_PCreateCategory.Size = new Size(121, 23);
            comboBox_PCreateCategory.TabIndex = 8;
            // 
            // textBox_PCreateName
            // 
            textBox_PCreateName.Location = new Point(129, 94);
            textBox_PCreateName.Name = "textBox_PCreateName";
            textBox_PCreateName.Size = new Size(100, 23);
            textBox_PCreateName.TabIndex = 7;
            // 
            // textBox_PcreateId
            // 
            textBox_PcreateId.Location = new Point(129, 63);
            textBox_PcreateId.Name = "textBox_PcreateId";
            textBox_PcreateId.Size = new Size(100, 23);
            textBox_PcreateId.TabIndex = 6;
            // 
            // button_AddProduct
            // 
            button_AddProduct.Location = new Point(70, 231);
            button_AddProduct.Name = "button_AddProduct";
            button_AddProduct.Size = new Size(172, 39);
            button_AddProduct.TabIndex = 5;
            button_AddProduct.Text = "Add Product";
            button_AddProduct.UseVisualStyleBackColor = true;
            // 
            // label_PCreatePrice
            // 
            label_PCreatePrice.AutoSize = true;
            label_PCreatePrice.Location = new Point(65, 184);
            label_PCreatePrice.Name = "label_PCreatePrice";
            label_PCreatePrice.Size = new Size(36, 15);
            label_PCreatePrice.TabIndex = 4;
            label_PCreatePrice.Text = "Price:";
            // 
            // label_PCreateAmount
            // 
            label_PCreateAmount.AutoSize = true;
            label_PCreateAmount.Location = new Point(65, 156);
            label_PCreateAmount.Name = "label_PCreateAmount";
            label_PCreateAmount.Size = new Size(54, 15);
            label_PCreateAmount.TabIndex = 3;
            label_PCreateAmount.Text = "Amount:";
            // 
            // label_PCreateCategory
            // 
            label_PCreateCategory.AutoSize = true;
            label_PCreateCategory.Location = new Point(65, 126);
            label_PCreateCategory.Name = "label_PCreateCategory";
            label_PCreateCategory.Size = new Size(58, 15);
            label_PCreateCategory.TabIndex = 2;
            label_PCreateCategory.Text = "Category:";
            // 
            // label_PCreateName
            // 
            label_PCreateName.AutoSize = true;
            label_PCreateName.Location = new Point(65, 98);
            label_PCreateName.Name = "label_PCreateName";
            label_PCreateName.Size = new Size(42, 15);
            label_PCreateName.TabIndex = 1;
            label_PCreateName.Text = "Name:";
            // 
            // label_PCreateId
            // 
            label_PCreateId.AutoSize = true;
            label_PCreateId.Location = new Point(71, 66);
            label_PCreateId.Name = "label_PCreateId";
            label_PCreateId.Size = new Size(20, 15);
            label_PCreateId.TabIndex = 0;
            label_PCreateId.Text = "Id:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(777, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(777, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Show All";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // numericUpDown_PCreateAmount
            // 
            numericUpDown_PCreateAmount.Location = new Point(130, 154);
            numericUpDown_PCreateAmount.Name = "numericUpDown_PCreateAmount";
            numericUpDown_PCreateAmount.Size = new Size(120, 23);
            numericUpDown_PCreateAmount.TabIndex = 9;
            // 
            // numericUpDown_PCreatePrice
            // 
            numericUpDown_PCreatePrice.Location = new Point(130, 185);
            numericUpDown_PCreatePrice.Name = "numericUpDown_PCreatePrice";
            numericUpDown_PCreatePrice.Size = new Size(120, 23);
            numericUpDown_PCreatePrice.TabIndex = 10;
            // 
            // ManagmentProductMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ManagmentProductMenu";
            Text = "ManagmentProductMenu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PCreateAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PCreatePrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label_PCreateAmount;
        private Label label_PCreateCategory;
        private Label label_PCreateName;
        private Label label_PCreateId;
        private Label label_PCreatePrice;
        private ComboBox comboBox_PCreateCategory;
        private TextBox textBox_PCreateName;
        private TextBox textBox_PcreateId;
        private Button button_AddProduct;
        private NumericUpDown numericUpDown_PCreatePrice;
        private NumericUpDown numericUpDown_PCreateAmount;
    }
}