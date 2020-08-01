using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        MojTyp m = new MojTyp("ala ma kota");               
        Console.WriteLine((int)m);                          // rzutujemy nasz typ na int
        Console.WriteLine((float)m);                          // rzutujemy nasz typ na float

        int a = m;                                          // mozemy to zrobic jesli jest implicit (ukryte rzutowanie)
        float b = (float)m;                                 // przy explicit podobno trzeba (float) dodac

        Console.ReadLine();
    }
}

class MojTyp
{
    public MojTyp(string a)
    {
        A = a;
    }
    public string A
    {
        get;
        set;
    }

    //implicit              (ukryte rzutowanie na int)
    public static implicit operator int(MojTyp vvv)
    {
        return vvv.A.Length;
    }

    //explicit              (jawne rzutowanie na float)
    public static explicit operator float(MojTyp vvv)
    {
        return 122.44f;
    }
}
