using System;
using System.Collections;        
using System.Collections.Generic;  

class Program
{
    static void Main(string[] args)
    {

        new Test2<string>(); // to mozna bo T ma byc klasą czyli np string
        new Test2<Test<int>>(); // to mozna bo T ma byc klasą czyli np Test<int>
        //new Test2<int>(); // to nie mozna bo T ma byc klasą

        Console.ReadLine();
    }
}

class Test<T>
{
    public T zmienna
    {
        get;
        private set;
    }
    public Test()
    {
        zmienna = default(T);       //wartosc domyslna w konstruktorze (0 dla int, byte, null dla klasowych itp)
    }
}

// ----------- demonstracja ograniczen ------------------
// where T : class  - T musi byc klasą
// where T : struct - T musi byc struktura
// where T : INazwaInterfejsu - T musi implementowac po danym interfejsie
// where T : nazwaKlasy  - T musi byc typem danej klasy lub  od niej dziedziczy
// where T : new() - T bedzie miał konstruktor pusty
class Test2<T> where T : class
{
    public T zmienna
    {
        get;
        private set;
    }
    public Test2()
    {
        zmienna = default(T);       //wartosc domyslna w konstruktorze (0 dla int, byte, null dla klasowych itp)
    }
}