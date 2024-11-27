using Lab2;
using Programowanie_Objektowe_w69971_SL02;

// Lab1.Zad1();
// Lab1.Zad2();
// Lab1.Zad3();
// Lab1.Zad4Silnia(4);
// Lab1.Zad5();

//zadanie 1
var osoba = new Osoba("Jan", "Kowalski", 30, "12345678901");
Console.WriteLine(osoba.PrzedstawSie());
osoba.UstawWiek(-10);
Console.WriteLine(osoba.Wiek);

//zadanie 2
var licz = new Licz(10);
licz.Dodaj(5);
Console.WriteLine(licz.Wypisz());
licz.Odejmij(3);
Console.WriteLine(licz.Wypisz());

//zadanie 3
var sumator = new Sumator([1, 2, 3, 4, 5]);
sumator.Wypisz();
Console.WriteLine(sumator.Suma());
Console.WriteLine(sumator.Podzile3());
Console.WriteLine(sumator.IleElementow());
sumator.Indexer(1, 3);