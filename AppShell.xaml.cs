namespace MauiApp1;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // On écrit Views. devant chaque page : sinon C# prend les anciennes pages
        // (à la racine du projet) qui gardaient les dépenses seulement en mémoire.
        Routing.RegisterRoute(nameof(Views.AjouterDepensePage), typeof(Views.AjouterDepensePage));
        Routing.RegisterRoute(nameof(Views.DetailDepensePage), typeof(Views.DetailDepensePage));
        Routing.RegisterRoute("ListeDepuisAccueil", typeof(Views.ListeDepensesPage));
    }
}
