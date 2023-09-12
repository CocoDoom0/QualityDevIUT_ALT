
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
}