var myCow = new Cow("Ben", "weiß");
var myCat = new Cat("Alex", "schwarz");

myCow.MakeSound();
myCat.MakeSound();
Console.WriteLine($"{myCow.Name} ({myCow.Colour})");
Console.WriteLine($"{myCat.Name} ({myCat.Colour})");

var myCow2 = myCow;
myCow.Colour = "braun";
Console.WriteLine($"Gleiche Instanz: {myCow2 == myCow}, Farbe: {myCow2.Colour}");

abstract class Animal(string name, string colour)
{
    public string Name { get; } = name;
    public string Colour { get; set; } = colour;
    public abstract void MakeSound();
}

class Cow(string name, string colour) : Animal(name, colour)
{
    public override void MakeSound() => Console.WriteLine("Muuuuh");
}

class Cat(string name, string colour) : Animal(name, colour)
{
    public override void MakeSound() => Console.WriteLine("Miau");
}