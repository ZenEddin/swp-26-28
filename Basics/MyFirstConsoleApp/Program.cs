using System;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie eine natürliche Zahl ein: ");
        int zahl = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation auszuwählen:");
        Console.WriteLine("1) Quadrat");
        Console.WriteLine("2) Wurzel");
        Console.WriteLine("3) Fakultät");
        Console.Write("Ihre Auswahl: ");

        int auswahl = Convert.ToInt32(Console.ReadLine());

        switch (auswahl)
        {
            case 1:
                Console.WriteLine("Das Quadrat ist: " + (zahl * zahl));
                break;

            case 2:
                Console.WriteLine("Die Wurzel ist: " + Math.Sqrt(zahl));
                break;

            case 3:
                long fakultaet = 1;

                for (int i = 1; i <= zahl; i++)
                {
                    fakultaet *= i;
                }

                Console.WriteLine("Die Fakultät ist: " + fakultaet);
                break;

            default:
                Console.WriteLine("Ungültige Auswahl.");
                break;
        }
    }
}