using System;
using FirstOOP;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie einen Text ein: ");
        string text = Console.ReadLine();
Console.WriteLine("Hello, World!");
var myKuh = new Kuh("Paula", "Schwarz"); // instanziate a new Kuh object with name "Paula" and colour "Schwarz"

        Console.WriteLine();
        Console.WriteLine("Ihr eingegebener Text lautet:");
        Console.WriteLine(text);
var myKuh2 = new Kuh("Luna", "Braun"); // instanziate a new Kuh object with name "Luna" and colour "Braun"

        Console.WriteLine();
        Console.WriteLine("Drücken Sie eine Taste zum Beenden...");
        Console.ReadKey();
    }
}
Console.WriteLine(myKuh.Colour);
Console.WriteLine(myKuh2.Colour);