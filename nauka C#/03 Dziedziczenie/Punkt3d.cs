
class Punkt3d : Punkt
{
    public Punkt3d(int xx, int yy, int zz) : base(xx, yy)        //base czyli który konstruktor wykonac z bazowej klasy
    {
        Z = zz;
    }

    public void zmienX(int x)
    {
        X = x;  // możemy tak zrobic bo jest protected wiec mamy dostep po dziedziczeniu
    }
    public int Z
    {
        get;
        private set;
    }

    new public string wyswietl()                        // dopisujemy new bo mamy ostrzezenie o nadpisaniu metody
    {
        return base.wyswietl() + ", " + Z;              // korzystamy z juz istniejacej metody w klasie punkt
    }
}

