using System;
using System.Collections.Generic;

namespace Pripremazakonoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> O = new List<Osoba>();
            O.Add(new Osoba("Ana", "Djordic", new DateTime(1979, 6, 3)));
            O[0].Stampa();
            //I tako dalje...
        }
    }
}
