
using System.Text.Json;
using Exercice_1.Classes;
namespace Exercice_1.Library;

public class Library
{
    public List<Media> Medias { get; set; } = new List<Media>();

    public void AddMedia(Media media)
    {
        Medias.Add(media);
    }

    public void RemoveMedia(Media media)
    {
        Medias.Remove(media);
    }   
    
    public Media this[int index]
    {
        get => Medias[index];
        set => Medias[index] = value;
    }
    
    public void EmprunterMedia(Media media, string nomEmprunteur, string prenomEmprunteur, string adresseEmprunteur, string telEmprunteur, string emailEmprunteur)
    {
        if (media.NbExemplaires > 0 && !media.Emprunte)
        {
            media.Emprunte = true;
            media.NomEmprunteur = nomEmprunteur;
            media.PrenomEmprunteur = prenomEmprunteur;
            media.AdresseEmprunteur = adresseEmprunteur;
            media.TelEmprunteur = telEmprunteur;
            media.EmailEmprunteur = emailEmprunteur;
            media.DateEmprunt = DateTime.Now;
            media.NbExemplaires--;
        }
    }
    
    public void RendreMedia(Media media)
    {
        if (media.Emprunte)
        {
            media.Emprunte = false;
            media.NomEmprunteur = null;
            media.PrenomEmprunteur = null;
            media.AdresseEmprunteur = null;
            media.TelEmprunteur = null;
            media.EmailEmprunteur = null;
            media.DateEmprunt = null;
            media.NbExemplaires++;
        }
    }
    
    public List<Media> RechercherMedia(string recherche)
    {
        List<Media> medias = new List<Media>();
        
        foreach (var media in Medias)
        {
            switch (media)
            {
                case CD:
                    if (media.Titre.Contains(recherche) || ((CD) media).Auteur.Contains(recherche) || ((CD) media).Editeur.Contains(recherche))
                    {
                        medias.Add(media);
                    }
                    break;
                case DVD:
                    if (media.Titre.Contains(recherche) || ((DVD) media).Realisateur.Contains(recherche))
                    {
                        medias.Add(media);
                    }
                    break;
                case Livre:
                    if (media.Titre.Contains(recherche) || ((Livre) media).Auteur.Contains(recherche) || ((Livre) media).Editeur.Contains(recherche))
                    {
                        medias.Add(media);
                    }
                    break;
                default:
                    if(media.Titre.Contains(recherche))
                        medias.Add(media);
                    break;
            }
        }
        return medias;
    }
    
    public List<Media> RechercherMediaEmprunte(string nomEmprunteur, string prenomEmprunteur)
    {
        List<Media> medias = new List<Media>();
        
        foreach (var media in Medias)
        {
            if (media.NomEmprunteur == nomEmprunteur && media.PrenomEmprunteur == prenomEmprunteur)
            {
                medias.Add(media);
            }
        }
        return medias;
    }
    public void AfficherStats()
    {
        int totalMedia = 0;
        int totalMediaEmprunte = 0;
        int totalMediaNonEmprunte = 0;
        
        foreach (var media in Medias)
        {
            totalMedia++;
            if (media.Emprunte)
            {
                totalMediaEmprunte++;
            }
            else
            {
                totalMediaNonEmprunte++;
            }
        }
        
        Console.WriteLine($"Total de médias: {totalMedia}");
        Console.WriteLine($"Total de médias empruntés: {totalMediaEmprunte}");
        Console.WriteLine($"Total de médias non empruntés: {totalMediaNonEmprunte}");
    }
    
    public void ExportJson()
    {
        string json = JsonSerializer.Serialize(Medias);
        File.WriteAllText("medias.json", json);
    }
    
    public void ImportJson()
    {
        string json = File.ReadAllText("medias.json");
        Medias = JsonSerializer.Deserialize<List<Media>>(json);
    }
}