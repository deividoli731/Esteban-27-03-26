using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[20];

        int pares = 0;
        int impares = 0;
        int maiores50 = 0;
        int menores7 = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] % 2 == 0)
                pares++;
            else
                impares++;

            if (vetor[i] > 50)
                maiores50++;

            if (vetor[i] < 7)
                menores7++;
        }

        Console.WriteLine($"\nQuantidade de pares: {pares}");
        Console.WriteLine($"Quantidade de ímpares: {impares}");
        Console.WriteLine($"Quantidade maiores que 50: {maiores50}");
        Console.WriteLine($"Quantidade menores que 7: {menores7}");
    }
}