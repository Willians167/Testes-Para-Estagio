using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua String");
        string input = Console.ReadLine();

       

        int count = ContarocorrenciaDoA(input);

        if (count > 0)
        {
            Console.WriteLine($"Na string ({input}),");
            Console.WriteLine($"a letra 'a' aparece {count} vezes na string.");
        }
        else
        {
            Console.WriteLine($"Na string ({input}),");
            Console.WriteLine("A letra 'a' não aparece na string.");
        }
    }

    static int ContarocorrenciaDoA(string text)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        return count;
    }
}
