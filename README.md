# PickAMovie

This is a Visual Studio 2008 VB.NET Windows Forms helper that loads a plain-text movie list and picks one at random. btnLoad reads `Movies.txt` (or whatever path is in txtFilename), skips blank lines and lines starting with `-`, then fills lstMovies; btnRandom selects an item with `Random.NextDouble`. This is Dave Robinson's working copy from Historical Dev.

**Source last updated:** 2009-04-20  
**Language:** VB.NET  
**Target:** .NET 3.5  
**Output:** WinForms exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `PickAMovie` | VB.NET | WinForms exe (.NET 3.5) | Load a movie list from a text file and pick one at random |

## How to open

Open `PickAMovie.sln` in Visual Studio 2008. Build, then run with `Movies.txt` next to the exe (a sample list is in the project folder).

## Attribution and provenance

From Dave Robinson's Historical Dev archive (OneDrive folder `PickAMovie`). Assembly metadata still has the Visual Studio template defaults (Microsoft 2009). No third-party libraries in the tree.

## License

MIT License. Copyright (c) 2026 VaderConsulting.
