using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

        Console.ReadLine();
        }
    }

//klasa zapieczetowana :
sealed class NieMoznaDziedziczyc{}
// class Bazowa : NieMoznaDziedziczyc{}      // nie możemy dziedziczyc


//metoda zapieczetowana
class A1
{
    virtual public void metoda(){}
}
class A2 : A1
{
    sealed public override void metoda(){}     //dziedzicze metode z A1 ale juz nie chce by mozna bylo ja dziedziczyc dalej
}

class A3 : A2
{
    override public void metoda() {}        // nie mozemy juz jej przyslonic gdyz jest zapieczetowana
    new public void metoda() { }        // ale mozemy stworzyc nowe cialo przez "new"
}