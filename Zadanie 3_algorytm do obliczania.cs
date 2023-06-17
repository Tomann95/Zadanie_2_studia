using System;
using Internal;

public class Program
{
    public static void Main()
    {
        int n, k;

        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        int m = CalculateExpression(n, k);

        Console.WriteLine("Wynik: " + m);
    }

    public static int CalculateExpression(int n, int k)
    {
        int nFactorial = 1;
        int kFactorial = 1;
        int m = 0;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;

            if (i <= k)
            {
                kFactorial *= i;
            }
        }

        m = (nFactorial - kFactorial) / kFactorial;

        return m;
    }
}



