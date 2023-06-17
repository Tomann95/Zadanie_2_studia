using System;
using Internal;

public class Program
{
    public static void Main()
    {
        int n;

        Console.Write("Podaj liczbę n: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pary liczb naturalnych o sumie {n}:");
        PrintNumberPairs(n);
    }

    public static void PrintNumberPairs(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine($"({i}, {j})");
        }
    }
}

