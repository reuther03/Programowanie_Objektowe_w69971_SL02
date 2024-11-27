namespace Lab2;

public class Licz
{
    private int Liczba { get; set; }

    public Licz(int liczba)
    {
        Liczba = liczba;
    }

    public int Wypisz()
        => Liczba;

    public void Dodaj(int liczba)
    {
        Liczba += liczba;
    }

    public void Odejmij(int liczba)
    {
        Liczba -= liczba;
    }
}