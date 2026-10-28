using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace MauiApp1.ViewModels;
public class BaseViewModel:INotifyPropertyChanged {
 public event PropertyChangedEventHandler? PropertyChanged;
 protected void Notifier([CallerMemberName]string? nom=null)=>PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nom));
}
