using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        StanKonta a = new StanKonta(5, 10);
        StanKonta b = new StanKonta(5, 10);

        Console.WriteLine(a);
        Console.WriteLine(a == b);
        Console.WriteLine(a + b);

        Console.ReadLine();
    }
}

class StanKonta
{
    public uint Zl
    {
        get;
        private set;
    }
    private ushort gr;
    public ushort Gr
    {
        get
        {
            return gr;
        }
        private set
        {
            gr = value;
        }
    }
    public StanKonta(uint zlotowki, ushort grosze)
    {
        Gr = grosze;
        Zl = zlotowki;
    }

    // ------ przeciazenie operatorow
    public static bool operator ==(StanKonta L, StanKonta P)
    {
        if (L.Gr == P.Gr && L.Zl == P.Zl)
            return true;
        return false;
    }
    public static bool operator !=(StanKonta L, StanKonta P)
    {
        return !(L == P);
    }

    public static StanKonta operator +(StanKonta L, StanKonta P)
    {
        uint zlotowki = L.Zl + P.Zl;
        uint grosze = (uint)L.Gr + P.Gr;
        if (grosze >=100)
        {
            zlotowki += grosze / 100;
            grosze = grosze - (grosze / 100) * 100;
        }
        return new StanKonta(zlotowki, (ushort)grosze);
    }

    override public string ToString()           //przeciazamy metode ToString
    {
        return Zl + "zł i " + Gr + " groszy"; 
    }

    //-------------- konstruktor kopiujacy --------
    public StanKonta(StanKonta s)
    {
        Zl = s.Zl;
        Gr = s.Gr;
    }
}