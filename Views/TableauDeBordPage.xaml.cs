using MauiApp1.ViewModels;
namespace MauiApp1.Views;
public partial class TableauDeBordPage:ContentPage {
 public TableauDeBordPage() {BindingContext=new TableauDeBordViewModel();InitializeComponent();}
}
