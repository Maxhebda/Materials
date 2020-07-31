using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
        Monitor monitor = new Monitor();
        monitor.Przycisnij(2);
        monitor.IloscPrzyciskow = 3;
        Console.WriteLine(monitor.IloscPrzyciskow);
        Console.ReadLine();
        }
    }

interface IEkran
{
    void Wyswietl();
}

interface IPanelPrzyciskow
{
    byte IloscPrzyciskow
    {
        get;
        set;
    }
    bool Przycisnij(byte nrPrzycisku);
}

class Monitor : IEkran, IPanelPrzyciskow
{
    public Monitor()
    {
        liczbaP = 4;
    }
    public void Wyswietl()
    {

    }

    public bool Przycisnij(byte nrPrzycisku)
    {
        return true;
    }

    public byte IloscPrzyciskow
    {
        get
        {
            return liczbaP;
        }
        set
        {
            liczbaP =(byte) ( value + 10 );
        }
    }

    private byte liczbaP;
}
