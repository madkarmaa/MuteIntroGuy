using HarmonyLib;

namespace MuteIntroGuy.Patches
{
    [HarmonyPatch(typeof(StartOfRound))]
    internal class StartOfRoundBPatch
    {

        [HarmonyPatch(nameof(StartOfRound.firstDayAnimation))]
        [HarmonyPrefix]
        static void MuteSpeakerOnRoundStartClientSide()
        {
            StartOfRound.Instance.shipIntroSpeechSFX = null;
            MuteIntroGuy.Logger.LogMessage("Successfully set StartOfRound.shipIntroSpeechSFX to null. Once you enter a new lobby you should see the following message in the console: [Warning: Unity Log] PlayOneShot was called with a null AudioClip.");
        }

    }
}
