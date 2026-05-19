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
            cartGrid = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            Column1Name = new DataGridViewTextBoxColumn();
            Column1Quantity = new DataGridViewTextBoxColumn();
            Column1Price = new DataGridViewTextBoxColumn();
            Column1IfSale = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            SuspendLayout();
            // 
            // productsPanelInCus
            // 
            productsPanelInCus.AutoScroll = true;
            productsPanelInCus.BackColor = System.Drawing.Color.WhiteSmoke;
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
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(600, 0);
            cartPanel.Name = "cartPanel";
            cartPanel.Padding = new Padding(10);
            cartPanel.TabIndex = 1;
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnId, Column1Name, Column1Quantity, Column1Price, Column1IfSale, Column1 });
            cartGrid.Dock = DockStyle.Top;
            cartGrid.Height = 400;
            cartGrid.Name = "cartGrid";
            cartGrid.RowHeadersWidth = 51;
            cartGrid.TabIndex = 0;
            cartGrid.CellContentClick += cartGrid_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            ColumnId.Visible = false;
            ColumnId.Width = 50;
            // 
            // Column1Name
            // 
            Column1Name.HeaderText = "Name";
            Column1Name.Name = "Column1Name";
            Column1Name.Width = 100;
            // 
            // Column1Quantity
            // 
            Column1Quantity.HeaderText = "Quantity";
            Column1Quantity.Name = "Column1Quantity";
            Column1Quantity.Width = 80;
            // 
            // Column1Price
            // 
            Column1Price.HeaderText = "Price";
            Column1Price.Name = "Column1Price";
            Column1Price.Width = 80;
            // 
            // Column1IfSale
            // 
            Column1IfSale.HeaderText = "IfSale";
            Column1IfSale.Name = "Column1IfSale";
            Column1IfSale.Width = 80;
            // 
            // Column1
            // 
            Column1.HeaderText = "TotalPrice";
            Column1.Name = "Column1";
            Column1.Width = 100;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblTotal.Location = new Point(10, 415);
            lblTotal.Name = "lblTotal";
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: ₪0";
            // 
            // btnPay
            // 
            btnPay.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            btnPay.Location = new Point(10, 450);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(200, 45);
            btnPay.TabIndex = 2;
            btnPay.Text = "Close Order";
            btnPay.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
