namespace Exercice_1.Classes;

public class DVD : Media
{
    public string Realisateur { get; set; }
    
    public string Duree { get; set; }
    
    public string Format { get; set; }

    public void AfficherInfos()
    {
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Numéro de référence: {NumRef}");
        Console.WriteLine($"Nombre d'exemplaires: {NbExemplaires}");
        Console.WriteLine($"Réalisateur: {Realisateur}");
        Console.WriteLine($"Durée: {Duree}");
        Console.WriteLine($"Format: {Format}");
    }
}