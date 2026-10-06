Console.Write("Gib einen Wert ein: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int integerValue))
{
    Console.WriteLine("Die Eingabe ist ein Integer.");
}
else if (bool.TryParse(input, out bool boolValue)) 
{
    Console.WriteLine("Die Eingabe ist ein Bool.");
}
else if (double.TryParse(input, out double doubleValue))
{
    Console.WriteLine("Die Eingabe ist eine rationale Zahl (Double).");
}
else
{
    Console.WriteLine("Die Eingabe ist ein String.");
    Console.WriteLine("Drücke Enter zum Beenden...");
    Console.ReadLine();