using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira data (formato: d/M/ano):");
        DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "d/M/ano", null);

        Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy):");
        DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "d/M/ano", null);


        TimeSpan diferenca = data2 - data1;

        Console.WriteLine($"A quantidade de dias entre as duas datas é: {Math.Abs(diferenca.Days)}");
    }
}