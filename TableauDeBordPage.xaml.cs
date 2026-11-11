namespace MauiApp1;

public partial class TableauDeBordPage : ContentPage
{
    public TableauDeBordPage()
    {
        InitializeComponent();
    }

    private async void VoirDepenses_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListeDepensesPage());
    }
}