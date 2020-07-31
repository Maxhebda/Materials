using System;
using System.Collections;           //  <--- array list
using System.Collections.Generic;   //  <--- list

class Program
{
    static void Main(string[] args)
    {
        ArrayList alista = new ArrayList();
        alista.Add(5);
        alista.Add("lala");
        alista.Add(new Test("Hello to ja napis w klasie Test"));

        for (int i = 0; i < alista.Count; i++)
        {
            Console.WriteLine(alista[i]);        //aby wyswietlic trzeci element musielismy napisac metodę ToString()
        }

        //--------------------------------------------------------------------
        List<int> lista = new List<int>();
        lista.Add(10);

        //-------------------------------------------------------------------- moja wlasna klasa generyczna
        KlasaGeneryczna<int> mojObiekt = new KlasaGeneryczna<int>();  //moja klasa generyczna
        mojObiekt.nadajWartosc(10);
        Console.WriteLine(mojObiekt.zwrocWartosc());

        KlasaGeneryczna<string> mojObiekt2 = new KlasaGeneryczna<string>();  //moja klasa generyczna
        mojObiekt2.nadajWartosc("lala");
        Console.WriteLine(mojObiekt2.zwrocWartosc());



        Console.ReadLine();
    }
}

class Test
{
    public string testowyString
    {
        get;
        private set;
    }
    public Test(string napis)
    {
        this.testowyString = napis;
    }

    override public string ToString()
    {
        return testowyString;
    }

}

//-------------------------- przyklad wlasnej klasy generycznej : ----------------
class KlasaGeneryczna <Cokolwiek>
{
    Cokolwiek nazwaZmiennej;
    public Cokolwiek zwrocWartosc()
    {
        return nazwaZmiennej;
    }
    public void nadajWartosc(Cokolwiek c)
    {
        nazwaZmiennej = c;
    }
}