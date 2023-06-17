using System;
using Internal;

public class Program
{
    public static void Main()
    {
        int min = 1;
        int max = 20;
        int guess;
        string userResponse;

        Console.WriteLine("Wybierz liczbę z przedziału od 1 do 20.");
        Console.WriteLine("Odpowiadaj '-' jeśli liczba jest mniejsza, '+' jeśli jest większa, lub '0' jeśli zgadłem.");

        while (true)
        {
            guess = (min + max) / 2;
            Console.Write($"Czy Twoja liczba to {guess}? ");
            userResponse = Console.ReadLine();

            if (userResponse == "-")
            {
                max = guess - 1;
            }
            else if (userResponse == "+")
            {
                min = guess + 1;
            }
            else if (userResponse == "0")
            {
                Console.WriteLine("Brawo! Zgadłem liczbę.");
                break;
            }
            else
            {
                Console.WriteLine("Niepoprawna odpowiedź. Wybierz '-' jeśli liczba jest mniejsza, '+' jeśli jest większa, lub '0' jeśli zgadłem.");
            }
        }
    }
}

