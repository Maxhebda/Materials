using System;


class Program
{
    static void Main(string[] args)
    {
        Osoba osoba;            // moze stworzyc instancje klasy
        //osoba = new Osoba();    // ale obiektu nie mozemy
        osoba = new Pracownik("Karol", "Ledzinski", 2000);
        Console.WriteLine(osoba.Imie);
        Console.WriteLine(osoba.Nazwisko);
        //Console.WriteLine(osoba.Wynagrodzenie);  //brak dostepu
        Console.WriteLine(((Pracownik)osoba).Wynagrodzenie);  //dostep po rzutowaniu

        //----------------- tablica --------------
        Osoba[] osoby = new Osoba[4];
        osoby[0] = new Pracownik("Janusz", "Wałęsa", 1000);
        osoby[1] = new Student("Leszek", "Młody", 1);
        osoby[2] = new Pracownik("Karolina", "Niezdała", 5);
        foreach (var z in osoby)
        {
            if (z != null)
                Console.WriteLine(z.opis());
        }

        Pracownik pracownik = new Pracownik("Adolf", "Hitler", 15000);
        Student student = new Student();

        Console.WriteLine(pracownik.opis());    //przykryta metoda abstrakcyjna opis() z klasy Osoba
        Console.WriteLine(student.opis());

        Console.ReadLine();
    }
}


abstract class Osoba
{
    public Osoba()
    {
        Imie = "";
        Nazwisko = "";
    }
    public Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
    public string Imie
    {
        get;
        protected set;
    }

    public string Nazwisko
    {
        get;
        protected set;
    }

    abstract public string opis();      //metoda abstrakcyjna - muszą ją miec wszystkie klasy co dziedziczą po Osoba
}

class Pracownik : Osoba
{
    public Pracownik() : base()
    {
        Wynagrodzenie = 0;
    }

    public Pracownik(string imie, string nazwisko, double wynagrodzenie) : base(imie, nazwisko)
    {
        Wynagrodzenie = wynagrodzenie;

    }

    public double Wynagrodzenie
    {
        get;
        protected set;
    }

    override public string opis()
    {
        return "jestem pracownikiem " + Imie + " " + Nazwisko + " i zarabiam : " + Wynagrodzenie;
    }
}

class Student : Osoba
{
    public Student() : base()
    {
        Semestr = 1;
    }

    public Student(string imie, string nazwisko, byte semestr) : base(imie, nazwisko)
    {
        Semestr = 1;
    }
    public byte Semestr
    {
        get;
        protected set;
    }

    override public string opis()
    {
        return "jestem studentem" + Imie + " " + Nazwisko + " i studiuje : " + Semestr + " semestr";
    }
}