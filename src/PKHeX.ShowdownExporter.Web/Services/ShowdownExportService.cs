using PKHeX.Core;
using PKHeX.Facade;
using PKHeX.Facade.Extensions;

namespace PKHeX.ShowdownExporter.Web.Services;

public sealed class ShowdownExportService
{
    public ExportResult Export(byte[] saveBytes, string fileName)
    {
        var game = Game.LoadFrom(saveBytes, fileName);

        var party = game.Trainer.Party.Pokemons;
        var boxes = game.Trainer.PokemonBox.All;

        var pokemons = party
            .Concat(boxes)
            .Where(p => p.Species != Species.None)
            .ToList();

        var showdown = pokemons.Showdown();

        return new ExportResult(
            GameName: game.GameVersionApproximation.Name,
            TrainerName: game.Trainer.Name,
            PokemonCount: pokemons.Count,
            ShowdownText: showdown
        );
    }
}

public sealed record ExportResult(
    string GameName,
    string TrainerName,
    int PokemonCount,
    string ShowdownText
);