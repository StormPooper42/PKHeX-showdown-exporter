# Pokémon Showdown Exporter

A small client-side web tool that exports Pokémon from a save file to Pokémon Showdown format.

## Privacy

This tool runs entirely in your browser.

Your save file is:
- not uploaded;
- not stored;
- not sent to any backend;
- only read locally by your browser.

The generated Showdown text is kept in memory until you copy or download it.

## Usage

1. Open the website.
2. Select your Pokémon save file.
3. Download the generated Showdown export.

## Limitations

- ROM hacks may not be fully supported if they change save structure, custom species, custom moves, abilities or items.
- The tool is read-only and does not edit save files.

## Development

```bash
git clone --recurse-submodules https://github.com/YOUR_USERNAME/YOUR_REPO.git
cd YOUR_REPO
dotnet restore
dotnet run --project src/PKHeX.ShowdownExporter.Web/PKHeX.ShowdownExporter.Web.csproj
```