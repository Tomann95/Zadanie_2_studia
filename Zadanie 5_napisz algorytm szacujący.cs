using System;
using Internal;

public class Program
{
    public static void Main()
    {
        double x, eToX;
        int n;

        Console.Write("Podaj wartość x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę wyrazów n: ");
        n = int.Parse(Console.ReadLine());

        eToX = CalculateExponential(x, n);

        Console.WriteLine($"Szacowana wartość e^{x} = {eToX}");
    }

    public static double CalculateExponential(double x, int n)
    {
        double eToX = 0;
        double xPower = 1;
        double factorial = 1;

        for (int i = 0; i < n; i++)
        {
            eToX += xPower / factorial;
            xPower *= x;
            factorial *= (i + 1);
        }

        return eToX;
    }
}


