using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];
        int soma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());

            soma += vetor[i];
        }

        Console.WriteLine("Somatório: " + soma);
    }
}