class Program
{
    static void Main(string[] args)
    {
        KsiazkaAdresowa ks = new KsiazkaAdresowa("Ania","Kowalska","23222222");     //wywolanie konstruktora dla struktury
        ks.imie = "Arek";
        KsiazkaAdresowa ks2;
        ks2.imie = "www";

        KsiazkaAdresowa2 ksKlasa = new KsiazkaAdresowa2();
        ks2.imie = "Arek";

    }
}
struct KsiazkaAdresowa
{
    public KsiazkaAdresowa(string i, string nazwisko, string telefon)      //konstruktor w strukturze
    {       //bezparametrowego nie mozna
        imie = i;
        this.nazwisko = nazwisko;
        this.telefon = telefon;
    }
  public string imie;
  public string nazwisko;
  public string telefon;
}

class KsiazkaAdresowa2
{
   public string imie;
   public string nazwisko;
   public string telefon;
}