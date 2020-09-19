using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //int a = null;     // nie mozna       
        int? a = null;      // mozna
        if (a == null) Console.WriteLine("a jest null");
        Console.WriteLine(a);   // wyswietla puste

        //int b = (int)a;   // nie mozna Obiekt dopuszczający wartość pustą musi mieć wartość.”
        int b = a ?? 0;     //mozna  - przypisz a jesli istnieje lub zero jesli nie istnieje

        Console.ReadLine();
    }
}