using System;


namespace SWP_Test_2;

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

    public List<Klassenzimmer> GetKlassenzimmerMitCynap()
    {
        return KlassenzimmerListe.Where(r => r.HatCynap).ToList();
    }

    public int AnzahlKlassen()
    {
        return SchuelerListe.Select(s => s.KlassenName).Distinct().Count();
    }

    public Dictionary<string, int> KlassenMitAnzahlSchueler()
    {
        return SchuelerListe
            .GroupBy(s => s.KlassenName)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    public double FrauenanteilInKlasse(string klassenName)
    {
        var schuelerInKlasse = SchuelerListe.Where(s => s.KlassenName == klassenName).ToList();
        if (schuelerInKlasse.Count == 0) return 0;

        return (double)schuelerInKlasse.Count(s => s.Geschlecht == "weiblich") / schuelerInKlasse.Count * 100;
    }
}
