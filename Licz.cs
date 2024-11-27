namespace Programowanie_Objektowe_w69971_SL02;

public class Licz
{
    private int Liczba { get; set; }

    public Licz(int liczba)
    {
        Liczba = liczba;
    }

    public void Dodaj(int liczba)
    {
        Liczba += liczba;
    }

    public void Odejmij(int liczba)
    {
        Liczba -= liczba;
    }



}