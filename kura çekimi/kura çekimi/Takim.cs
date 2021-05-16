using System;
using System.Collections.Generic;
using System.Text;

namespace Kura_Çekimi
{
    public class Takim
    {
        private string takimIsmi;
        private string takimUlke;

        public Takim(string isim, string ulke)
        {
            takimIsmi = isim;
            takimUlke = ulke;
        }
        public string TeamName
        {
            get
            {
                return takimIsmi;
            }
            set
            {
                takimIsmi = value;
            }
        }
        public string TeamCountry
        {
            get
            {
                return takimUlke;
            }
            set
            {
                takimUlke = value;
            }
        }
        public override string ToString()
        {
            return takimIsmi + " - " + takimUlke;
        }
    }
}
