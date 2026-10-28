namespace MauiApp1;

public partial class DetailDepensePage : ContentPage
{
    public DetailDepensePage(string depense)
    {
        InitializeComponent();

        string[] parties = depense.Split(" - ");

        if (parties.Length >= 4)
        {
            DescriptionLabel.Text = parties[0];
            CategorieLabel.Text = parties[1];
            DateLabel.Text = parties[2];
            MontantLabel.Text = parties[3];
        }
    }

    private async void Retour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}