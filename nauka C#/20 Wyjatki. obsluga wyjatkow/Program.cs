using System;
using System.Linq.Expressions;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 10;
            Console.Write("Wpisz liczbe przez którą podzielimy : ");
            string x = Console.ReadLine();

            try
            {
                Console.WriteLine(w / Convert.ToInt32(x));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("nie moge dzielic przez zero blad = " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("wpisales zly format (tekst) blad = " + e.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine("wszystkie inne wyjatki! : blad = " + e.Message);
            }
            finally //nieobowiazkowy blok
            {
                Console.WriteLine("ja sie zawsze wyswietle");
            }


            //------------------------------ teraz korzystamy z wlasnej klasy bledu ------
            
            int a = 10;
            try
            {
                if (a == 10)            //rzucamy wyjatek!
                    throw new MojBlad("Nie chce miec 10");
            }
            catch(Exception e)
            {
                Console.WriteLine("Złapałem swoj wyjatek : " +e.Message);
            }



                Console.WriteLine("koniec programu");
            Console.Read();
        }
    }
}


// klasa dziedziczy po exception
class MojBlad : Exception 
{
    public MojBlad(string msg) : base (msg)
    {

    }

}