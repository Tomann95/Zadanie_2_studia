using System;
using Internal;

public class Program
{
    public static void Main()
    {
        decimal kwotaPoczatkowa, oprocentowanie, kwotaKoncowa;
        int liczbaMiesiecy;

        do
        {
            Console.Write("Podaj kwotę początkową: ");
        } while (!decimal.TryParse(Console.ReadLine(), out kwotaPoczatkowa) || kwotaPoczatkowa <= 0);

        do
        {
            Console.Write("Podaj oprocentowanie w skali roku: ");
        } while (!decimal.TryParse(Console.ReadLine(), out oprocentowanie) || oprocentowanie < 0);

        do
        {
            Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        } while (!int.TryParse(Console.ReadLine(), out liczbaMiesiecy) || liczbaMiesiecy <= 0);

        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);
        decimal podatekBelki = kwotaKoncowa * 0.19m; // Podatek Belki wynosi 19% od zysków
        decimal kwotaKoncowaPoOpodatkowaniu = kwotaKoncowa - podatekBelki;

        Console.WriteLine($"Kwota końcowa po {liczbaMiesiecy} miesiącach oszczędzania wynosi: {kwotaKoncowaPoOpodatkowaniu:F2}");
    }
}


