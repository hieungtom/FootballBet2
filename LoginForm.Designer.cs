namespace FootballBetTwo
{
    partial class LoginForm
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
            btnLogin = new Button();
            txbUsername = new TextBox();
            txbHeslo = new TextBox();
            lblNadpis = new Label();
            lblUziv = new Label();
            lblHeslo = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Orange;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(62, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(237, 54);
            btnLogin.TabIndex = 0;
            btnLogin.TabStop = false;
            btnLogin.Text = "Přihlásit se";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbUsername.Location = new Point(62, 141);
            txbUsername.Margin = new Padding(5);
            txbUsername.Name = "txbUsername";
            txbUsername.PlaceholderText = "Username";
            txbUsername.Size = new Size(237, 29);
            txbUsername.TabIndex = 1;
            // 
            // txbHeslo
            // 
            txbHeslo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbHeslo.Location = new Point(62, 210);
            txbHeslo.Margin = new Padding(5);
            txbHeslo.Name = "txbHeslo";
            txbHeslo.PlaceholderText = "*******";
            txbHeslo.Size = new Size(237, 29);
            txbHeslo.TabIndex = 2;
            txbHeslo.UseSystemPasswordChar = true;
            // 
            // lblNadpis
            // 
            lblNadpis.AutoSize = true;
            lblNadpis.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNadpis.Location = new Point(84, 42);
            lblNadpis.Name = "lblNadpis";
            lblNadpis.Size = new Size(193, 50);
            lblNadpis.TabIndex = 3;
            lblNadpis.Text = "Přihlášení";
            // 
            // lblUziv
            // 
            lblUziv.AutoSize = true;
            lblUziv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUziv.Location = new Point(62, 119);
            lblUziv.Name = "lblUziv";
            lblUziv.Size = new Size(112, 17);
            lblUziv.TabIndex = 4;
            lblUziv.Text = "Uživatelské jméno";
            // 
            // lblHeslo
            // 
            lblHeslo.AutoSize = true;
            lblHeslo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblHeslo.Location = new Point(62, 188);
            lblHeslo.Name = "lblHeslo";
            lblHeslo.Size = new Size(41, 17);
            lblHeslo.TabIndex = 5;
            lblHeslo.Text = "Heslo";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 370);
            Controls.Add(lblHeslo);
            Controls.Add(lblUziv);
            Controls.Add(lblNadpis);
            Controls.Add(txbHeslo);
            Controls.Add(txbUsername);
            Controls.Add(btnLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Přihlášení";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txbUsername;
        private TextBox txbHeslo;
        private Label lblNadpis;
        private Label lblUziv;
        private Label lblHeslo;
    }
}