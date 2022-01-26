using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.Jmeno = "Zdeněk";
            osoba.Prijmeni = "Jendřejčík";
            osoba.DatumNarozeni = DateTime.Parse("26.1.1978");
            Console.WriteLine(osoba.GetVek());

            Console.ReadKey();
        }
    }
}
