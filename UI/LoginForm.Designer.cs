namespace UI
{
    partial class LoginForm
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
            txtId = new TextBox();
            btnEnter = new Button();
            btnGuest = new Button();
            lblTitle = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new Point(150, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.Text = "Welcome!";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font("Arial", 12);
            lblId.Location = new Point(100, 120);
            lblId.Name = "lblId";
            lblId.Text = "Customer ID:";
            // 
            // txtId
            // 
            txtId.Font = new System.Drawing.Font("Arial", 12);
            txtId.Location = new Point(230, 117);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 30);
            txtId.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            btnEnter.Location = new Point(130, 180);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(150, 40);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnGuest
            // 
            btnGuest.Font = new System.Drawing.Font("Arial", 12);
            btnGuest.Location = new Point(300, 180);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 40);
            btnGuest.TabIndex = 2;
            btnGuest.Text = "Enter as Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 280);
            Controls.Add(lblTitle);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnEnter);
            Controls.Add(btnGuest);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Button btnEnter;
        private Button btnGuest;
        private Label lblTitle;
        private Label lblId;
    }
}
