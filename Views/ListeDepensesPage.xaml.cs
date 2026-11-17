
using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class ListeDepensesPage : ContentPage
{
    private readonly ListeDepensesViewModel modele = new();

    public ListeDepensesPage()
    {
        BindingContext = modele;
        InitializeComponent();
    }

    // Recharger les dépenses chaque fois qu'on ouvre la liste.
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await modele.Charger();
    }
}
