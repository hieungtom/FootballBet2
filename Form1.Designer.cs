namespace FootballBetTwo
{
    partial class BetApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvZapasy = new DataGridView();
            lblZustatek = new Label();
            lblUzivatel = new Label();
            btnVlozit = new Button();
            btnVybrat = new Button();
            txbVlozit = new TextBox();
            txbVybrat = new TextBox();
            btnLoginForm = new Button();
            pnlUcet = new Panel();
            lblKurz = new Label();
            btnVsadit = new Button();
            pnlTiket = new Panel();
            txbVsadit = new TextBox();
            btnRegistrForm = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvZapasy).BeginInit();
            pnlUcet.SuspendLayout();
            pnlTiket.SuspendLayout();
            SuspendLayout();
            // 
            // dgvZapasy
            // 
            dgvZapasy.AllowUserToAddRows = false;
            dgvZapasy.AllowUserToDeleteRows = false;
            dgvZapasy.AllowUserToResizeColumns = false;
            dgvZapasy.AllowUserToResizeRows = false;
            dgvZapasy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZapasy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvZapasy.BackgroundColor = SystemColors.Control;
            dgvZapasy.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvZapasy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvZapasy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = Color.DodgerBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvZapasy.DefaultCellStyle = dataGridViewCellStyle6;
            dgvZapasy.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvZapasy.ImeMode = ImeMode.Off;
            dgvZapasy.Location = new Point(67, 121);
            dgvZapasy.MultiSelect = false;
            dgvZapasy.Name = "dgvZapasy";
            dgvZapasy.RowHeadersVisible = false;
            dgvZapasy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvZapasy.ShowCellErrors = false;
            dgvZapasy.ShowCellToolTips = false;
            dgvZapasy.ShowEditingIcon = false;
            dgvZapasy.ShowRowErrors = false;
            dgvZapasy.Size = new Size(676, 499);
            dgvZapasy.TabIndex = 0;
            dgvZapasy.CellClick += dgvZapasy_CellClick;
            // 
            // lblZustatek
            // 
            lblZustatek.AutoSize = true;
            lblZustatek.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblZustatek.Location = new Point(136, 35);
            lblZustatek.Name = "lblZustatek";
            lblZustatek.Padding = new Padding(5);
            lblZustatek.Size = new Size(96, 35);
            lblZustatek.TabIndex = 1;
            lblZustatek.Text = "Zustatek";
            lblZustatek.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUzivatel
            // 
            lblUzivatel.AutoSize = true;
            lblUzivatel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUzivatel.Location = new Point(141, 0);
            lblUzivatel.Name = "lblUzivatel";
            lblUzivatel.Padding = new Padding(5);
            lblUzivatel.RightToLeft = RightToLeft.No;
            lblUzivatel.Size = new Size(91, 35);
            lblUzivatel.TabIndex = 2;
            lblUzivatel.Text = "Uzivatel";
            lblUzivatel.TextAlign = ContentAlignment.TopRight;
            // 
            // btnVlozit
            // 
            btnVlozit.BackColor = Color.Orange;
            btnVlozit.FlatStyle = FlatStyle.Flat;
            btnVlozit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVlozit.ForeColor = Color.White;
            btnVlozit.Location = new Point(169, 75);
            btnVlozit.Name = "btnVlozit";
            btnVlozit.Padding = new Padding(5);
            btnVlozit.Size = new Size(81, 42);
            btnVlozit.TabIndex = 4;
            btnVlozit.TabStop = false;
            btnVlozit.Text = "Vložit";
            btnVlozit.UseVisualStyleBackColor = false;
            btnVlozit.Click += btnVlozit_Click;
            // 
            // btnVybrat
            // 
            btnVybrat.BackColor = Color.Orange;
            btnVybrat.FlatStyle = FlatStyle.Flat;
            btnVybrat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVybrat.ForeColor = Color.White;
            btnVybrat.Location = new Point(169, 135);
            btnVybrat.Name = "btnVybrat";
            btnVybrat.Padding = new Padding(5);
            btnVybrat.Size = new Size(81, 42);
            btnVybrat.TabIndex = 5;
            btnVybrat.TabStop = false;
            btnVybrat.Text = "Vybrat";
            btnVybrat.UseVisualStyleBackColor = false;
            btnVybrat.Click += btnVybrat_Click;
            // 
            // txbVlozit
            // 
            txbVlozit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbVlozit.Location = new Point(49, 83);
            txbVlozit.Name = "txbVlozit";
            txbVlozit.Size = new Size(105, 29);
            txbVlozit.TabIndex = 6;
            // 
            // txbVybrat
            // 
            txbVybrat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txbVybrat.Location = new Point(49, 143);
            txbVybrat.Name = "txbVybrat";
            txbVybrat.Size = new Size(105, 29);
            txbVybrat.TabIndex = 7;
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.Orange;
            btnLoginForm.FlatAppearance.BorderSize = 0;
            btnLoginForm.FlatStyle = FlatStyle.Flat;
            btnLoginForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLoginForm.ForeColor = Color.White;
            btnLoginForm.Location = new Point(961, 46);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.Padding = new Padding(5);
            btnLoginForm.Size = new Size(105, 43);
            btnLoginForm.TabIndex = 8;
            btnLoginForm.TabStop = false;
            btnLoginForm.Text = "Přihlášení";
            btnLoginForm.UseVisualStyleBackColor = false;
            btnLoginForm.Click += btnLoginForm_Click;
            // 
            // pnlUcet
            // 
            pnlUcet.Controls.Add(btnVybrat);
            pnlUcet.Controls.Add(txbVybrat);
            pnlUcet.Controls.Add(txbVlozit);
            pnlUcet.Controls.Add(lblUzivatel);
            pnlUcet.Controls.Add(btnVlozit);
            pnlUcet.Controls.Add(lblZustatek);
            pnlUcet.Location = new Point(820, 46);
            pnlUcet.Name = "pnlUcet";
            pnlUcet.Size = new Size(248, 177);
            pnlUcet.TabIndex = 9;
            // 
            // lblKurz
            // 
            lblKurz.AutoSize = true;
            lblKurz.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblKurz.Location = new Point(78, 137);
            lblKurz.Name = "lblKurz";
            lblKurz.Padding = new Padding(5);
            lblKurz.Size = new Size(10, 31);
            lblKurz.TabIndex = 8;
            // 
            // btnVsadit
            // 
            btnVsadit.BackColor = Color.Orange;
            btnVsadit.FlatStyle = FlatStyle.Flat;
            btnVsadit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnVsadit.ForeColor = Color.White;
            btnVsadit.Location = new Point(177, 180);
            btnVsadit.Name = "btnVsadit";
            btnVsadit.Padding = new Padding(5);
            btnVsadit.Size = new Size(81, 42);
            btnVsadit.TabIndex = 8;
            btnVsadit.TabStop = false;
            btnVsadit.Text = "Vsadit";
            btnVsadit.UseVisualStyleBackColor = false;
            btnVsadit.Click += btnVsadit_Click;
            // 
            // pnlTiket
            // 
            pnlTiket.Controls.Add(txbVsadit);
            pnlTiket.Controls.Add(lblKurz);
            pnlTiket.Controls.Add(btnVsadit);
            pnlTiket.Location = new Point(810, 398);
            pnlTiket.Name = "pnlTiket";
            pnlTiket.Size = new Size(256, 222);
            pnlTiket.TabIndex = 10;
            // 
            // txbVsadit
            // 
            txbVsadit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txbVsadit.Location = new Point(59, 188);
            txbVsadit.Name = "txbVsadit";
            txbVsadit.Size = new Size(103, 29);
            txbVsadit.TabIndex = 9;
            // 
            // btnRegistrForm
            // 
            btnRegistrForm.BackColor = Color.LightGray;
            btnRegistrForm.FlatAppearance.BorderSize = 0;
            btnRegistrForm.FlatStyle = FlatStyle.Flat;
            btnRegistrForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRegistrForm.ForeColor = Color.White;
            btnRegistrForm.Location = new Point(845, 46);
            btnRegistrForm.Name = "btnRegistrForm";
            btnRegistrForm.Padding = new Padding(5);
            btnRegistrForm.Size = new Size(110, 43);
            btnRegistrForm.TabIndex = 11;
            btnRegistrForm.TabStop = false;
            btnRegistrForm.Text = "Registrace";
            btnRegistrForm.UseVisualStyleBackColor = false;
            btnRegistrForm.Click += btnRegistrForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(334, 46);
            label1.Name = "label1";
            label1.Size = new Size(145, 50);
            label1.TabIndex = 12;
            label1.Text = "BetToo";
            // 
            // BetApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1124, 669);
            Controls.Add(label1);
            Controls.Add(btnRegistrForm);
            Controls.Add(pnlTiket);
            Controls.Add(btnLoginForm);
            Controls.Add(pnlUcet);
            Controls.Add(dgvZapasy);
            Name = "BetApp";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bettoo";
            FormClosed += BetApp_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvZapasy).EndInit();
            pnlUcet.ResumeLayout(false);
            pnlUcet.PerformLayout();
            pnlTiket.ResumeLayout(false);
            pnlTiket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvZapasy;
        private Label lblZustatek;
        private Label lblUzivatel;
        private Button btnVlozit;
        private Button btnVybrat;
        private TextBox txbVlozit;
        private TextBox txbVybrat;
        private Button btnLoginForm;
        private Panel pnlUcet;
        private Label lblKurz;
        private Button btnVsadit;
        private Panel pnlTiket;
        private TextBox txbVsadit;
        private Button btnRegistrForm;
        private Label label1;
    }
}
