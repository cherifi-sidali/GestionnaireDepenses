using MauiApp1.Models;
namespace MauiApp1.ViewModels;
public class DetailDepenseViewModel {
 public string Description {get;}
 public string Categorie {get;}
 public string Date {get;}
 public string Montant {get;}
 public Command RetourCommand {get;}=new(async()=>await Shell.Current.GoToAsync(".."));
 public DetailDepenseViewModel(){var d=CarnetDepenses.Partage.Ouverte;Description=d?.Description??"";Categorie=d?.Categorie??"";Date=d?.DateAffiche??"";Montant=d?.MontantAffiche??"";}
}
