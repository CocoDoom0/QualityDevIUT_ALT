namespace Exercice_1.Classes;

public class CD : Media
{
    public string Auteur { get; set; }
    
    public string Editeur { get; set; }
    
    public int NbPistes { get; set; }
    
    public void AfficherInfos()
    {
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Numéro de référence: {NumRef}");
        Console.WriteLine($"Nombre d'exemplaires: {NbExemplaires}");
        Console.WriteLine($"Auteur: {Auteur}");
        Console.WriteLine($"Editeur: {Editeur}");
        Console.WriteLine($"Nombre de pistes: {NbPistes}");
    }
}