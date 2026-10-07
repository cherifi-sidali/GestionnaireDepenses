namespace MauiApp1;

public partial class ListeDepensesPage : ContentPage
{
    public ListeDepensesPage()
    {
        InitializeComponent();

        ListeDepenses.ItemsSource = new List<string>
        {
            "Restaurant - Alimentation - 20/09/2026 - 25,50 $",
            "Essence - Transport - 21/09/2026 - 60,00 $",
            "Épicerie - Alimentation - 22/09/2026 - 85,30 $"
        };
    }

    private async void Retour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Detail_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DetailDepensePage());
    }

    private async void Ajouter_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AjouterDepensePage());
    }
}