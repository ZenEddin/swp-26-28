using System;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie eine Zahl oder Zeichenkette ein: ");
        string eingabe = Console.ReadLine() ?? "";

        if (int.TryParse(eingabe, out int zahl))
        {
            Console.WriteLine("Sie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplikation");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Fakultät");
            Console.WriteLine("5) Wurzelziehen");
            Console.Write("Ihre Auswahl: ");

            if (!int.TryParse(Console.ReadLine(), out int auswahl))
            {
                Console.WriteLine("Ungültige Eingabe!");
                return;
            }

            switch (auswahl)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Geben Sie die zweite Zahl ein: ");

                    if (!int.TryParse(Console.ReadLine(), out int zahl2))
                    {
                        Console.WriteLine("Ungültige Eingabe!");
                        return;
                    }

                    switch (auswahl)
                    {
                        case 1:
                            Console.WriteLine("Ergebnis: " + ((long)zahl + zahl2));
                            break;

                        case 2:
                            Console.WriteLine("Ergebnis: " + ((long)zahl * zahl2));
                            break;

                        case 3:
                            if (zahl2 == 0)
                            {
                                Console.WriteLine("Division durch 0 ist nicht möglich!");
                                return;
                            }

                            Console.WriteLine("Ergebnis: " + ((double)zahl / zahl2));
                            break;
                    }
                    break;

                case 4:
                    if (zahl < 0 || zahl > 20)
                    {
                        Console.WriteLine("Die Zahl muss zwischen 0 und 20 liegen.");
                        break;
                    }

                    long fakultaet = 1;

                    for (int i = 1; i <= zahl; i++)
                    {
                        fakultaet *= i;
                    }

                    Console.WriteLine("Ergebnis: " + fakultaet);
                    break;

                case 5:
                    if (zahl < 0)
                    {
                        Console.WriteLine("Keine reelle Wurzel aus einer negativen Zahl!");
                        break;
                    }

                    Console.WriteLine("Ergebnis: " + Math.Sqrt(zahl));
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl!");
                    break;
            }

            return;
        }

        Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
        Console.WriteLine("1) Alle Selbstlaute entfernen");
        Console.WriteLine("2) Die Zeichenkette umdrehen");
        Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");
        Console.Write("Ihre Auswahl: ");

        if (!int.TryParse(Console.ReadLine(), out int textAuswahl))
        {
            Console.WriteLine("Ungültige Eingabe!");
            return;
        }

        switch (textAuswahl)
        {
            case 1:
                string textOhneSelbstlaute = "";

                foreach (char zeichen in eingabe)
                {
                    if (!"aeiouAEIOU".Contains(zeichen))
                    {
                        textOhneSelbstlaute += zeichen;
                    }
                }

                Console.WriteLine("Ergebnis: " + textOhneSelbstlaute);
                break;

            case 2:
                string umgedreht = "";

                for (int i = eingabe.Length - 1; i >= 0; i--)
                {
                    umgedreht += eingabe[i];
                }

                Console.WriteLine("Ergebnis: " + umgedreht);
                break;

            case 3:
                Console.WriteLine("Anzahl der Zeichen: " + eingabe.Length);
                break;

            default:
                Console.WriteLine("Ungültige Auswahl!");
                break;
        }
    }
}