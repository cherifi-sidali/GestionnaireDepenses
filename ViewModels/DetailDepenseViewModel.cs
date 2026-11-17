
using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.Views;

namespace MauiApp1.ViewModels;

public class DetailDepenseViewModel
{
    private readonly DepotDepenses depot = new();

    public string Description { get; }
    public string Categorie { get; }
    public string Date { get; }
    public string Montant { get; }

    public Command RetourCommand { get; } =
        new(async () => await Shell.Current.GoToAsync(".."));

    public Command ModifierCommand { get; }
    public Command SupprimerCommand { get; }

    public DetailDepenseViewModel()
    {
        var d = CarnetDepenses.Partage.Ouverte;

        Description = d?.Description ?? "";
        Categorie = d?.Categorie ?? "";
        Date = d?.DateAffiche ?? "";
        Montant = d?.MontantAffiche ?? "";

        ModifierCommand = new Command(async () => await Modifier());
        SupprimerCommand = new Command(async () => await Supprimer());
    }

    private async Task Modifier()
    {
        var depense = CarnetDepenses.Partage.Ouverte;

        if (depense == null)
            return;

        CarnetDepenses.Partage.EnModification = true;

        await Shell.Current.GoToAsync(nameof(AjouterDepensePage));
    }

    private async Task Supprimer()
    {
        var depense = CarnetDepenses.Partage.Ouverte;

        if (depense == null)
            return;

        bool confirmation = await Shell.Current.DisplayAlertAsync(
            "Confirmation",
            "Voulez-vous vraiment supprimer cette dépense ?",
            "Oui",
            "Non");

        if (!confirmation)
            return;

        await depot.Initialiser();
        await depot.Supprimer(depense);

        CarnetDepenses.Partage.Ouverte = null;
        CarnetDepenses.Partage.EnModification = false;

        await Shell.Current.GoToAsync("..");
    }
}
