namespace MauiApp1;

public partial class AjouterDepensePage : ContentPage
{
    public AjouterDepensePage()
    {
        InitializeComponent();
    }

    private async void Ajouter_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(DescriptionEntry.Text))
        {
            await DisplayAlert("Erreur",
                "Veuillez entrer une description.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(MontantEntry.Text))
        {
            await DisplayAlert("Erreur",
                "Veuillez entrer un montant.", "OK");
            return;
        }

        if (CategoriePicker.SelectedIndex == -1)
        {
            await DisplayAlert("Erreur",
                "Veuillez choisir une catégorie.", "OK");
            return;
        }

        await DisplayAlert(
            "Succès",
            "La dépense a été ajoutée.",
            "OK");

        await Navigation.PopAsync();
    }

    private async void Retour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}