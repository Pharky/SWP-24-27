using System;
using System.Collections.Generic;
using SWP_Test_2;

namespace SWP_Test_2;
public class Klassenzimmer
{
    public double Laenge { get; set; }
    public double Breite { get; set; }
    public double Hoehe { get; set; }
    public int AnzahlPlaetze { get; set; }
    public bool HatCynap { get; set; }
    public string? Name { get; set; }

    public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();
    public double Größe()
    {
        return Laenge * Breite * Hoehe;
    }
}
