using MauiApp1.Models;
using SQLite;

namespace MauiApp1.Services;

// Ouvre depenses.db3 et expose les gestes sur la table. Les pages ne connaissent pas le chemin.
public class DepotDepenses
{
    private readonly SQLiteAsyncConnection baseDeDonnees;

    public DepotDepenses()
    {
        // L'application démarre dans bin. On remonte jusqu'au fichier GestionnaireDepenses.csproj
        // pour créer depenses.db3 dans le dossier du projet. Le fichier y survit à la fermeture.
        DirectoryInfo? dossier = new DirectoryInfo(AppContext.BaseDirectory);
        while (dossier != null && !File.Exists(Path.Combine(dossier.FullName, "GestionnaireDepenses.csproj")))
        {
            dossier = dossier.Parent;
        }

        string chemin = Path.Combine(dossier?.FullName ?? AppContext.BaseDirectory, "depenses.db3");
        this.baseDeDonnees = new SQLiteAsyncConnection(chemin);
    }

    // Crée la table si elle n'existe pas. La première fois seulement, on y met les trois exemples.
    public async Task Initialiser()
    {
        await this.baseDeDonnees.CreateTableAsync<Depense>();

        if (await this.baseDeDonnees.Table<Depense>().CountAsync() == 0)
        {
            await this.baseDeDonnees.InsertAllAsync(new[]
            {
                new Depense { Description = "Restaurant", Categorie = "Alimentation", Date = new DateTime(2026, 9, 20), Montant = 25.50m },
                new Depense { Description = "Essence", Categorie = "Transport", Date = new DateTime(2026, 9, 21), Montant = 60m },
                new Depense { Description = "Épicerie", Categorie = "Alimentation", Date = new DateTime(2026, 9, 22), Montant = 85.30m }
            });
        }
    }

    // Toutes les lignes, la plus récente en premier.
    public Task<List<Depense>> Lire()
    {
        return this.baseDeDonnees.Table<Depense>().OrderByDescending(d => d.Date).ToListAsync();
    }

    // Id vaut 0 : la base choisit le numéro et le recopie dans l'objet.
    public Task<int> Ajouter(Depense depense)
    {
        return this.baseDeDonnees.InsertAsync(depense);
    }

    // Déjà prêts pour le module 7 (modifier et supprimer).
    public Task<int> Modifier(Depense depense)
    {
        return this.baseDeDonnees.UpdateAsync(depense);
    }

    public Task<int> Supprimer(Depense depense)
    {
        return this.baseDeDonnees.DeleteAsync(depense);
    }
}
