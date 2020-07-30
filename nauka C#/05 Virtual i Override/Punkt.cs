class Punkt
{
    public Punkt()
    {
        X = 0;
        Y = 0;
    }
    public Punkt(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X
    {
        get;
        protected set;
    }

    public int Y
    {
        get;
        private set;
    }

    virtual public string wyswietl()                //metoda wirtualna
    {
        return X + ", " + Y;
    }
}

