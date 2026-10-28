using System.Collections.ObjectModel;
namespace MauiApp1.Models;
public class CarnetDepenses {
 public static CarnetDepenses Partage {get;}=new();
 public ObservableCollection<Depense> Lignes {get;}=new() {
 new(){Description="Restaurant",Categorie="Alimentation",Date=new DateTime(2026,9,20),Montant=25.50m},
 new(){Description="Essence",Categorie="Transport",Date=new DateTime(2026,9,21),Montant=60m},
 new(){Description="Épicerie",Categorie="Alimentation",Date=new DateTime(2026,9,22),Montant=85.30m}
 };
 public Depense? Ouverte { get; set; }
    public void Ajouter(Depense d)=>Lignes.Insert(0,d);
}
