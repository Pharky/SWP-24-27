using System;
using System.Collections.Generic;

public class Katze
{
    public string Name { get; set; }
    public int Alter { get; set; }
    public string Color { get; set; }

    public Katze(string name, int alter, string color)
    {
        Name = name;
        Alter = alter;
        Color = color;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Alter: {Alter} Jahre, Color: {Color}";
    }
}

public class Tierheim
{
    private List<Katze> katzenListe;

    public Tierheim()
    {
        katzenListe = new List<Katze>();
    }

    public void KatzeHinzufuegen(Katze katze)
    {
        katzenListe.Add(katze);
        Console.WriteLine($"{katze.Name} wurde zum Tierheim hinzugefügt.");
    }

    public void AlleKatzenAnzeigen()
    {
        Console.WriteLine("Katzen im Tierheim:");
        foreach (var katze in katzenListe)
        {
            Console.WriteLine(katze);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Tierheim tierheim = new Tierheim();

        tierheim.KatzeHinzufuegen(new Katze("Gabriel", 16, "Black"));
        tierheim.KatzeHinzufuegen(new Katze("Kitty", 2, "White"));
        tierheim.AlleKatzenAnzeigen();
    }
}
