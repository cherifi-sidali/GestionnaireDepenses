namespace MauiApp1.Models;
public class Depense {
 public string Description {get;set;}="";
 public string Categorie {get;set;}="";
 public decimal Montant {get;set;}
 public DateTime Date {get;set;}=DateTime.Today;
 public string Resume => $"{Description} - {Categorie} - {Date:dd/MM/yyyy} - {Montant:N2} $";
 public string DateAffiche => Date.ToString("dd/MM/yyyy");
 public string MontantAffiche => $"{Montant:N2} $";
}
