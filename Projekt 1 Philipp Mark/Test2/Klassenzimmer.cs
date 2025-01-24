using System;
using System.Collections.Generic;
public class Klassenzimmer
{
    public int RaumGroeﬂe { get; set; }
    public string Name { get; set; }
    public int AnzahlPlaetze { get; set; }
    public bool HatCynap { get; set; }
    public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();
}
