namespace MauiApp1;

public partial class DetailDepensePage : ContentPage
{
    public DetailDepensePage(string depense)
    {
        InitializeComponent();

        DepenseLabel.Text = depense;
    }

    private async void Retour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}