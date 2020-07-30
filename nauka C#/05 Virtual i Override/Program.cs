using System;

class Program
{
    static void Main(string[] args)
    {
        Punkt a = new Punkt(2, 4);
        Punkt b = new Punkt3d(1, 2, 3);

        Console.WriteLine(b.wyswietl());

        Console.ReadLine();
    }
}

