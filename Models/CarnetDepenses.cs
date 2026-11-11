namespace MauiApp1.Models;

// Les dépenses sont maintenant dans depenses.db3 (voir Services/DepotDepenses).
// Le carnet garde seulement la dépense ouverte, pour la page Détail.
public class CarnetDepenses
{
    public static CarnetDepenses Partage { get; } = new();

    public Depense? Ouverte { get; set; }
}
