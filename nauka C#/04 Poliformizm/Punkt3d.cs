
class Punkt3d : Punkt
{
    public Punkt3d(int xx, int yy, int zz) : base(xx, yy)
    {
        Z = zz;
    }

    public void zmienX(int x)
    {
        X = x;
    }
    public int Z
    {
        get;
        private set;
    }

    new public string wyswietl()
    {
        return base.wyswietl() + ", " + Z;
    }
}

