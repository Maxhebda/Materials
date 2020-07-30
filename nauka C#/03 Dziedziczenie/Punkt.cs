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
        protected set;      // to mozna dziedziczyc
    }

    public int Y
    {
        get;
        private set;
    }

    public string wyswietl()
    {
        return X + ", " + Y;
    }
}

