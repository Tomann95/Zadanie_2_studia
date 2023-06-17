using System;
using Internal;

public class Program
{
    public static void FibonacciSequence(int n)
    {
        int a = 0;
        int b = 1;

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a;
            a = b;
            b = temp + b;
        }
    }

    public static void Main()
    {
        int n = 10; // liczba kolejnych wyrazów do wypisania
        FibonacciSequence(n);
    }
}


