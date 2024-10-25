using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte gib eine Zahl oder einen Text ein: ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Sie haben eine ganze Zahl eingegeben. Welche mathematische Operation möchten Sie darauf ausführen?");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplikation");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Fakultät");
            Console.WriteLine("5) Wurzelziehen");
            
            int operation = int.Parse(Console.ReadLine());
            int secondNumber;
            double result = 0;

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Bitte gib eine zweite Zahl zum Addieren ein: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    result = number + secondNumber;
                    break;

                case 2:
                    Console.WriteLine("Bitte gib eine zweite Zahl zum Multiplizieren ein: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    result = number * secondNumber;
                    break;

                case 3:
                    Console.WriteLine("Bitte gib eine zweite Zahl zum Dividieren ein: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    if (secondNumber != 0)
                    {
                        result = (double)number / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Divisionen durch Null ist nicht erlaubt.");
                        return;
                    }
                    break;

                case 4:
                    result = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        result *= i;
                    }
                    break;

                case 5:
                    if (number >= 0)
                    {
                        result = Math.Sqrt(number);
                    }
                    else
                    {
                        Console.WriteLine("Bitte eine Zahl eingeben die größer oder gleich Null ist.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Bitte gib eine Zahl von 1-5 ein.");
                    return;
            }
            
            Console.WriteLine("Das Ergebnis ist: " + result);
        }
        else
        {
            Console.WriteLine("Sie haben eine Zeichenkette eingeben. Was wollen Sie damit machen?");
            Console.WriteLine("1) Alle Selbstlaute (a, e, i, o, u) entfernen");
            Console.WriteLine("2) Die Zeichenkette umdrehen (aus Hallo wird dann z.B. ollaH)");
            Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");

            int operation = int.Parse(Console.ReadLine());
            string result;

            switch (operation)
            {
                case 1:
                    result = RemoveVowels(input);
                    Console.WriteLine("Ergebnis: " + result);
                    break;

                case 2:
                    result = ReverseString(input);
                    Console.WriteLine("Ergebnis: " + result);
                    break;

                case 3:
                    Console.WriteLine("Anzahl der Zeichen: " + input.Length);
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }

    static string RemoveVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        foreach (char c in vowels)
        {
            input = input.Replace(c.ToString(), "");
        }
        return input;
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}