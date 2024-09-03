using System;

class Program
{
    static void Main(string[] args)
    {
        int indice = 12, soma = 0, K = 1;

        while (K < indice)
        {
            K = K + 1;
            soma = soma + K;
        }
        Console.WriteLine(soma);
    }
}
