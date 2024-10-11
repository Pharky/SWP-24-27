Console.WriteLine("Wählen sie eine Rechenoperation aus");
Console.WriteLine("1: Wurzel");
Console.WriteLine("2: Potenzieren");
Console.WriteLine("3: Fakultät");
Console.WriteLine("4: BMI");
Console.WriteLine("5: Quadratische Flächen");
Console.WriteLine("6: Volumen");


int chooseOperator = int.Parse(Console.ReadLine()); 
MathOperation operation = new MathOperation();

switch (chooseOperator)
{
    case 1:

        Console.WriteLine("Gebe ein von was du die Wurzel ziehen willst");
        double wurzelInput = Convert.ToDouble(Console.ReadLine());
        double wurzelErgebnis = Math.Sqrt(wurzelInput);
        Console.WriteLine("Das Ergebnis ist: " + wurzelErgebnis);

        break;

    case 2:
        Console.WriteLine("Gebe ein von was du Potenzieren willst!");
        double basenInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gebe deine Exponente ein");
        double potenzInput = Convert.ToDouble(Console.ReadLine());
        double potenzErgebnis = Math.Pow(basenInput, potenzInput);
        Console.WriteLine("Das Ergebnis ist: " + potenzErgebnis);

        break;
    case 3:
        Console.WriteLine("Schreibe die Zahl ein von der du die Fakultät herausfinden willst");
        int fakultätInput = int.Parse(Console.ReadLine());
        long fakultätErgebnis = operation.Fakultät(fakultätInput);
        Console.WriteLine("Das Ergebnis ist: " + fakultätErgebnis);
        break;
    case 4:

        Console.WriteLine("Gebe dein Gewicht ein: ");
        double gewichtInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gebe deine Größe ein: ");
        double größeInput = Convert.ToDouble(Console.ReadLine());
        double BMI = operation.BMI(gewichtInput, größeInput);

        if(BMI < 18.5)
        {
            Console.WriteLine("Du hast einen BMI von " + BMI + " und bist untergewichtigt");
        } else if(BMI <= 18.5 || BMI <= 24.9)
        {
            Console.WriteLine("Du hast einen BMI von " + BMI + " und bist im Normalgewicht");
        } else if (BMI >25 || BMI < 29.9)
        {
            Console.WriteLine("Du hast einen BMI von " + BMI + " und bist im Übergewicht");
        } else if(BMI> 30)
        {
            Console.WriteLine("Du hast einen BMI von " + BMI + " und bist im Fettleibigkeit");
        }
        break;
    case 5:
        Console.WriteLine("Gebe die Seite A ein: ");
        double seiteA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gebe die Seite B ein: ");
        double seiteB = Convert.ToDouble(Console.ReadLine());
        double flächenErgebnis = operation.Quadrat(seiteA, seiteB);
        Console.WriteLine("Die Fläche der Form ist: " + flächenErgebnis + "m2");
        break;

}


class MathOperation
{
    public long Fakultät(int Zahl)
    {
        long fakultätErgebnis = 1;
        for (int i = 1; i <= Zahl; i++)
        {
            fakultätErgebnis *= i;
        }
        return fakultätErgebnis;
    }
    public double BMI(double gewicht, double größe)
    {
        double BMI = gewicht/(größe * größe);
        return BMI;       
    }

    public double Quadrat(double seiteA, double seiteB)
    {
        double flächeQuadrat = seiteA * seiteB;
        return flächeQuadrat;
    }
}