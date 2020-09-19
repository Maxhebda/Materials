using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // po klasie string nie mozemy dziedziczyc gdyz jest zapieczetowana
        string a = "Ala ma kota";
        Console.WriteLine(a.CzyPierszaJestDuza());  //dodalismy metode rozszerzajaca
        Console.ReadLine();
    }
}
static class PomocnikStringa    //klasa zawierajaca metodę rozszerzajacą musi byc statyczna
{
    public static bool CzyPierszaJestDuza(this string v)    //dajemy this i metoda jest rozszerzajaca
    {
        return Char.IsUpper(v[0]);
    }
}