namespace Programowanie_Objektowe_w69971_SL02;

public class Sumator
{
    private List<int> liczby;

    public Sumator(List<int> liczby)
    {
        this.liczby = liczby;
    }

    public int Suma()
    {
        return liczby.Sum();
    }

    public float Podzile3()
    {
        return liczby.Sum() / 3;
    }

    public int IleElementow()
    {
        return liczby.Count;
    }

    public void Wypisz()
    {
        liczby.ForEach(Console.WriteLine);
    }

    public void Indexer(int lowIndex, int highIndex)
    {
        foreach (var liczba in liczby.Where(x => x >= lowIndex && x <= highIndex))
        {
            Console.WriteLine(liczba);
        }
    }
}