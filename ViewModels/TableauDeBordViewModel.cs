using MauiApp1.Models;
using MauiApp1.Services;
using System.Linq;
namespace MauiApp1.ViewModels;
public class TableauDeBordViewModel:BaseViewModel {
 private readonly DepotDepenses depot=new();
 private string total="0,00 $";
 private int nombre;
 public string Total {get=>total;set{total=value;Notifier();}}
 public int Nombre {get=>nombre;set{nombre=value;Notifier();}}
 public Command VoirDepensesCommand {get;}=new(async()=>await Shell.Current.GoToAsync("ListeDepuisAccueil"));
 // Relit depenses.db3 pour calculer le total et le nombre de transactions.
 public async Task Charger(){
 await depot.Initialiser();
 List<Depense> lignes=await depot.Lire();
 Total=$"{lignes.Sum(d=>d.Montant):N2} $";
 Nombre=lignes.Count;
 }
}
