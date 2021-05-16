using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kura_Çekimi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();

        List<Takim> sonOnAlti = new List<Takim>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;
            takimlar = new List<Takim>(); //takimlar listesine  tek tek belirtilen takımları yolladık.

            yenitakim = new Takim("Bayern Munich", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Paris Saint-Germain", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Zenith", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Barcelona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Shaktar Donetsk  ", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chealse", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Dynamo Kiev", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("RedBull Salzburg", "Avusturya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("RB.Leipzig", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Internazlonale", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympiakos", "Yunanistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lazio", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Krasnodar", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atalanta", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lokomatif Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Marsilya", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Club Brugge", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bor.Mönchengladbach", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Midtjyland    ", "Danimarka");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Rennes", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ferencvaros", "Macaristan");
            takimlar.Add(yenitakim);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); //rastgele gruplar oluşturma işlemimizi tamamladık ve aynı ülkeden takım olmama fonksiyonumuzu çağırdık
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4);
                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool ayniulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniulkedentakimvar = ayniulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takim);
                    if (ayniulkedentakimvar)
                    {
                        break;
                    }
                }
                if (!ayniulkedentakimvar)
                {
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takim);
                    listBox9.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takim);
                    listBox10.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takim);
                    listBox11.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takim);
                    listBox12.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takim);
                }
                else
                {
                    j--;
                }

            }
        }
        private bool ayniulkedentakimvarmi(ListBox grup, Takim takim) // aynı ülkeden takım olmama fonksiyonumuz 
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {




            for (int i = 0; i < takimlar.Count; i++) //takımları 8,8 bölerek yazdığımız sırayla 4 ayrı torbaya çektik.
            {
                if (i < 8)
                {
                    listBox1.Items.Add(takimlar[i]);
                }
                else if (i < 16)
                {
                    listBox2.Items.Add(takimlar[i]);
                }
                else if (i < 24)
                {
                    listBox3.Items.Add(takimlar[i]);
                }
                else
                {
                    listBox4.Items.Add(takimlar[i]);
                }
            }


            torbalar.Add(listBox1);
            torbalar.Add(listBox2);
            torbalar.Add(listBox3);
            torbalar.Add(listBox4);

            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
            gruplar.Add(listBox9);
            gruplar.Add(listBox10);
            gruplar.Add(listBox11);
            gruplar.Add(listBox12);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fiksturOlustur(listBox5, listBox17, listBox23); //fikstirOlustur fonksiyonuna her grubun listboxlarını attık
            fiksturOlustur(listBox6, listBox16, listBox24);
            fiksturOlustur(listBox7, listBox15, listBox25);
            fiksturOlustur(listBox8, listBox18, listBox26);
            fiksturOlustur(listBox9, listBox19, listBox27);
            fiksturOlustur(listBox10, listBox20, listBox28);
            fiksturOlustur(listBox11, listBox21, listBox29);
            fiksturOlustur(listBox12, listBox22, listBox30);

            foreach (var item in sonOnAlti)
            {
                listBox13.Items.Add(item); 
            }

        }

        private void fiksturOlustur(ListBox grup, ListBox puanDurumuListesi, ListBox macSonuclari)
        {
            Dictionary<Takim, int> puanDurumu = new Dictionary<Takim, int>();

            puanDurumu.Add(grup.Items[0] as Takim, 0); //Gruptaki takımların puan durumlarını ekledik.
            puanDurumu.Add(grup.Items[1] as Takim, 0);
            puanDurumu.Add(grup.Items[2] as Takim, 0);
            puanDurumu.Add(grup.Items[3] as Takim, 0);



            int randomNumber;
            Random rastgele = new Random();
            var generatedRandomNumber = new List<int>();


            for (int i = 0; i < 4; i++)
            {

                generatedRandomNumber.Clear();
                for (int j = 0; j < 3; j++) 
                {
                    randomNumber = rastgele.Next(0, 4);
                    while (randomNumber == i || generatedRandomNumber.Contains(randomNumber))
                    {
                        randomNumber = rastgele.Next(0, 4);
                    }
                    generatedRandomNumber.Add(randomNumber);

                    var takim1 = grup.Items[i] as Takim;
                    var takim2 = grup.Items[generatedRandomNumber[0]] as Takim;

                }
                //random sayılarla gruptaki takımların arasında random fikstür oluşturduk

                var evSahibi = grup.Items[i] as Takim;
                var deplasman1 = grup.Items[(generatedRandomNumber[0])] as Takim;
                var deplasman2 = grup.Items[(generatedRandomNumber[1])] as Takim;
                var deplasman3 = grup.Items[(generatedRandomNumber[2])] as Takim;

                var firstMatch = generateScore(); //maçlara random skorlar ekledik
                var secondMatch = generateScore();
                var tirthMatch = generateScore();


                winner(puanDurumu, evSahibi, deplasman1, firstMatch); //takımları maç sonucunu ve puanları fonksiyonumuza yolladık
                winner(puanDurumu, evSahibi, deplasman2, secondMatch);
                winner(puanDurumu, evSahibi, deplasman3, tirthMatch);




                macSonuclari.Items.Add(evSahibi.TeamName + " " + firstMatch[0].ToString() + " - " + firstMatch[1].ToString() + " " + deplasman1.TeamName); //fikstürdeki maçların sonuçlarını yazdırdık
                macSonuclari.Items.Add(evSahibi.TeamName + " " + secondMatch[0].ToString() + " - " + secondMatch[1].ToString() + " " + deplasman2.TeamName);
                macSonuclari.Items.Add(evSahibi.TeamName + " " + tirthMatch[0].ToString() + " - " + tirthMatch[1].ToString() + " " + deplasman3.TeamName);

            }
            var puanSiralamasi = puanDurumu.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); //elemanları büyükten küçüğe sıraladık
            grup.Items.Clear();
            grup.Items.Add(puanSiralamasi.Keys.ElementAt(0));  
            grup.Items.Add(puanSiralamasi.Keys.ElementAt(1));
            grup.Items.Add(puanSiralamasi.Keys.ElementAt(2));
            grup.Items.Add(puanSiralamasi.Keys.ElementAt(3));
            puanDurumuListesi.Items.Add(puanSiralamasi.Values.ElementAt(0));
            puanDurumuListesi.Items.Add(puanSiralamasi.Values.ElementAt(1));
            puanDurumuListesi.Items.Add(puanSiralamasi.Values.ElementAt(2));
            puanDurumuListesi.Items.Add(puanSiralamasi.Values.ElementAt(3));
            this.sonOnAlti.Add(puanSiralamasi.Keys.ElementAt(0)); //bütün gruplarda 1.ve2. olan takımları son 16ya çıkardık
            this.sonOnAlti.Add(puanSiralamasi.Keys.ElementAt(1));


        }

        private List<int> generateScore() //en fazla 8 gol olması için 0 ve 8 arasında random sayılar aldık.
        {
            Random random = new Random();
            var scors = new List<int> { random.Next(0, 9), random.Next(0, 9) };

            return scors;
        }

        private void winner(Dictionary<Takim, int> puanDurumu, Takim evSahibi, Takim deplasman, List<int> scores) 
        {
            if (scores[0] == scores[1]) // gol sayısı fazla olan takıma beraberlik, galibiyet ve mağlubiyet durumunda puanlar ekledik
            {
                puanDurumu[evSahibi] += 1;
                puanDurumu[deplasman] += 1;
            }
            else if (scores[0] > scores[1])
            {
                puanDurumu[evSahibi] += 3;

            }
            else
                puanDurumu[deplasman] += 3;

        }

    }
}
