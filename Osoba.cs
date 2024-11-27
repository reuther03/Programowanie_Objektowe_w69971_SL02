namespace Programowanie_Objektowe_w69971_SL02;

public class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;
    private string pesel;

    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int Wiek { get; private set; }
    public string Pesel { get; }

    public Osoba(string imie, string nazwisko, int wiek, string pesel)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.wiek = wiek;
        this.pesel = pesel;
    }

    public string PrzedstawSie()
    {
        return $"Nazywam się {imie} {nazwisko}, mam {wiek} lat";
    }

    public void UstawWiek(int setwiek)
    {
        if (Wiek < 0)
            Wiek = 0;

        Wiek = setwiek;
    }

}