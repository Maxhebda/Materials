
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

    override public string wyswietl()                  //override -> możemy ją nadpisać bo jest wirtualna
    {
        return base.wyswietl() + ", " + Z;
    }

    /*
    new public string wyswietl()                       //gdy jest new to nie domysli się ktore wyswietl zaswosowac
    {
        return base.wyswietl() + ", " + Z;
    }
    */
}


