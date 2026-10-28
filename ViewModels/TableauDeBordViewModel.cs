using MauiApp1.Models;
using System.Linq;
namespace MauiApp1.ViewModels;
public class TableauDeBordViewModel:BaseViewModel {
 public string Total=>$"{CarnetDepenses.Partage.Lignes.Sum(d=>d.Montant):N2} $";
 public int Nombre=>CarnetDepenses.Partage.Lignes.Count;
 public Command VoirDepensesCommand {get;}=new(async()=>await Shell.Current.GoToAsync("ListeDepuisAccueil"));
 public TableauDeBordViewModel(){CarnetDepenses.Partage.Lignes.CollectionChanged+=(_,_)=>{Notifier(nameof(Total));Notifier(nameof(Nombre));};}
}
