using SQLite;

namespace MauiApp1.Models;

// Une ligne de la table Depense. sqlite-net fabrique les colonnes à partir des propriétés publiques.
public class Depense
{
    // Clé de la ligne. On laisse 0 : AutoIncrement fait choisir le numéro par la base à l'insertion.
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Description { get; set; } = "";
    public string Categorie { get; set; } = "";
    public decimal Montant { get; set; }
    public DateTime Date { get; set; } = DateTime.Today;

    // Textes calculés pour l'affichage. Ignore : la table ne les stocke pas.
    [Ignore]
    public string Resume => $"{Description} - {Categorie} - {Date:dd/MM/yyyy} - {Montant:N2} $";

    [Ignore]
    public string DateAffiche => Date.ToString("dd/MM/yyyy");

    [Ignore]
    public string MontantAffiche => $"{Montant:N2} $";
}
