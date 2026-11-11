using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.Views;
using System.Collections.ObjectModel;
namespace MauiApp1.ViewModels;
public class ListeDepensesViewModel:BaseViewModel {
 private readonly DepotDepenses depot=new();
 // La CollectionView lit cette collection. Charger() la remplit à partir de depenses.db3.
 public ObservableCollection<Depense> Lignes {get;}=new();
 private Depense? selection;
 public Depense? Selection {get=>selection;set{selection=value;Notifier();}}
 public Command AjouterCommand {get;}=new(async()=>await Shell.Current.GoToAsync(nameof(AjouterDepensePage)));
 public Command RetourCommand {get;}=new(async()=>await Shell.Current.GoToAsync(".."));
 public Command<Depense> OuvrirCommand {get;}=new(async d=>{if(d!=null){ CarnetDepenses.Partage.Ouverte=d; await Shell.Current.GoToAsync(nameof(DetailDepensePage)); }});
 public Command DetailCommand {get;}
 public ListeDepensesViewModel(){DetailCommand=new Command(async()=>{
 if(Selection==null)await Shell.Current.DisplayAlertAsync("Information","Veuillez sélectionner une dépense.","OK");
 else { CarnetDepenses.Partage.Ouverte=Selection; await Shell.Current.GoToAsync(nameof(DetailDepensePage)); }});}
 // Crée la table au besoin, lit les lignes et remplace le contenu de Lignes.
 public async Task Charger(){
 await depot.Initialiser();
 List<Depense> lignes=await depot.Lire();
 Lignes.Clear();
 foreach(Depense ligne in lignes)Lignes.Add(ligne);
 }
}
