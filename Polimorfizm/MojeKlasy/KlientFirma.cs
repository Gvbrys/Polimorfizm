using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.MojeKlasy
{
    public class KlientFirma : Klient
    {
        public string nazwa;
        public string nrTelefonu;
        public string kraj;
        public string adres;
        public string formaPrawna;


        public KlientFirma(string nazwa, string nrTelefonu, string kraj,
            string adres, string formaPrawna , float kapital): base("osoba prawna", nrTelefonu, kraj, adres, kapital) {

            this.nazwa = nazwa;
            this.nrTelefonu = nrTelefonu;
            this.kraj = kraj;
            this.adres = adres;
            this.formaPrawna = formaPrawna;
            this.kapital = kapital;

        }


        public string ToString()
        {
            return $"{imie} {nazwisko}({dataUrodzenia.ToShortDateString()}) ";
        }




    }
}
