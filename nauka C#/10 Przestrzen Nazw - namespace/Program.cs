using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using skrot = PrzestrzenieNazw2;        //skrot
using s = PrzestrzenieNazw2.Program;    //skrot2
namespace PrzestrzenieNazw
{
    class Program
    {
        static public double PI = 3.14;
        static void Main(string[] args)
        {
            // odwołanie do drugiej klasy Program w innej przestrzeni nazw
            PrzestrzenieNazw2.Program zmienna = new PrzestrzenieNazw2.Program();
            skrot.Program zmienna2 = new skrot.Program();
            skrot.Program zmienna3 = new s();
            s zmienna4 = new s();

        }
    }
}

namespace PrzestrzenieNazw2
{
    class Program
    {
        public Program()
        {
            double liczba = PrzestrzenieNazw.Program.PI;    //odwolanie do zmiennej statycznej PI w innej przestrzeni
        }
        static void Main(string[] args)
        {
        }
    }
}