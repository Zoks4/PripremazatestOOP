using System;
using System.Collections.Generic;
using System.Text;

namespace Pripremazakonoop
{
    internal class Student : Osoba
    {
        private string brind;
        public string Brind
        {
            get { return brind; }
            set { brind = value; }
        }
        public Student(string ime, string prezime, DateTime datumRodjenja, string brind) : base(ime, prezime, datumRodjenja)
        {
            this.brind = brind;
        }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Broj indexa:{0}", brind);
        }
    }
}
