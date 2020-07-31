using System;

class Program
{
    public enum CzasDnia
    {
        Ranek, Przedpoludnie, Poludnie, Wieczor, Noc
    }

    static void Main(string[] args)
    {
        CzasDnia mojczas;
        mojczas = CzasDnia.Noc;

        Console.WriteLine(jakiDzien(CzasDnia.Poludnie));
        Console.WriteLine(jakiDzien(0));
        Console.WriteLine(jakiDzien((CzasDnia)3));  // = wieczor
        Console.WriteLine(jakiDzien((CzasDnia)4));  // = noc

        Console.ReadLine();
    }

    public static string jakiDzien(CzasDnia czas)
    {
        switch(czas)
        {
            case CzasDnia.Ranek:
                return "Dzien dobry";
            case CzasDnia.Przedpoludnie:
                goto case CzasDnia.Ranek;
            case CzasDnia.Poludnie:
                goto case CzasDnia.Ranek;
            case CzasDnia.Wieczor:
                return "Dobry Wieczór";
            case CzasDnia.Noc:
                goto case CzasDnia.Wieczor;
        }
        return "Nie witam Cię!";
    }
}
