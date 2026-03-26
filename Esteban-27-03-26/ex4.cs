using System;

class Program
{
    static void Main()
    {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] vetor3 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Vetor 1 - Digite o {i + 1}º número: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Vetor 2 - Digite o {i + 1}º número: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            vetor3[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("\nVetor resultante:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(vetor3[i]);
        }
    }
}