using BaseLib.Audio;
using HarmonyLib;
using MegaCrit.Sts2.Core.Hooks;
using yoda_doom_scream.yoda_doom_screamCode;

namespace yoda_doom_scream.src;

[HarmonyPatch(typeof(Hook), nameof(Hook.AfterDiedToDoom))]
public static class AfterDiedToDoomPatch
{
    public static async void Postfix()
    {
        ModAudio.PlaySound(ModEntry.REPLACEMENT_AUDIO_FILE);
    }
}
