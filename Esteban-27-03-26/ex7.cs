using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVetor original:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        for (int i = 0; i < 10 / 2; i++)
        {
            int temp = vetor[i];
            vetor[i] = vetor[9 - i];
            vetor[9 - i] = temp;
        }

        Console.WriteLine("\n\nVetor invertido:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}