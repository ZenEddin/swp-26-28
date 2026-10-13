using System;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie eine natürliche Zahl ein: ");

        if (!int.TryParse(Console.ReadLine(), out int zahl) || zahl < 0)
        {
            Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine natürliche Zahl ein.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation auszuwählen:");
        Console.WriteLine("1) Quadrat");
        Console.WriteLine("2) Wurzel");
        Console.WriteLine("3) Fakultät");
        Console.Write("Ihre Auswahl: ");

        if (!int.TryParse(Console.ReadLine(), out int auswahl))
        {
            Console.WriteLine("Ungültige Eingabe!");
            return;
        }

        switch (auswahl)
        {
            case 1:
                long quadrat = (long)zahl * zahl;
                Console.WriteLine("Das Quadrat ist: " + quadrat);
                break;

            case 2:
                Console.WriteLine("Die Wurzel ist: " + Math.Sqrt(zahl));
                break;

            case 3:
                if (zahl > 20)
                {
                    Console.WriteLine("Die Zahl ist zu groß für die Fakultät mit long.");
                    break;
                }

                long fakultaet = 1;

                for (int i = 1; i <= zahl; i++)
                {
                    fakultaet *= i;
                }

                Console.WriteLine("Die Fakultät ist: " + fakultaet);
                break;

            default:
                Console.WriteLine("Ungültige Auswahl. Bitte 1, 2 oder 3 eingeben.");
                break;
        }
    }
}