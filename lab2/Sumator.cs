namespace Lab2;

public class Sumator
{
    private int[] liczby;

    public Sumator(int[] liczby)
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
        return liczby.Length;
    }

    public void Wypisz()
    {
        foreach (var liczba in liczby)
        {
            Console.WriteLine(liczba);
        }
    }

    public void Indexer(int lowIndex, int highIndex)
    {
        for (var i = lowIndex; i <= highIndex; i++)
        {
            Console.WriteLine(liczby[i]);
        }
    }
}