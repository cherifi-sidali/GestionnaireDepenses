using MauiApp1.Models;
using System.Globalization;
namespace MauiApp1.ViewModels;
public class AjoutDepenseViewModel:BaseViewModel {
 private string description="",montant="";
 private string? categorie;
 private DateTime? date=DateTime.Today;
 public string Description {get=>description;set{description=value;Notifier();}}
 public string Montant {get=>montant;set{montant=value;Notifier();}}
 public string? Categorie {get=>categorie;set{categorie=value;Notifier();}}
 public DateTime? Date {get=>date;set{date=value;Notifier();}}
 public string[] Categories {get;}={"Alimentation","Transport","Logement","Loisirs","Autre"};
 public Command AjouterCommand {get;}
 public Command RetourCommand {get;}=new(async()=>await Shell.Current.GoToAsync(".."));
 public AjoutDepenseViewModel(){AjouterCommand=new Command(async()=>await Ajouter());}
 private async Task Ajouter(){
 if(string.IsNullOrWhiteSpace(Description)){await Shell.Current.DisplayAlertAsync("Erreur","Veuillez entrer une description.","OK");return;}
 if(string.IsNullOrWhiteSpace(Montant)||!decimal.TryParse(Montant,NumberStyles.Number,CultureInfo.CurrentCulture,out var valeur)||valeur<0){await Shell.Current.DisplayAlertAsync("Erreur","Veuillez entrer un montant valide.","OK");return;}
 if(string.IsNullOrWhiteSpace(Categorie)){await Shell.Current.DisplayAlertAsync("Erreur","Veuillez choisir une catégorie.","OK");return;}
 CarnetDepenses.Partage.Ajouter(new Depense{Description=Description.Trim(),Montant=valeur,Categorie=Categorie,Date=Date??DateTime.Today});
 await Shell.Current.DisplayAlertAsync("Succès","La dépense a été ajoutée.","OK");
 await Shell.Current.GoToAsync("..");
 }
}
