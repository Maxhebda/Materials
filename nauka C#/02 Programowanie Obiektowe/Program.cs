using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek a;
            a = new Czlowiek("Karol");
            Czlowiek b = new Czlowiek();
            Console.WriteLine(a.getImie());

            //--------------------- przykład konstruktory, metody statyczne i dynamiczne
            Gracz pierwszy = new Gracz();
            Console.WriteLine(pierwszy.Id + ". " + pierwszy.Nick);//jest tylko do odczytu ta własciwosc Id i Nick
            Gracz drugi = new Gracz("Anka");
            Console.WriteLine(drugi.Id + ". " + drugi.Nick);//jest tylko do odczytu ta własciwosc Id i Nick
            Gracz trzeci = new Gracz();
            Console.WriteLine(trzeci.Id + ". " + trzeci.Nick);//jest tylko do odczytu ta własciwosc Id i Nick
            Gracz czwarty = new Gracz();
            Console.WriteLine(czwarty.Id + ". " + czwarty.Nick);//jest tylko do odczytu ta własciwosc Id i Nick

            //--------------------- statyczna zmienna
            Console.WriteLine(Gracz.PI);

            //--------------------- metoda zmieniajaca argument - a  (ref przekazanie przez referencje)
            int liczbaMala = 12;
            Matematyka.dodaj1(ref liczbaMala);
            Console.WriteLine(liczbaMala);

            //--------------------- metoda inicjalizujaca zmienna bez przypisanej wartosci poczatkowej (out)
            int liczbaMalaNieZaincjalizowana;
            Matematyka.przypisz10(out liczbaMalaNieZaincjalizowana);
            Console.WriteLine(liczbaMalaNieZaincjalizowana);

            //--------------------- wiele argumentow - nieznana liczba argumentów
            Console.WriteLine(Matematyka.dodaj(9, 1, 4, 6, 3, 7));

            //--------------------- getery i setery / get set w skróty
            Obywatel marek = new Obywatel("Marek", "Nowak");
            // marek.Imie = "Marko"; -- nie mozna zmienic bo set jest niedostepne - prywatna
            // marek.Nazwisko = "Kaczyński";  -- nie ma metody set
            Console.WriteLine(marek.Imie + " " + marek.Nazwisko);

            //--------------------- zmiana kolejnosci przypisania argumentow
            Obywatel arek = new Obywatel(nazwisko: "Kowalski", imie: "Arkadiusz"); ;
            Console.WriteLine(arek.Imie + " " + arek.Nazwisko);

            //--------------------- konstruktor satyczny wywola sie tylko raz
            Powitanie jakasZmienna = new Powitanie();
            Console.WriteLine(Powitanie.Message);

            //--------------------- wywolanie konstruktora przez inny konstruktor
            Auto jakiesAuto = new Auto("BMW");
            Console.WriteLine("auto " + jakiesAuto.Nazwa + " ma kół : " + jakiesAuto.IloscKol);

            //--------------------- konstruktor kopiujacy
            Auto jakiesDrugieAuto = new Auto(jakiesAuto);
            Console.WriteLine("drugie auto" + jakiesDrugieAuto.Nazwa + " ma kół : " + jakiesDrugieAuto.IloscKol);

            //--------------------- klasy zagniezdzone
            Samochod jakisSamochod = new Samochod();
            Console.WriteLine("moc auta z klasy zagnierzdzonej : " + jakisSamochod.pobierzMoc());
            Samochod.KlasaWewnetrzna jakasKlasa = new Samochod.KlasaWewnetrzna();   // klasa wewnetrzna

            //--------------------- dziedziczenie





            Console.ReadLine();

        }
    }

    class Czlowiek
    {
        public Czlowiek(string imie = "Bob")
        {
            this.imie = imie;
        }
        string imie;
        void Oddychnij(byte ileSekund)
        {

        }
        public string getImie()
        {
            return imie;
        }
    }

    //--------------------- przykład konstruktory, metody statyczne i dynamiczne
    class Gracz
    {
        public Gracz(string nick = "Bob")
        {
            idIterator++;
            id = idIterator;
            this.nick = nick;
        }
        static private int idIterator = 0;
        private int id;
        private string nick;
        public static readonly double PI = 3.14;
        // wlasciwosci
        public string Nick
        {
            get
            {
                return nick;
            }
            // set
            // {
            //     nick = value;
            // }
        }
        public int Id
        {
            get
            {
                return id;
            }
            // set
            // {
            //     nick = value;
            // }
        }

    }

    //--------------------- metoda zmieniajaca argument - a  (przekazanie przez referencje)
    class Matematyka
    {
        static public void dodaj1(ref int a)    //ref = referencja
        {
            a++;
        }
        static public void przypisz10(out int a)    //out - deklaracja, że cos przypiszemy jesli zmiennia jest niezadeklarowana
        {
            a = 10;
        }
        static public int dodaj(params int[] tab)
        {
            int suma = 0;
            foreach (int i in tab)
            {
                suma += i;
            }
            return suma;
        }
    }

    //--------------------- getery i setery / get set w skróty
    class Obywatel
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; }
        //konstruktor
        public Obywatel(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }
    }

    //--------------------------- konstruktor statyczny
    class Powitanie
    {
        public static string Message
        {
            get;
            private set;
        }
        static Powitanie()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("wywolam sie tylko raz");
            if (now.Hour < 17)
            {
                Message = "Dzien dobry";
            }
            else
                Message = "Dobry Wieczór";
        }
    }

    //--------------------- konstruktor satyczny wywola sie tylko raz
    class Auto
    {
        public string Nazwa
        {
            set;
            get;
        }
        public byte IloscKol
        {
            get;
            private set;
        }
        public Auto(string nazwa, byte iloscKol)
        {
            this.Nazwa = nazwa;
            this.IloscKol = iloscKol;
        }
        public Auto(string nazwa) : this(nazwa, 4)  // odwolujemy sie do innego konstruktora z wartoscia domyslna 4
        {
            Console.WriteLine("domyslilem sie ze auto ma 4 kola");
        }

        //konstruktor kopiujacy
        public Auto(Auto auto)
        {
            Nazwa = auto.Nazwa;
            IloscKol = auto.IloscKol;
        }
    }

    //--------------------- klasy zagniezdzone
    class Samochod
    {
        private class Silnik
        {
            public Silnik(uint moc = 133)
            {
                Moc = moc;
            }
            public uint Moc;
        }
        public Samochod()
        {
            silniczek = new Silnik();
        }
        private Silnik silniczek;
        public uint pobierzMoc()
        {
            return this.silniczek.Moc;
        }

        // klasa zagnierzdzona publiczna :
        public class KlasaWewnetrzna
        {
            public KlasaWewnetrzna()
            {

            }
        }
    }
}
