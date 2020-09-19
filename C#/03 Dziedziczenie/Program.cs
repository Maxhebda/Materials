using System;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt = new Punkt(2, 4);
            Console.WriteLine("Punkt = " + punkt.X + ", " + punkt.Y);

            Punkt3d punkt3d = new Punkt3d(2, 4,5);
            punkt3d.zmienX(1000);
            Console.WriteLine("Punkt3d = " + punkt3d.X + ", " + punkt3d.Y + ", " + punkt3d.Z);
            Console.WriteLine("metoda wyswietlajaca : " + punkt3d.wyswietl());





            Console.ReadLine();
        }
    }
}
