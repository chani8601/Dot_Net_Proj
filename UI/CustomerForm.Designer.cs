namespace UI
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            productsPanelInCus = new FlowLayoutPanel();
            cartPanel = new Panel();
            btnPay = new Button();
            lblTotal = new Label();
            cartGrid = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            Column1Name = new DataGridViewTextBoxColumn();
            Column1Quantity = new DataGridViewTextBoxColumn();
            Column1Price = new DataGridViewTextBoxColumn();
            Column1IfSale = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnAddById = new Button();
            txtProductId = new TextBox();
            lblAddById = new Label();
            cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            SuspendLayout();
            // 
            // productsPanelInCus
            // 
            productsPanelInCus.AutoScroll = true;
            productsPanelInCus.BackColor = Color.WhiteSmoke;
            productsPanelInCus.Dock = DockStyle.Left;
            productsPanelInCus.Location = new Point(0, 0);
            productsPanelInCus.Name = "productsPanelInCus";
            productsPanelInCus.Size = new Size(600, 600);
            productsPanelInCus.TabIndex = 0;
            // 
            // cartPanel
            // 
            cartPanel.Controls.Add(btnPay);
            cartPanel.Controls.Add(lblTotal);
            cartPanel.Controls.Add(cartGrid);
            cartPanel.Controls.Add(btnAddById);
            cartPanel.Controls.Add(txtProductId);
            cartPanel.Controls.Add(lblAddById);
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(600, 0);
            cartPanel.Name = "cartPanel";
            cartPanel.Padding = new Padding(10);
            cartPanel.Size = new Size(600, 600);
            cartPanel.TabIndex = 1;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnPay.Location = new Point(10, 450);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(200, 45);
            btnPay.TabIndex = 2;
            btnPay.Text = "Close Order";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 425);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(116, 29);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: ₪0";
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnId, Column1Name, Column1Quantity, Column1Price, Column1IfSale, Column1 });
            cartGrid.Dock = DockStyle.Top;
            cartGrid.Location = new Point(10, 10);
            cartGrid.Name = "cartGrid";
            cartGrid.RowHeadersWidth = 51;
            cartGrid.Size = new Size(580, 400);
            cartGrid.TabIndex = 0;
            cartGrid.CellContentClick += cartGrid_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "ID";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            ColumnId.Width = 50;
            // 
            // Column1Name
            // 
            Column1Name.HeaderText = "Name";
            Column1Name.MinimumWidth = 6;
            Column1Name.Name = "Column1Name";
            // 
            // Column1Quantity
            // 
            Column1Quantity.HeaderText = "Quantity";
            Column1Quantity.MinimumWidth = 6;
            Column1Quantity.Name = "Column1Quantity";
            Column1Quantity.Width = 80;
            // 
            // Column1Price
            // 
            Column1Price.HeaderText = "Price";
            Column1Price.MinimumWidth = 6;
            Column1Price.Name = "Column1Price";
            Column1Price.Width = 80;
            // 
            // Column1IfSale
            // 
            Column1IfSale.HeaderText = "IfSale";
            Column1IfSale.MinimumWidth = 6;
            Column1IfSale.Name = "Column1IfSale";
            Column1IfSale.Width = 80;
            // 
            // Column1
            // 
            Column1.HeaderText = "TotalPrice";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // btnAddById
            // 
            btnAddById.Font = new Font("Arial", 10F);
            btnAddById.Location = new Point(200, 500);
            btnAddById.Name = "btnAddById";
            btnAddById.Size = new Size(100, 30);
            btnAddById.TabIndex = 4;
            btnAddById.Text = "Add";
            btnAddById.UseVisualStyleBackColor = true;
            btnAddById.Click += btnAddById_Click;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Arial", 10F);
            txtProductId.Location = new Point(90, 502);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 27);
            txtProductId.TabIndex = 3;
            // 
            // lblAddById
            // 
            lblAddById.AutoSize = true;
            lblAddById.Font = new Font("Arial", 10F);
            lblAddById.Location = new Point(20, 515);
            lblAddById.Name = "lblAddById";
            lblAddById.Size = new Size(88, 19);
            lblAddById.TabIndex = 5;
            lblAddById.Text = "Add by ID:";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(cartPanel);
            Controls.Add(productsPanelInCus);
            Name = "CustomerForm";
            Text = "Customer Screen";
            WindowState = FormWindowState.Maximized;
            cartPanel.ResumeLayout(false);
            cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel productsPanelInCus;
        private Panel cartPanel;
        private DataGridView cartGrid;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn Column1Name;
        private DataGridViewTextBoxColumn Column1Quantity;
        private DataGridViewTextBoxColumn Column1Price;
        private DataGridViewTextBoxColumn Column1IfSale;
        private DataGridViewTextBoxColumn Column1;
        private Label lblTotal;
        private Button btnPay;
        private TextBox txtProductId;
        private Button btnAddById;
        private Label lblAddById;
    }
}
