using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool isInFibonacci = IsFibonacci(number);

            if (isInFibonacci)
            {
                Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    static bool IsFibonacci(int num)
    {
        if (num < 0) return false;

        int a = 0, b = 1;
        
        if (num == a || num == b) return true;

        int next = a + b;
        
        while (next <= num)
        {
            if (next == num) return true;

            a = b;
            b = next;
            next = a + b;
        }

        return false;
    }
}
