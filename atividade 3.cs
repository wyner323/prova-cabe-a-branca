using System;

class Program
{
    static void Main()
    {
        var ddds = new System.Collections.Generic.Dictionary<int, string>
        {
            { 61, "brasília" },
            { 71, "salvador" },
            { 21, "rio de janeiro" },
            { 32, "juiz de fora" },
            { 19, "campinas" },
            { 27, "vitória" },
            { 31, "Belo horizonte" }
        };

        Console.WriteLine("Digite o DDD:");
        int ddd = int.Parse(Console.ReadLine());

        if (ddds.ContainsKey(ddd))
        {
            Console.WriteLine($"O DDD {ddd} é  de: {ddds[ddd]}");
        }
        else
        {
            Console.WriteLine("DDD não encontrado.");
        }
    }
}