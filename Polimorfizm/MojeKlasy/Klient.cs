using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.MojeKlasy
{

    public class Klient
    {
    public float odsetki = 0f;

        public string nazwisko;
        public DateTime dataUrodzenia;
        public string imie;


        string nazwa, nrTelefonu, kraj, adres;
        public float kapital;
        public Klient( string nazwa, string nrTelefonu, string kraj,
            string adres, float kapital)
        {
            this.nazwa = nazwa;
            this.nrTelefonu = nrTelefonu;
            this.kraj = kraj;   
            this.adres = adres;
            this.kapital = kapital;
        }



        public string ToString()
        {
            return $"{imie} {nazwisko}({dataUrodzenia.ToShortDateString()}) ";
        }

        public float PoliczKapital()
        {
            float nowyKapital = kapital;
            
            for (int i=0; i<12; i++)
            {
                nowyKapital = nowyKapital * 1.03f;

            }

            return nowyKapital;
                
        
        }
    }
}
