using System;
using System.Collections.Generic;
using SWP_Test_2;

namespace SWP_Test_2;

public class SchuleTests
{
    public void Test_AnzahlSchueler()
    {
        var schule = new Schule();
        schule.SchuelerListe.Add(new Schueler { KlassenName = "3bWi", Geschlecht = "weiblich" });
        schule.SchuelerListe.Add(new Schueler { KlassenName = "3bWi", Geschlecht = "männlich" });

        int result = schule.AnzahlSchueler();

        Assert.Equal(2, result);
    }

    public void Test_AnzahlGeschlechter()
    {
        var schule = new Schule();
        schule.SchuelerListe.Add(new Schueler { Geschlecht = "männlich" });
        schule.SchuelerListe.Add(new Schueler { Geschlecht = "weiblich" });
        schule.SchuelerListe.Add(new Schueler { Geschlecht = "weiblich" });

        var result = schule.AnzahlGeschlechter();

        Assert.Equal(1, result.Maennlich);
        Assert.Equal(2, result.Weiblich);
    }

    public void Test_Durchschnittsalter()
    {
        var schule = new Schule();
        schule.SchuelerListe.Add(new Schueler { Geburtsdatum = new DateTime(2005, 1, 1) });
        schule.SchuelerListe.Add(new Schueler { Geburtsdatum = new DateTime(2010, 1, 1) });

        double result = schule.Durchschnittsalter();

        int currentYear = DateTime.Now.Year;
        Assert.Equal((currentYear - 2005 + currentYear - 2010) / 2.0, result, 1);
    }

    public void Test_AnzahlKlassenzimmer()
    {
        var schule = new Schule();
        schule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 101" });
        schule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 102" });

        int result = schule.AnzahlKlassenzimmer();

        Assert.Equal(2, result);
    }

    public void Test_GetKlassenzimmerMitCynap()
    {
        var schule = new Schule();
        schule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 101", HatCynap = true });
        schule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 102", HatCynap = false });

        var result = schule.GetKlassenzimmerMitCynap();

        Assert.Single(result);
        Assert.Equal("Raum 101", result[0].Name);
    }

    public void Test_FrauenanteilInKlasse()
    {
        var schule = new Schule();
        schule.SchuelerListe.Add(new Schueler { KlassenName = "3bWi", Geschlecht = "weiblich" });
        schule.SchuelerListe.Add(new Schueler { KlassenName = "3bWi", Geschlecht = "weiblich" });
        schule.SchuelerListe.Add(new Schueler { KlassenName = "3bWi", Geschlecht = "männlich" });

        double result = schule.FrauenanteilInKlasse("3bWi");

        Assert.Equal(66.67, result, 2);
    }
}
