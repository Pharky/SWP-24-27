cat.cs:
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
// eine eltern klasse animal die eine interne variable name hat die klasse leitet von dem tier ab und erbt somit das Attribut Name
namespace MyFirstCat
{
    class Cat : Animal
    {
        public string Color  { get; set; }
        public int Age { get { return (DateTime.Now.Year - _BirthDate.Year); } }
 
        public Cat(DateTime birthDate,string color = "Nicht Verfügbar", string name = "nicht Verfügbar") : base(name,birthDate)
        {
            Color = color;          
        }
        public override string ToString()
        {
            return $"Name: {Name}, Farbe: {Color}, Alter: {Age}";
        }
    }
}
Tierheim.cs
using MyFirstCat;
 
bool besuch = true;
Tierheim myTier = new Tierheim();
 
void tierConsole()
{
    while (besuch)
    {
        Console.WriteLine("Willst du ein Tier hinzufügen (yes/no)");
        string addCatRead = Console.ReadLine();
        if (addCatRead == "yes" || addCatRead == "no")
        {
            if (addCatRead == "yes")
            {
                Console.WriteLine("Wann ist das Tier geboren? ");
                string catBirthDate = Console.ReadLine();
                if (DateTime.TryParse(catBirthDate, out DateTime dtBirth))
                {
                    Console.WriteLine("Welche Farbe hat das Tier?");
                    string catColor = Console.ReadLine();
                    Console.WriteLine("Wie heißt das Tier?");
                    string catName = Console.ReadLine();
                    myTier.AddAnimal(new Cat(dtBirth, catColor, catName));
                    Console.WriteLine("Hier ist die Liste mit allen Katzen:");
                    myTier.ShowAnimals();
                    Console.WriteLine("Willst du noch eine weitere Katze hinzufügen? yes/no");
                    string addCatAgain = Console.ReadLine();
                    if (addCatAgain == "yes")
                    {
                        tierConsole();
                    } else if(addCatAgain == "no")
                    {
                        besuch = false;
                    }

                }
                else
                {
                    Console.WriteLine("Dies ist das falsche Format");
                }
            } else if(addCatRead == "no")
            {
                besuch = false;
            }
        }
        else
        {
            Console.WriteLine("Das ist keine gültige Eingabe!");
        }
    }
}
tierConsole();
Animal.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MyFirstCat
{
    class Animal : Lebewesen
    {
        public string Name { get; set; }
        public Animal(string name, DateTime birthDate) : base(birthDate)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
Lebewesen.cs:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MyFirstCat
{
    class Lebewesen
    {
        public DateTime _BirthDate { get; set; }
 
        public Lebewesen(DateTime birthDate)
        {
            _BirthDate = birthDate;
        }
    }
}
Tierheim.cs:
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyFirstCat
{
    class Tierheim
    {
        public List<Cat> tiere = new List<Cat>();
 
        public void AddAnimal(Cat cat)
        {
            tiere.Add(cat);
            Console.WriteLine($"\nEs wurde die neue Katze {cat} hinzugefügt!\n");
        }
        public void ShowAnimals()
        {
            int index = 1;
            foreach (var cat in tiere)
            {
                Console.WriteLine(cat);
            }
        }
    }
}