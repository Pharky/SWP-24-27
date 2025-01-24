using System;

namespace Test2;
public class Person
{
    public string Geschlecht { get; set; }
    public DateTime Geburtsdatum { get; set; }

    public int Alter => DateTime.Now.Year - Geburtsdatum.Year;
}
