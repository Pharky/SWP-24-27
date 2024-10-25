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

/*
Theoriefragen:

1) Was ist eine Kontrollstruktur? Welche Kontrollstrukturen kennen Sie in C#?
   - Eine Kontrollstruktur ist ein Programmierkonstrukt, das den Ablauf und die Ausführung eines Programms steuert. In C# gibt es verschiedene Kontrollstrukturen:
     - Bedingte Anweisungen: `if`, `else if`, `else`, `switch`
     - Schleifen: `for`, `while`, `do-while`, `foreach`
     - Schleifensteuerungen: `break`, `continue`, `return`, `goto`
     Kontrollstrukturen helfen, Wiederholungen oder Bedingungen für den Code zu machen

2) Was bedeutet der Begriff Clean Code in der Softwareentwicklung? Welche Clean-Code-Prinzipien kennen Sie?
   - Clean Code bezieht sich auf Code, der gut strukturiert, lesbar und leicht wartbar ist. Ziel von Clean Code ist es, dass der Code auch von anderen Entwicklern schnell verstanden und geändert werden kann.
     Clean-Code-Prinzipien umfassen unter anderem:
       - **Kleine, fokussierte Funktionen**: Jede Funktion sollte nur eine Aufgabe haben.
       - **Einheitliche Formatierung**: Konsistente Einrückungen, Leerzeilen und Struktur für eine saubere Code-Optik.
       - **Vermeidung von Code-Duplikaten**: Wiederholter Code sollte in eine eigene Methode oder Klasse ausgelagert werden.
       - **Fehlerbehandlung**: Möglichst präzise und verständliche Fehlerbehandlungen und -meldungen.
       - **besser lesbarer code**: kann z.B. mit CamelCasing erzielt werden, das hilft dabei lange Schlangen viel einfacher lesbar zu machen.

3) Was ist der Unterschied zwischen der Methode Parse und TryParse in C#? Auf was müssen Sie bei der Verwendung der Methode Parse achten?
   - `Parse` und `TryParse` sind Methoden, um Zeichenketten in numerische Typen wie `int`, `double`, etc. umzuwandeln.
     - `Parse`: Wandelt die Zeichenkette in einen numerischen Typ um, löst jedoch eine Ausnahme (Exception) aus, wenn die Konvertierung fehlschlägt.
     - `TryParse`: Versucht die Konvertierung, gibt `true` zurück, wenn sie erfolgreich war, und `false`, wenn sie fehlschlägt, ohne eine Ausnahme auszulösen.
     Bei `Parse` muss sichergestellt sein, dass die Zeichenkette tatsächlich den gewünschten numerischen Wert enthält, um Fehler zu vermeiden.

4) Was genau macht folgender C#-Code: `int myInt = 42;`
   - Der Code `int myInt = 42;` deklariert eine Ganzzahlvariable namens `myInt` und weist ihr den Wert `42` zu. `int` ist der Datentyp (Ganzzahl), `myInt` ist der Name der Variablen, und `42` ist der Wert, der in `myInt` gespeichert wird.
*/
