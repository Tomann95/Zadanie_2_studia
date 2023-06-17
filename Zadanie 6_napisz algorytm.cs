using System;
using Internal;

public class Program
{
    public static void Main()
    {
        int x;

        Console.Write("Podaj liczbę x: ");
        x = int.Parse(Console.ReadLine());

        int n = 1;
        int factorial = 1;

        while (factorial < x)
        {
            n++;
            factorial *= n;
        }

        if (factorial == x)
        {
            Console.WriteLine($"{x} jest silnią liczby {n}.");
        }
        else
        {
            Console.WriteLine($"{x} nie jest silnią żadnej liczby.");
        }
    }
}


