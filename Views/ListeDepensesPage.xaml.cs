using MauiApp1.ViewModels;

namespace MauiApp1.Views;
<<<<<<< HEAD
public partial class ListeDepensesPage:ContentPage {
 private readonly ListeDepensesViewModel modele=new();
 public ListeDepensesPage() {BindingContext=modele;InitializeComponent();}
 // À chaque apparition (ex. au retour de la page Ajouter), on relit la base.
 protected override async void OnAppearing(){base.OnAppearing();await modele.Charger();}
}
=======

public partial class ListeDepensesPage : ContentPage
{
    private readonly ListeDepensesViewModel modele = new();

    public ListeDepensesPage()
    {
        InitializeComponent();
        BindingContext = modele;
    }

    // Recharge les dépenses chaque fois qu'on revient sur la page.
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await modele.Charger();
    }
}
>>>>>>> ffda002 (Mise a jour de la liste des depenses)
