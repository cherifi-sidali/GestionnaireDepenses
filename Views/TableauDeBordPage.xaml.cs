using MauiApp1.ViewModels;
namespace MauiApp1.Views;
public partial class TableauDeBordPage:ContentPage {
 private readonly TableauDeBordViewModel modele=new();
 public TableauDeBordPage() {BindingContext=modele;InitializeComponent();}
 // À chaque apparition, on recalcule le total à partir de la base.
 protected override async void OnAppearing(){base.OnAppearing();await modele.Charger();}
}
