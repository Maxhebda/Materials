using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt a = new Punkt(2, 4);
            Punkt b = new Punkt3d(1, 2, 3);                 // poliformizm
            //Punkt3d c = new Punkt(1, 2); żle!

            Console.WriteLine("punkt b : " + b.wyswietl());
            //wywołał się tylko konstruktor klasy bazowej (rzutowanie w góre) stracilismy dostep do metod z punkt3d

            Console.WriteLine("punkt b po rzutowaniu w dół : " + ((Punkt3d)b).wyswietl());
            //rzutujemy  bo na Punkt3d : (Punkt3d)b  i wyswietlamy

            Display(a);
            Display(b);
            Display2(a);
            Display2(b);

            // klasa Object
            Console.WriteLine((Object)a);
            Console.WriteLine((Object)a.ToString());
            Console.WriteLine(nazwaKlasy(a));





            Console.ReadLine();
        }
        // demonstracja IS
        static void Display(Punkt p)
        {
            if (p is Punkt3d)                  // jezeli punkt3d to rzutuj
                Console.WriteLine("Display rzutowane: " + ((Punkt3d)p).wyswietl());
            else                             // inaczej wyswiwtl normalnie
                Console.WriteLine("Display: " + p.wyswietl());
        }

        // demonstarcja AS
        static void Display2(Punkt p)
        {
            Punkt3d temp = p as Punkt3d;            //jesli niepoprawnie przypisze to temp zostanie null
            if (temp != null)
                Console.WriteLine("Display2: " + temp.wyswietl());
            else
                Console.WriteLine("Display2: " + p.wyswietl());
        }

        //demonstracja klasy Object
        static string nazwaKlasy(Object x)
        {
            return x.ToString();
        }
    
}
