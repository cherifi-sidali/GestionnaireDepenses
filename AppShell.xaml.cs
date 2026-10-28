using MauiApp1.Views;
namespace MauiApp1;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(AjouterDepensePage), typeof(AjouterDepensePage));
        Routing.RegisterRoute(nameof(DetailDepensePage), typeof(DetailDepensePage));
        Routing.RegisterRoute("ListeDepuisAccueil", typeof(ListeDepensesPage));
    }
}
