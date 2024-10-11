Console.WriteLine("Schreibe einen Datentyp welcher konvertiert werden soll");
string userInput = Console.ReadLine();
string output = "";
try

 int intInput = int.Parse(userInput);
    output = "Das ist ein int: " + intInput;

catch
{
    try
    {
    bool boolOut = false;
        if (userInput.ToLower() == "true" || userInput.ToLower() == "wahr")
        {
            boolOut = true;
        }
        else if (userInput.ToLower() == "false" || userInput.ToLower() == "falsch")
        {
            boolOut = false;

        }
         output = "Das ist ein bool: " + boolOut;
        }
         catch 
    {
        try
        {

            double doubleInput = double.Parse(userInput);
                output = "Das ist ein double: " + doubleInput;
            // Da ich hier double verwende und unten date muss ich bei double in die Konsole ein "," statt einem "." hinschreiben
        }
        catch
        {
            try
            {
                string[] splitInput = userInput.Split('.');
                if(splitInput.Length >= 3)
                {
                    DateTime dateInput = DateTime.Parse(userInput);
                    output = "Das ist ein Datum: " + dateInput;
                }
                }
            catch
            {
                Console.WriteLine("Das ist kein Int, kein Datum, kein Double");
            }

        }

    }
}

Console.WriteLine(output);
Footer

