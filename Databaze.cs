using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FootballBetTwo
{
    public static class Databaze
    {
        public static BindingList<Ucet> Ucty { get; private set; } = new BindingList<Ucet>();
        public static BindingList<Zapas> Zapasy { get; private set; } = new BindingList<Zapas>();
        private const string _souborUcty = "ucty.xml";
        private const string _souborZapasy = "zapasy.xml";
        static Databaze()
        {
            Deserializuj();
        }

        public static void Serializuj()
        {
            try
            {
                SerializujList(Ucty, _souborUcty);
                SerializujList(Zapasy, _souborZapasy);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Chyba při serializaci: {e.Message}");
            }
        }

        public static void SerializujList<T>(BindingList<T> list, string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(list.GetType());
                x.Serialize(s, list);
            }
        }

        public static void Deserializuj()
        {
            try
            {
                Ucty = DeserializujList<Ucet>(_souborUcty);
                Zapasy = DeserializujList<Zapas>(_souborZapasy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static BindingList<T>DeserializujList<T>(string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(BindingList<T>));
                return (BindingList<T>)x.Deserialize(s);
            }
        }

        public static Ucet? OverUzivatele(string username, string heslo)
        {
            //nalezeni shody username
            var uzivatel = Ucty.FirstOrDefault(u => u.Username == username);

            if (uzivatel != null)
            {
                var hashHesla = Hash.VytvorHash(heslo);
                //overeni hashovaneho hesla
                if (uzivatel.Heslo == hashHesla)
                    return uzivatel;
            }
            return null;
        }
    }
}
