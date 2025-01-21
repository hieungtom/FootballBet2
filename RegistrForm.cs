using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FootballBetTwo
{
    public partial class RegistrForm : Form
    {
        public Ucet NovyUcet { get; set; }
        public string Username => txbUsername.Text.ToLower();
        public string Heslo => txbHeslo.Text;
        public string OvereniHesla => txbOvereniHesla.Text;

        public RegistrForm()
        {
            InitializeComponent();
            NovyUcet = new Ucet();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            var hashHesla = Hash.VytvorHash(Heslo);
            var hashOvereniHesla = Hash.VytvorHash(OvereniHesla);

            var uzivatel = Databaze.Ucty.FirstOrDefault(u => u.Username == Username);
            if (uzivatel != null)
            {
                MessageBox.Show("Uživatel již existuje!");
                return;
            }

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Heslo) || string.IsNullOrWhiteSpace(OvereniHesla))
            {
                MessageBox.Show("Všechna pole musí být vyplněna!");
                return;
            }

            if (hashHesla == hashOvereniHesla)
            {
                NovyUcet.Username = txbUsername.Text;
                NovyUcet.Heslo = hashHesla;
                NovyUcet.Zustatek = 0m;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Hesla se neshodují!");
        }
    }
}
