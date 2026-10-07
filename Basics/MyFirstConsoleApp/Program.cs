Console.Write("Gib einen Wert ein: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out _))
{
    Console.WriteLine("Die Eingabe ist ein Integer.");
    return;
}
if (bool.TryParse(input, out _))
{
    Console.WriteLine("Die Eingabe ist ein Bool.");
    return;
}
if (double.TryParse(input, out _))
{
    Console.WriteLine("Die Eingabe ist eine rationale Zahl (Double).");
    return;
}
Console.WriteLine("Die Eingabe ist ein String.");
Console.WriteLine("Drücke Enter zum Beenden...");
Console.ReadLine();