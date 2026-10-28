using MauiApp1.Models;
using MauiApp1.Views;
using System.Collections.ObjectModel;
namespace MauiApp1.ViewModels;
public class ListeDepensesViewModel:BaseViewModel {
 public ObservableCollection<Depense> Lignes=>CarnetDepenses.Partage.Lignes;
 private Depense? selection;
 public Depense? Selection {get=>selection;set{selection=value;Notifier();}}
 public Command AjouterCommand {get;}=new(async()=>await Shell.Current.GoToAsync(nameof(AjouterDepensePage)));
 public Command RetourCommand {get;}=new(async()=>await Shell.Current.GoToAsync(".."));
 public Command<Depense> OuvrirCommand {get;}=new(async d=>{if(d!=null){ CarnetDepenses.Partage.Ouverte=d; await Shell.Current.GoToAsync(nameof(DetailDepensePage)); }});
 public Command DetailCommand {get;}
 public ListeDepensesViewModel(){DetailCommand=new Command(async()=>{
 if(Selection==null)await Shell.Current.DisplayAlertAsync("Information","Veuillez sélectionner une dépense.","OK");
 else { CarnetDepenses.Partage.Ouverte=Selection; await Shell.Current.GoToAsync(nameof(DetailDepensePage)); }});}
}
