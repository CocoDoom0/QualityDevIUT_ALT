namespace Exercice_1.Classes;

public class Media
{
    public string Titre { get; set; }
    
    public int NumRef { get; set; }
    
    public int NbExemplaires { get; set; }

    public bool Emprunte { get; set; } = false;
    
    public string? NomEmprunteur { get; set; }
    
    public string? PrenomEmprunteur { get; set; }
    
    public string? AdresseEmprunteur { get; set; }
    
    public string? TelEmprunteur { get; set; }
    
    public string? EmailEmprunteur { get; set; }
    
    public DateTime? DateEmprunt { get; set; }
    
    
    public static Media operator +(Media media, int nbExemplaires)
    {
        media.NbExemplaires += nbExemplaires;
        return media;
    }
    
    public static Media operator -(Media media, int nbExemplaires)
    {
        media.NbExemplaires -= nbExemplaires;
        return media;
    }
    
}