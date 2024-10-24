Zad5();
return;


void Zad1()
{
    Console.Write("Podaj liczbe:");
    var input = Console.ReadLine();
    var liczba = int.Parse(input);

    if (liczba % 2 == 0)
    {
        Console.WriteLine("Liczba jest parzysta");
    }
    else if (liczba % 2 == 1)
    {
        Console.WriteLine("Liczba jest nieparzysta");
    }
    else
    {
        Console.WriteLine("Liczba nie jest ani parzysta ani nieparzysta");
    }
}

void Zad2()
{
    Console.Write("Podaj liczbe:");
    var input = Console.ReadLine();
    var liczba = int.Parse(input);

    for (var i = 1; i <= liczba; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

void Zad3()
{
    while (true)
    {
        Console.WriteLine("0. koniec programu");
        Console.WriteLine("1. cos tam");
        Console.WriteLine("2. cos tam");
        Console.WriteLine("3. cos tam");
        Console.Write("Podaj liczbe:");
        var input = Console.ReadLine();

        switch (input)
        {
            case "0":
                return;

            case "1":
                Console.WriteLine("cos tam 1");
                break;

            case "2":
                Console.WriteLine("cos tam 2");
                break;

            case "3":
                Console.WriteLine("cos tam 3");
                break;
        }
    }
}

int Zad4Silnia(int n)
{
    if (n is 0 or 1)
        return 1;

    return Zad4Silnia(n - 1) * n;
}

void Zad5()
{
    var random = new Random();
    var rngLiczba = random.Next(1, 100);
    var proba = 0;

    Console.WriteLine("Zgadnij liczbe z zakresu 1-100");
    while (true)
    {
        proba++;
        Console.Write("Podaj liczbe:");
        var input = Console.ReadLine();
        var liczba = int.Parse(input);

        if (liczba == rngLiczba)
        {
            Console.WriteLine($"Gratulacje! Zgadles liczbe! {proba} prob");
            break;
        }

        Console.WriteLine(liczba < rngLiczba ? "Za mala liczba" : "Za duza liczba");
    }
}