using MauiApp1.Models;
using MauiApp1.Services;
using System.Globalization;
namespace MauiApp1.ViewModels;
public class AjoutDepenseViewModel:BaseViewModel {
 private readonly DepotDepenses depot=new();
 private string description="",montant="";
 private string? categorie;
 private DateTime? date=DateTime.Today;
 // 0 : le formulaire ajoute. Un autre numéro : il modifie cette dépense.
 private int idEnCours;
 public string Description {get=>description;set{description=value;Notifier();}}
 public string Montant {get=>montant;set{montant=value;Notifier();}}
 public string? Categorie {get=>categorie;set{categorie=value;Notifier();}}
 public DateTime? Date {get=>date;set{date=value;Notifier();}}
 public string[] Categories {get;}={"Alimentation","Transport","Logement","Loisirs","Autre"};
 // Le titre et le bouton changent selon le mode (ajout ou modification).
 public string TitrePage => idEnCours==0 ? "Ajouter une dépense" : "Modifier la dépense";
 public string LibelleAction => idEnCours==0 ? "Ajouter" : "Enregistrer";
 public Command AjouterCommand {get;}
 public Command RetourCommand {get;}=new(async()=>await Shell.Current.GoToAsync(".."));
 public AjoutDepenseViewModel(){
 AjouterCommand=new Command(async()=>await Ajouter());
 // La page Détail met EnModification à true et garde la dépense dans Ouverte.
 Depense? d=CarnetDepenses.Partage.Ouverte;
 if(CarnetDepenses.Partage.EnModification && d!=null){
 // On préremplit le formulaire avec la dépense choisie.
 idEnCours=d.Id;
 Description=d.Description;
 Montant=d.Montant.ToString("0.00",CultureInfo.CurrentCulture);
 Categorie=d.Categorie;
 Date=d.Date;
 // On remet le mode ajout : la prochaine ouverture du formulaire sera un ajout.
 CarnetDepenses.Partage.EnModification=false;
 }
 }
 private async Task Ajouter(){
 if(string.IsNullOrWhiteSpace(Description)){await Shell.Current.DisplayAlertAsync("Erreur","Veuillez entrer une description.","OK");return;}
 if(string.IsNullOrWhiteSpace(Montant)||!decimal.TryParse(Montant,NumberStyles.Number,CultureInfo.CurrentCulture,out var valeur)||valeur<0){await Shell.Current.DisplayAlertAsync("Erreur","Veuillez entrer un montant valide.","OK");return;}
 if(string.IsNullOrWhiteSpace(Categorie)){await Shell.Current.DisplayAlertAsync("Erreur","Veuillez choisir une catégorie.","OK");return;}
 // Enregistre la dépense dans depenses.db3.
 await depot.Initialiser();
 Depense depense=new Depense{Id=idEnCours,Description=Description.Trim(),Montant=valeur,Categorie=Categorie,Date=Date??DateTime.Today};
 if(idEnCours==0){
 // Id à 0 : la base choisit le numéro à l'insertion.
 await depot.Ajouter(depense);
 await Shell.Current.DisplayAlertAsync("Succès","La dépense a été ajoutée.","OK");
 await Shell.Current.GoToAsync("..");
 }
 else{
 // UpdateAsync retrouve la ligne grâce à l'Id. Le numéro ne change pas.
 await depot.Modifier(depense);
 CarnetDepenses.Partage.Ouverte=depense;
 await Shell.Current.DisplayAlertAsync("Succès","La dépense a été modifiée.","OK");
 // On saute la page Détail (elle montre l'ancien texte) et on revient à la liste.
 await Shell.Current.GoToAsync("../..");
 }
 }
}
