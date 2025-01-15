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
            dgvZapasy = new DataGridView();
            lblZustatek = new Label();
            lblUziv = new Label();
            btnVsadit = new Button();
            btnVlozit = new Button();
            btnVybrat = new Button();
            tbxVlozit = new TextBox();
            txbVybrat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvZapasy).BeginInit();
            SuspendLayout();
            // 
            // dgvZapasy
            // 
            dgvZapasy.AllowUserToAddRows = false;
            dgvZapasy.AllowUserToDeleteRows = false;
            dgvZapasy.AllowUserToResizeColumns = false;
            dgvZapasy.AllowUserToResizeRows = false;
            dgvZapasy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZapasy.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvZapasy.ImeMode = ImeMode.Off;
            dgvZapasy.Location = new Point(12, 12);
            dgvZapasy.MultiSelect = false;
            dgvZapasy.Name = "dgvZapasy";
            dgvZapasy.RowHeadersVisible = false;
            dgvZapasy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvZapasy.Size = new Size(543, 477);
            dgvZapasy.TabIndex = 0;
            // 
            // lblZustatek
            // 
            lblZustatek.AutoSize = true;
            lblZustatek.Location = new Point(764, 25);
            lblZustatek.Name = "lblZustatek";
            lblZustatek.Size = new Size(52, 15);
            lblZustatek.TabIndex = 1;
            lblZustatek.Text = "Zustatek";
            // 
            // lblUziv
            // 
            lblUziv.AutoSize = true;
            lblUziv.Location = new Point(614, 25);
            lblUziv.Name = "lblUziv";
            lblUziv.Size = new Size(48, 15);
            lblUziv.TabIndex = 2;
            lblUziv.Text = "Uzivatel";
            // 
            // btnVsadit
            // 
            btnVsadit.Location = new Point(766, 458);
            btnVsadit.Name = "btnVsadit";
            btnVsadit.Size = new Size(69, 35);
            btnVsadit.TabIndex = 3;
            btnVsadit.Text = "Vsadit";
            btnVsadit.UseVisualStyleBackColor = true;
            // 
            // btnVlozit
            // 
            btnVlozit.Location = new Point(614, 122);
            btnVlozit.Name = "btnVlozit";
            btnVlozit.Size = new Size(69, 35);
            btnVlozit.TabIndex = 4;
            btnVlozit.Text = "Vložit";
            btnVlozit.UseVisualStyleBackColor = true;
            // 
            // btnVybrat
            // 
            btnVybrat.Location = new Point(764, 122);
            btnVybrat.Name = "btnVybrat";
            btnVybrat.Size = new Size(69, 35);
            btnVybrat.TabIndex = 5;
            btnVybrat.Text = "Vybrat";
            btnVybrat.UseVisualStyleBackColor = true;
            // 
            // tbxVlozit
            // 
            tbxVlozit.Location = new Point(614, 89);
            tbxVlozit.Name = "tbxVlozit";
            tbxVlozit.Size = new Size(69, 23);
            tbxVlozit.TabIndex = 6;
            // 
            // txbVybrat
            // 
            txbVybrat.Location = new Point(764, 89);
            txbVybrat.Name = "txbVybrat";
            txbVybrat.Size = new Size(69, 23);
            txbVybrat.TabIndex = 7;
            // 
            // BetApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 501);
            Controls.Add(txbVybrat);
            Controls.Add(tbxVlozit);
            Controls.Add(btnVybrat);
            Controls.Add(btnVlozit);
            Controls.Add(btnVsadit);
            Controls.Add(lblUziv);
            Controls.Add(lblZustatek);
            Controls.Add(dgvZapasy);
            Name = "BetApp";
            ShowIcon = false;
            Text = "Bettoo";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvZapasy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvZapasy;
        private Label lblZustatek;
        private Label lblUziv;
        private Button btnVsadit;
        private Button btnVlozit;
        private Button btnVybrat;
        private TextBox tbxVlozit;
        private TextBox txbVybrat;
    }
}
