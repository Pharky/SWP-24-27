using System;
using System.Collections.Generic;

namespace SchulVerwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Schule initialisieren
            Schule meineSchule = new Schule();

            // Schüler hinzufügen
            meineSchule.SchuelerListe.Add(new Schueler { RaumName = "Anna", Geschlecht = "weiblich", Geburtsdatum = new DateTime(2008, 5, 21), KlassenName = "3bWi" });
            meineSchule.SchuelerListe.Add(new Schueler { RaumName = "Max", Geschlecht = "männlich", Geburtsdatum = new DateTime(2007, 9, 12), KlassenName = "3bWi" });

            // Klassenräume hinzufügen
            meineSchule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 101", AnzahlPlaetze = 30, HatCynap = true });
            meineSchule.KlassenzimmerListe.Add(new Klassenzimmer { Name = "Raum 102", AnzahlPlaetze = 20, HatCynap = false });

            // Methoden testen
            Console.WriteLine($"Anzahl der Schüler: {meineSchule.AnzahlSchueler()}");
            var geschlechter = meineSchule.AnzahlGeschlechter();
            Console.WriteLine($"Anzahl der männlichen Schüler: {geschlechter.Maennlich}");
            Console.WriteLine($"Anzahl der weiblichen Schüler: {geschlechter.Weiblich}");
            Console.WriteLine($"Durchschnittsalter der Schüler: {meineSchule.Durchschnittsalter()} Jahre");
            Console.WriteLine($"Anzahl der Klassenräume: {meineSchule.AnzahlKlassenzimmer()}");

            // Überprüfen, ob ein Raum eine Klasse unterrichten kann
            Console.WriteLine($"Kann die Klasse '3bWi' in Raum 101 unterrichtet werden? {meineSchule.KannKlasseUnterrichten("Raum 101", "3bWi")}");
        }
    }
}
