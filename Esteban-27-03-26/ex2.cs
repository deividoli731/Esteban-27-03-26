using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros positivos:");

        for (int i = 0; i < 15; i++)
        {
            if (vetor[i] > 0)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}