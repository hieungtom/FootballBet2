namespace FootballBetTwo
{
    public partial class BetApp : Form
    {
        public BetApp()
        {
            InitializeComponent();
            dgvZapasy.DataSource = Databaze.Zapasy;
            dgvZapasy.Columns["Vysledek"].Visible = false;
            
        }
    }
}
