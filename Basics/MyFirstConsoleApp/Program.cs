using System;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie einen Text ein: ");
        string text = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Ihr eingegebener Text lautet:");
        Console.WriteLine(text);

        Console.WriteLine();
        Console.WriteLine("Drücken Sie eine Taste zum Beenden...");
        Console.ReadKey();
    }
}