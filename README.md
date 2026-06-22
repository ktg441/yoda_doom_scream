# yoda_doom_scream

A mod that plays the Yoda Death meme sound when an enemy dies to doom.

## Prerequisites

- Install MegaDot 4.5.1 Mono for Windows. Download it from https://megadot.megacrit.com/.
- The game exporter requires the same Godot engine version used by MegaDot, so use MegaDot v4.5.1-stable_mono_win64.

## Required Path Configuration

- Open `Directory.Build.props`.
- Ensure the `GodotPath` value points to your MegaDot executable.
- The path must match your local installation exactly.

Example:

```xml
<Project>
    <PropertyGroup>
        <GodotPath>C:/megadot/MegaDot_v4.5.1-stable_mono_win64.exe</GodotPath>
    </PropertyGroup>
</Project>
```

## Build

- Run `dotnet publish` from the mod project.
- Publish output must go to `.godot\mono\temp\bin\`.
- If `Slay the Spire 2` is installed on the same machine, the mod should automatically install locally.

## Notes

- If your MegaDot install is located somewhere else, update `GodotPath` accordingly.