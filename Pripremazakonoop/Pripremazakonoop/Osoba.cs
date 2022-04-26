using System;
using System.Collections.Generic;
using System.Text;

namespace Pripremazakonoop
{
    internal class Osoba
    {
        private string ime, prezime;
        private DateTime datumRodjenja;
        public Osoba(string ime, string prezime, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        public virtual void Stampa()
        {
            Console.WriteLine("Ime:{0}\nPrezime:{1}\nDatum rodjenja{2}", ime, prezime, datumRodjenja.ToShortDateString());
        }
    }
}
