using System;

class Program
{
    static void Main(string[] args)
    {
        Zdanie napis = new Zdanie("Ala ma kota i psa");
        napis[0] = "Kazek";
        Console.WriteLine(napis[0] + ", " + napis[1]);

        Console.ReadLine();
    }
}

class Zdanie
{
    string[] slowa;
    public Zdanie(string zdanie)
    {
        this.slowa = zdanie.Split();    //dzieli zdanie na slowa i zwraca tablice stringow
    }

    // tworzymy indekser :
    public string this[int n]
    {
        get
        {
            if (n >= slowa.Length)
                return "";
            else
                return slowa[n];
        }
        set
        {
            if (n < slowa.Length)
                slowa[n] = value;
        }
    }
}