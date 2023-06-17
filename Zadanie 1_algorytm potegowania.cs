using System;
using Internal;

public class Program
{
    public static int Power(int baseNum, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else
        {
            return baseNum * Power(baseNum, exponent - 1);
        }
    }

    public static void Main()
    {
        int baseNum = 2;
        int exponent = 5;
        int result = Power(baseNum, exponent);

        Console.WriteLine("Wynik potęgowania: " + result);
    }
}



