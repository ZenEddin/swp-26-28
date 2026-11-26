var myCow = new Cow("Ben", "weiß", new DateOnly(2021, 5, 10));
var myCat = new Cat("Alex", "schwarz", new DateOnly(2023, 9, 1));

myCow.MakeSound();
myCow.MakeSound(3);

myCat.MakeSound();
myCat.MakeSound(2);

Console.WriteLine($"{myCow.Name} ({myCow.Colour}), Alter: {myCow.GetAge()} Jahre");
Console.WriteLine($"{myCat.Name} ({myCat.Colour}), Alter: {myCat.GetAge()} Jahre");

var myCow2 = myCow;
myCow.Colour = "braun";
Console.WriteLine($"Gleiche Instanz: {myCow2 == myCow}, Farbe: {myCow2.Colour}");

abstract class Animal(string name, string colour, DateOnly birthDate)
{
    public string Name { get; } = name;
    public string Colour { get; set; } = colour;
    public DateOnly BirthDate { get; } = birthDate;

    public int GetAge()
    {
        var today = DateOnly.FromDateTime(DateTime.Today);
        var age = today.Year - BirthDate.Year;

        // Noch nicht Geburtstag gehabt in diesem Jahr -> 1 Jahr abziehen
        if (BirthDate > today.AddYears(-age))
        {
            age--;
        }

        return Math.Max(0, age);
    }

    public abstract void MakeSound();
    public abstract void MakeSound(int duration);
}

class Cow(string name, string colour, DateOnly birthDate) : Animal(name, colour, birthDate)
{
    public override void MakeSound() => Console.WriteLine("Muuuuh");

    public override void MakeSound(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Muuuuh");
        }
    }
}

class Cat(string name, string colour, DateOnly birthDate) : Animal(name, colour, birthDate)
{
    public override void MakeSound() => Console.WriteLine("Miau");

    public override void MakeSound(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Miau");
        }
    }
}

