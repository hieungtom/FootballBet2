using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace FootballBetTwo
{
    public partial class BetApp : Form
    {
        private Ucet PrihlasenyUcet { get; set; }
        private Tiket tiket = new Tiket();

        public BetApp()
        {
            InitializeComponent();
            //propojeni zapasu z databaze s data gridem
            dgvZapasy.DataSource = Databaze.Zapasy;
            dgvZapasy.Columns["Vysledek"].Visible = false;

            //skryti funkci pro neprihlaseneho uzivatele
            if (PrihlasenyUcet == null)
            {
                pnlUcet.Visible = false;
                dgvZapasy.Enabled = false;
                pnlTiket.Visible = false;
            }
        }

        private void AktualizujCastku()
        {
            lblZustatek.Text = $"{PrihlasenyUcet.Zustatek:F2}";
            txbVlozit.Text = null;
            txbVybrat.Text = null;
        }

        private void ZmenZustatek(decimal castka, bool vklad)
        {
            if (vklad) //vklad
                PrihlasenyUcet.Zustatek += castka;
            else if (castka <= PrihlasenyUcet.Zustatek) //vyber
                PrihlasenyUcet.Zustatek -= castka;
            else
                MessageBox.Show("Èástka je vyšší než váš aktuální zùstatek!");
            AktualizujCastku();
        }

        private void btnVlozit_Click(object sender, EventArgs e)
        {
            //overeni vstupu
            if (decimal.TryParse(txbVlozit.Text, out decimal castka) && castka > 0)
                ZmenZustatek(castka, true);
            else
                MessageBox.Show("Nesprávná hodnota!");
        }

        private void btnVybrat_Click(object sender, EventArgs e)
        {
            //overeni vstupu
            if (decimal.TryParse(txbVybrat.Text, out decimal castka) && castka > 0)
                ZmenZustatek(castka, false);
            else
                MessageBox.Show("Nesprávná hodnota!");
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                //overeni existujiciho uzivatele a jeho hesla
                var uzivatel = Databaze.OverUzivatele(loginForm.Username.ToLower(), loginForm.Heslo);

                if (uzivatel != null)
                {
                    PrihlasenyUcet = uzivatel;
                    lblUzivatel.Text = $"{uzivatel.Username}";
                    lblZustatek.Text = $"{uzivatel.Zustatek:F2}";
                    pnlUcet.Visible = true;
                    btnLoginForm.Visible = false;
                    btnRegistrForm.Visible = false;
                    dgvZapasy.Enabled = true;
                    pnlTiket.Visible = true;
                }
                else
                    MessageBox.Show("Nesprávné pøihlašovací údaje.");
            }
        }

        private void BetApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Databaze.Serializuj();
        }

        private void dgvZapasy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var vybranaBunka = dgvZapasy.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var vybranyRadek = dgvZapasy.Rows[e.RowIndex];
                string nazevSloupce = dgvZapasy.Columns[e.ColumnIndex].Name;

                if (nazevSloupce == "KurzDomaci" || nazevSloupce == "KurzRemiza" || nazevSloupce == "KurzHoste")
                {
                    var zapas = (Zapas)vybranyRadek.DataBoundItem;
                    string zvolenaPrilezitost;
                    decimal vybranyKurz = (decimal)vybranaBunka.Value;

                    //ulozeni typu vyybrane prilezitosti
                    switch (nazevSloupce)
                    {
                        case "KurzDomaci":
                            zvolenaPrilezitost = "domaci";
                            break;
                        case "KurzRemiza":
                            zvolenaPrilezitost = "remiza";
                            break;
                        case "KurzHoste":
                            zvolenaPrilezitost = "hoste";
                            break;
                        default:
                            return;
                    }
                    var prilezitost = new Prilezitost { Zapas = zapas, ZvolenaPrilezitost = zvolenaPrilezitost, VybranyKurz = vybranyKurz };
                    var vybranyZapas = (Prilezitost)vybranyRadek.Tag;

                    if (vybranyZapas == null) //kontrola jestli se jiz dany zapas nevybral
                    {
                        tiket.PridejPrilezitost(prilezitost); //pridani prilezitosti
                        vybranyRadek.Tag = prilezitost;
                        vybranaBunka.Style.BackColor = Color.DodgerBlue;
                        vybranaBunka.Style.ForeColor = Color.White;
                    }
                    else if (vybranyZapas.ZvolenaPrilezitost == zvolenaPrilezitost) //kliknuti na jiz vybranou prilezitost
                    {
                        tiket.OdeberPrilezitost(vybranyZapas); //odstraneni vybrane prilezitosti
                        vybranyRadek.Tag = null;
                        vybranaBunka.Style.BackColor = Color.White;
                        vybranaBunka.Style.ForeColor = Color.Black;
                    }
                    else
                        MessageBox.Show("Na tento zápas již máte vybranou jinou pøíležitost.");
                    lblKurz.Text = $"{tiket.CelkovyKurz:F2}";
                }
            }
        }

        private async void btnVsadit_Click(object sender, EventArgs e)
        {
            if (tiket.CelkovyKurz == 1)
            {
                MessageBox.Show("Na tiketu nemáte vybrané pøíležitosti!");
                return;
            }
            if (decimal.TryParse(txbVsadit.Text, out decimal castka) && castka > 0)
            {
                if (castka > PrihlasenyUcet.Zustatek)
                {
                    MessageBox.Show("Nemáte dostateèný zùstatek!");
                    return;
                }
                PrihlasenyUcet.Zustatek -= castka;
                tiket.Castka = castka;
                MessageBox.Show($"Sázka pøijata!\nCelkový kurz: {tiket.CelkovyKurz:F2}\nMožná výhra: {tiket.MoznaVyhra:F2}");
                lblZustatek.Text = $"{PrihlasenyUcet.Zustatek:F2}";
                await Task.Delay(2000);
                vyhodnotTiket();
            }
            else
                MessageBox.Show("Nesprávná èástka!");
        }

        private void vyhodnotTiket()
        {
            if (tiket.JeVyherni())
            {
                decimal vyhra = tiket.MoznaVyhra;
                PrihlasenyUcet.Zustatek += vyhra;
                MessageBox.Show($"Gratulujeme! Vyhráli jste {vyhra:F2}!");
            }
            else
                MessageBox.Show("Bohužel, tiket není výherní.");
            tiket = new Tiket();
            lblKurz.Text = "";
            lblZustatek.Text = $"{PrihlasenyUcet.Zustatek:F2}";
            foreach (DataGridViewRow row in dgvZapasy.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                }
                row.Tag = null;
            }
        }

        private void btnRegistrForm_Click(object sender, EventArgs e)
        {
            RegistrForm registrForm = new RegistrForm();

            if (registrForm.ShowDialog() == DialogResult.OK)
            {
                Databaze.Ucty.Add(registrForm.NovyUcet);
            }
        }
    }
}
