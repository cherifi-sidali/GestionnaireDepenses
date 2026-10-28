namespace MauiApp1;

public partial class ListeDepensesPage : ContentPage
{
    // Liste des dépenses
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

    // Afficher et actualiser la liste
    private void AfficherDepenses()
    {
        ListeDepenses.ItemsSource = null;
        ListeDepenses.ItemsSource = new List<string>(Depenses);
    }

    // Double-clic sur une dépense pour afficher son détail
    private async void Depense_DoubleTapped(object sender, TappedEventArgs e)
    {
        if (sender is Label label &&
            label.BindingContext is string depense)
        {
            await Navigation.PushAsync(
                new DetailDepensePage(depense));
        }
    }

    // Bouton Voir le détail
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

    // Bouton Ajouter une dépense
    private async void Ajouter_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(
            new AjouterDepensePage());
    }

    // Bouton Retour
    private async void Retour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}