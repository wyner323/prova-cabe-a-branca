using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor para conversão:");
        int valor = int.Parse(Console.ReadLine());

        int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
        int[] quantidadeCedulas = new int[cedulas.Length];

        for (int i = 0; i < cedulas.Length; i++)
        {
            quantidadeCedulas[i] = valor / cedulas[i];
            valor %= cedulas[i];
        }

        Console.WriteLine("Cédulas necessárias:");
        for (int i = 0; i < cedulas.Length; i++)
        {
            if (quantidadeCedulas[i] > 0)
            {
                Console.WriteLine($"Cédulas de {cedulas[i]}: {quantidadeCedulas[i]}");
            }
        }
    }
}


