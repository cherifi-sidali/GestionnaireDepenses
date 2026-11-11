using MauiApp1.ViewModels;
namespace MauiApp1.Views;
public partial class ListeDepensesPage:ContentPage {
 private readonly ListeDepensesViewModel modele=new();
 public ListeDepensesPage() {BindingContext=modele;InitializeComponent();}
 // À chaque apparition (ex. au retour de la page Ajouter), on relit la base.
 protected override async void OnAppearing(){base.OnAppearing();await modele.Charger();}
}
