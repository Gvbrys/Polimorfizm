using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.MojeKlasy
{
    public class KlientOsoba : Klient 
    {
        public string nazwisko;
        public DateTime dataUrodzenia;
        public string imie;
        public KlientOsoba(string imie, string nazwisko, DateTime dataUrodzenia, string nrTelefonu, string kraj,
            string adres, float kapital) :base("osoba prawna", nrTelefonu, kraj, adres, kapital)
        {

            imie = "osoba prawna";
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;


        }

        public string ToString()
        {
            return $"{imie} {nazwisko}({dataUrodzenia.ToShortDateString()}) ";
        }



        public float PoliczKapital()
        {
            float nowyKapital = kapital;

            for (int i = 0; i < 12; i++)
            {
                nowyKapital = nowyKapital * 1.02f;

            }

            return nowyKapital;


        }


    }
}
