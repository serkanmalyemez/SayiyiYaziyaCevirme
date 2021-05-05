using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YaziyaCevirme
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIslem_Click(object sender, EventArgs e)
        {
            bool hata = false;
            string gelenSayi = txbSayi.Text;
            for (int i = 0; i < gelenSayi.Length; i++)
            {
                try
                {
                    int karakter = Convert.ToInt32(gelenSayi.Substring(i, 1));
                }
                catch
                {
                    hata = true;
                    i = gelenSayi.Length;
                }
            }

            if (!hata)
            {
                int karakterSayisi = gelenSayi.Length % 3;
                if (karakterSayisi > 0)
                {
                    karakterSayisi = 3 - karakterSayisi;
                }

                string tamamlamaKarakteri = "";
                for (int i = 0; i < karakterSayisi; i++)
                {
                    tamamlamaKarakteri += "0";
                }
                gelenSayi = tamamlamaKarakteri + gelenSayi;

                int diziSayisi = gelenSayi.Length / 3;
                int[] sayilar = new int[diziSayisi];
                for (int i = 0; i < diziSayisi; i++)
                {
                    sayilar[i] = Convert.ToInt32(gelenSayi.Substring(gelenSayi.Length - ((i + 1) * 3), 3));
                }

                lblYazi.Text = "";
                int ii = 0;
                string[] yaziyla = new string[diziSayisi];
                foreach (var item in sayilar)
                {
                    string basamagi = Basamak(ii);
                    ii++;

                    string veri = cevir(item);
                    yaziyla[yaziyla.Length - ii] = veri + " " + basamagi;
                }

                foreach (var item in yaziyla)
                {
                    lblYazi.Text += item + " ";
                }
            }
            else
            {
                lblYazi.Text = "Sadece tam sayı girebilirsiniz.";
            }
        }
        private string cevir(int sayi)
        {
            string veri = "";

            int sayiLength = sayi.ToString().Length;
            for (int i = 0; i < sayiLength; i++)
            {
                int secilenSayi = Convert.ToInt32(sayi.ToString().Substring(sayiLength - (i + 1), 1));

                if (i == 0)
                {
                    veri = Birler(secilenSayi);
                    if (sayiLength > 1 && secilenSayi == 0)
                    {
                        veri = "";
                    }
                }
                else if (i == 1)
                {
                    if (secilenSayi > 0)
                    {
                        secilenSayi *= 10;
                        veri = Onlar(secilenSayi) + " " + veri;
                    }
                }
                else if (i == 2)
                {
                    if (secilenSayi > 1)
                    {
                        veri = Birler(secilenSayi) + " Yüz " + veri;
                    }
                    else if (secilenSayi == 1)
                    {
                        veri = "Yüz " + veri;
                    }
                }
            }

            return veri;
        }
        private string Birler(int karakter)
        {
            string veri = "";

            switch (karakter)
            {
                case 0: { veri = "Sıfır"; break; }
                case 1: { veri = "Bir"; break; }
                case 2: { veri = "İki"; break; }
                case 3: { veri = "Üç"; break; }
                case 4: { veri = "Dört"; break; }
                case 5: { veri = "Beş"; break; }
                case 6: { veri = "Altı"; break; }
                case 7: { veri = "Yedi"; break; }
                case 8: { veri = "Sekiz"; break; }
                case 9: { veri = "Dokuz"; break; }
            }

            return veri;
        }
        private string Onlar(int karakter)
        {
            string veri = "";

            switch (karakter)
            {
                case 10: { veri = "On"; break; }
                case 20: { veri = "Yirmi"; break; }
                case 30: { veri = "Otuz"; break; }
                case 40: { veri = "Kırk"; break; }
                case 50: { veri = "Elli"; break; }
                case 60: { veri = "Altmış"; break; }
                case 70: { veri = "Yetmiş"; break; }
                case 80: { veri = "Seksen"; break; }
                case 90: { veri = "Doksan"; break; }
            }

            return veri;
        }
        private string Basamak(int basamagi)
        {
            string veri = "";
            switch (basamagi)
            {
                case 0: { veri = ""; break; }
                case 1: { veri = "Bin"; break; }
                case 2: { veri = "Milyon"; break; }
                case 3: { veri = "Milyar"; break; }
                case 4: { veri = "Trilyon"; break; }
                case 5: { veri = "Katrilyon"; break; }
                case 6: { veri = "Kentilyon"; break; }
                case 7: { veri = "Sekstilyon"; break; }
                case 8: { veri = "Septilyon"; break; }
                case 9: { veri = "Oktilyon"; break; }
                case 10: { veri = "Nonilyon"; break; }
                case 11: { veri = "Desilyon"; break; }
                case 12: { veri = "Andesilyon"; break; }
                case 13: { veri = "Dodesilyon"; break; }
                case 14: { veri = "Tredesilyon"; break; }
                case 15: { veri = "Katordesilyon"; break; }
                case 16: { veri = "Kendesilyon"; break; }
                case 17: { veri = "Seksdesilyon"; break; }
                case 18: { veri = "Septendesilyon"; break; }
                case 19: { veri = "Oktodesilyon"; break; }
                case 20: { veri = "Novemdesilyon"; break; }
                case 21: { veri = "Vicintilyon"; break; }
                case 22: { veri = "Anvicintilyon"; break; }
                case 23: { veri = "Dovicintilyon"; break; }
                case 24: { veri = "Trevicintilyon"; break; }
                case 25: { veri = "Katorvicintilyon"; break; }
                case 26: { veri = "Kenkavicintilyon"; break; }
                case 27: { veri = "Sesvicintilyon"; break; }
                case 28: { veri = "Septemvicintilyon"; break; }
                case 29: { veri = "Oktovicintilyon"; break; }
                case 30: { veri = "Novemvicintilyon"; break; }
                case 31: { veri = "Tricintilyon"; break; }
                case 32: { veri = "Antricintilyon"; break; }
                case 33: { veri = "Dotricintilyon"; break; }
                case 34: { veri = "Trescintilyon"; break; }
                case 35: { veri = "Katortricintilyon"; break; }
                case 36: { veri = "Kenkatricintilyon"; break; }
                case 37: { veri = "Sestricintilyon"; break; }
                case 38: { veri = "Septentricintilyon"; break; }
                case 39: { veri = "Oktotricintilyon"; break; }
                case 40: { veri = "Noventricintilyon"; break; }
                case 41: { veri = "Katracintilyon"; break; }
                case 42: { veri = "Kenkacintilyon"; break; }
                case 43: { veri = "Seksacintilyon"; break; }
                case 44: { veri = "Septacintilyon"; break; }
                case 45: { veri = "Oktocintilyon"; break; }
                case 46: { veri = "Nonacintilyon"; break; }
                case 47: { veri = "Sentilyon"; break; }
                case 48: { veri = "Desisentilyon"; break; }
                case 49: { veri = "Anvicintisentilyon"; break; }
                case 50: { veri = "Tricintasentilyon"; break; }
                case 51: { veri = "Katracintasentilyon"; break; }
                case 52: { veri = "Kenkacintasentilyon"; break; }
                case 53: { veri = "Seksacintasentilyon"; break; }
                case 54: { veri = "Septacintasentilyon"; break; }
                case 55: { veri = "Oktocintasentilyon"; break; }
                case 56: { veri = "Nonacintasentilyon"; break; }
                case 57: { veri = "Dusentilyon"; break; }
                case 58: { veri = "Tresentilyon"; break; }
                case 59: { veri = "Katrincentilyon"; break; }
                case 60: { veri = "Kencentilyon"; break; }
                case 61: { veri = "Sessentilyon"; break; }
                case 62: { veri = "Septincentilyon"; break; }
                case 63: { veri = "Oktincentilyon"; break; }
                case 64: { veri = "Noncentilyon"; break; }
            }

            return veri;
        }
    }
}