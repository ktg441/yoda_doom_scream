using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;

namespace yoda_doom_scream.yoda_doom_screamCode;

[ModInitializer(nameof(Initialize))]
public partial class ModEntry : Node
{
    public const string MOD_ID = "yoda_doom_scream"; //At the moment, this is used only for the Logger and harmony names.

    public const string REPLACEMENT_AUDIO_FILE = "res://yoda_doom_scream/audio/yoda_death.ogg";

    public static MegaCrit.Sts2.Core.Logging.Logger Logger { get; } = new(MOD_ID, MegaCrit.Sts2.Core.Logging.LogType.Generic);

    public static void Initialize()
    {
        Harmony harmony = new(MOD_ID);

        harmony.PatchAll();
    }
}
