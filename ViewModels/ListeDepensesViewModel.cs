using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.Views;
using System.Collections.ObjectModel;
namespace MauiApp1.ViewModels;
public class ListeDepensesViewModel:BaseViewModel {
 private readonly DepotDepenses depot=new();
 // La CollectionView lit cette collection. Charger() la remplit à partir de depenses.db3.
 public ObservableCollection<Depense> Lignes {get;}=new();
    // Copie complète des dépenses
    private readonly List<Depense> toutes = new();

    private string recherche = "";
    private string filtre = "Toutes";

    // Catégories disponibles
    public string[] Filtres { get; } =
    {
    "Toutes",
    "Alimentation",
    "Transport",
    "Logement",
    "Loisirs",
    "Autre"
};

    // Recherche par description
    public string Recherche
    {
        get => recherche;
        set
        {
            recherche = value ?? "";
            Notifier();
            Afficher();
        }
    }

    // Filtrage par catégorie
    public string Filtre
    {
        get => filtre;
        set
        {
            filtre = string.IsNullOrWhiteSpace(value) ? "Toutes" : value;
            Notifier();
            Afficher();
        }
    }
    private Depense? selection;
 public Depense? Selection {get=>selection;set{selection=value;Notifier();}}
 public Command AjouterCommand {get;}=new(async()=>await Shell.Current.GoToAsync(nameof(AjouterDepensePage)));
 public Command RetourCommand {get;}=new(async()=>await Shell.Current.GoToAsync(".."));
 public Command<Depense> OuvrirCommand {get;}=new(async d=>{if(d!=null){ CarnetDepenses.Partage.Ouverte=d; await Shell.Current.GoToAsync(nameof(DetailDepensePage)); }});
 public Command DetailCommand {get;}
 public ListeDepensesViewModel(){DetailCommand=new Command(async()=>{
 if(Selection==null)await Shell.Current.DisplayAlertAsync("Information","Veuillez sélectionner une dépense.","OK");
 else { CarnetDepenses.Partage.Ouverte=Selection; await Shell.Current.GoToAsync(nameof(DetailDepensePage)); }});}
    // Crée la table au besoin, lit les lignes et remplace le contenu de Lignes.
    public async Task Charger()
    {
        await depot.Initialiser();

        List<Depense> lignes = await depot.Lire();

        toutes.Clear();
        toutes.AddRange(lignes);

        Afficher();
    }

    // Recopie dans Lignes seulement les dépenses qui passent les filtres.
    private void Afficher()
    {
        Lignes.Clear();

        foreach (Depense ligne in toutes)
        {
            if (Correspond(ligne))
            {
                Lignes.Add(ligne);
            }
        }
    }

    private bool Correspond(Depense ligne)
    {
        string texte = Recherche.Trim();

        if (texte.Length > 0 &&
            !ligne.Description.Contains(texte, StringComparison.OrdinalIgnoreCase))
            return false;

        if (Filtre != "Toutes" && ligne.Categorie != Filtre)
            return false;

        return true;
    }
}
