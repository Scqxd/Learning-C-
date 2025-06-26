using System;

public class PrimeNumbers
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
        {
            Console.WriteLine($"Простые числа от 2 до {n}:");
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i)) 
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число больше 1.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}