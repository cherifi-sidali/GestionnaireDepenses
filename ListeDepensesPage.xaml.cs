namespace MauiApp1;

public partial class ListeDepensesPage : ContentPage
{
    // Liste partagée pour conserver les dépenses
    public static List<string> Depenses = new List<string>
    {
        "Restaurant - Alimentation - 20/09/2026 - 25,50 $",
        "Essence - Transport - 21/09/2026 - 60,00 $",
        "Épicerie - Alimentation - 22/09/2026 - 85,30 $"
    };

    public ListeDepensesPage()
    {
        InitializeComponent();

        AfficherDepenses();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        AfficherDepenses();
    }

    private void AfficherDepenses()
    {
        // Nouvelle copie pour actualiser le CollectionView
        ListeDepenses.ItemsSource = null;
        ListeDepenses.ItemsSource = new List<string>(Depenses);
    }

    private async void Retour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Detail_Clicked(object sender, EventArgs e)
    {
        if (ListeDepenses.SelectedItem is string depense)
        {
            await Navigation.PushAsync(
                new DetailDepensePage(depense));
        }
        else
        {
            await DisplayAlert(
                "Information",
                "Veuillez sélectionner une dépense.",
                "OK");
        }
    }

    private async void Ajouter_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(
            new AjouterDepensePage());
    }
}