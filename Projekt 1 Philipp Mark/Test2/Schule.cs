using System;
using System.Collections.Generic;
using System.Linq;
public class Schule
{
    public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();
    public List<Klassenzimmer> KlassenzimmerListe { get; set; } = new List<Klassenzimmer>();

    public int AnzahlSchueler()
    {
        return SchuelerListe.Count;
    }

    public (int Maennlich, int Weiblich) AnzahlGeschlechter()
    {
        int maennlich = SchuelerListe.Count(s => s.Geschlecht == "männlich");
        int weiblich = SchuelerListe.Count(s => s.Geschlecht == "weiblich");
        return (maennlich, weiblich);
    }

    public double Durchschnittsalter()
    {
        if (SchuelerListe.Count == 0) return 0;
        return SchuelerListe.Average(s => s.Alter);
    }

    public int AnzahlKlassenzimmer()
    {
        return KlassenzimmerListe.Count;
    }

    public bool KannKlasseUnterrichten(string raumName, string klassenName)
    {
        var raum = KlassenzimmerListe.FirstOrDefault(r => r.Name == raumName);
        var schuelerAnzahl = SchuelerListe.Count(s => s.KlassenName == klassenName);
        return raum != null && raum.AnzahlPlaetze >= schuelerAnzahl;
    }
}
