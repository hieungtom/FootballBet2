namespace FootballBetTwo
{
    partial class RegistrForm
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
            lblHeslo = new Label();
            lblUziv = new Label();
            lblNadpis = new Label();
            txbHeslo = new TextBox();
            txbUsername = new TextBox();
            btnRegistr = new Button();
            lblOvereni = new Label();
            txbOvereniHesla = new TextBox();
            SuspendLayout();
            // 
            // lblHeslo
            // 
            lblHeslo.AutoSize = true;
            lblHeslo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblHeslo.Location = new Point(63, 187);
            lblHeslo.Name = "lblHeslo";
            lblHeslo.Size = new Size(41, 17);
            lblHeslo.TabIndex = 11;
            lblHeslo.Text = "Heslo";
            // 
            // lblUziv
            // 
            lblUziv.AutoSize = true;
            lblUziv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblUziv.Location = new Point(63, 118);
            lblUziv.Name = "lblUziv";
            lblUziv.Size = new Size(112, 17);
            lblUziv.TabIndex = 10;
            lblUziv.Text = "Uživatelské jméno";
            // 
            // lblNadpis
            // 
            lblNadpis.AutoSize = true;
            lblNadpis.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNadpis.Location = new Point(83, 41);
            lblNadpis.Name = "lblNadpis";
            lblNadpis.Size = new Size(202, 50);
            lblNadpis.TabIndex = 9;
            lblNadpis.Text = "Registrace";
            // 
            // txbHeslo
            // 
            txbHeslo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbHeslo.Location = new Point(63, 209);
            txbHeslo.Margin = new Padding(5);
            txbHeslo.Name = "txbHeslo";
            txbHeslo.PlaceholderText = "*******";
            txbHeslo.Size = new Size(237, 29);
            txbHeslo.TabIndex = 8;
            txbHeslo.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbUsername.Location = new Point(63, 140);
            txbUsername.Margin = new Padding(5);
            txbUsername.Name = "txbUsername";
            txbUsername.PlaceholderText = "Username";
            txbUsername.Size = new Size(237, 29);
            txbUsername.TabIndex = 7;
            // 
            // btnRegistr
            // 
            btnRegistr.BackColor = Color.Orange;
            btnRegistr.FlatStyle = FlatStyle.Flat;
            btnRegistr.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRegistr.ForeColor = Color.White;
            btnRegistr.Location = new Point(63, 354);
            btnRegistr.Name = "btnRegistr";
            btnRegistr.Size = new Size(237, 54);
            btnRegistr.TabIndex = 6;
            btnRegistr.TabStop = false;
            btnRegistr.Text = "Registrovat se";
            btnRegistr.UseVisualStyleBackColor = false;
            btnRegistr.Click += btnRegistr_Click;
            // 
            // lblOvereni
            // 
            lblOvereni.AutoSize = true;
            lblOvereni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblOvereni.Location = new Point(63, 256);
            lblOvereni.Name = "lblOvereni";
            lblOvereni.Size = new Size(113, 17);
            lblOvereni.TabIndex = 13;
            lblOvereni.Text = "Heslo pro ověření";
            // 
            // txbOvereniHesla
            // 
            txbOvereniHesla.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbOvereniHesla.Location = new Point(63, 278);
            txbOvereniHesla.Margin = new Padding(5);
            txbOvereniHesla.Name = "txbOvereniHesla";
            txbOvereniHesla.PlaceholderText = "*******";
            txbOvereniHesla.Size = new Size(237, 29);
            txbOvereniHesla.TabIndex = 12;
            txbOvereniHesla.UseSystemPasswordChar = true;
            // 
            // RegistrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 444);
            Controls.Add(lblOvereni);
            Controls.Add(txbOvereniHesla);
            Controls.Add(lblHeslo);
            Controls.Add(lblUziv);
            Controls.Add(lblNadpis);
            Controls.Add(txbHeslo);
            Controls.Add(txbUsername);
            Controls.Add(btnRegistr);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeslo;
        private Label lblUziv;
        private Label lblNadpis;
        private TextBox txbHeslo;
        private TextBox txbUsername;
        private Button btnRegistr;
        private Label lblOvereni;
        private TextBox txbOvereniHesla;
    }
}