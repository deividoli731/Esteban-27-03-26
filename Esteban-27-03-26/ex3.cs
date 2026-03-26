using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite um número para buscar: ");
        int busca = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < 8; i++)
        {
            if (vetor[i] == busca)
            {
                Console.WriteLine($"Encontrado na posição {i}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("O número não se encontra no vetor");
        }
    }
}