using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, digite uma frase:");
        string frase = Console.ReadLine();
        int numeroDePalavras = ContarPalavras(frase);
        Console.WriteLine($"A frase contém {numeroDePalavras} palavras.");
    }

    static int ContarPalavras(string frase)
    {
        if (string.IsNullOrWhiteSpace(frase))
        {
            return 0;
        }
        string[] palavras = frase.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        return palavras.Length;
    }
}