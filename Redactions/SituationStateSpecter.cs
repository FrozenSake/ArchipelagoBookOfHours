using HarmonyLib;
using ArchipelagoBookOfHours.Dovecote;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Entities;
using SecretHistories.States;

namespace ArchipelagoBookOfHours.Redactions;

[HarmonyPatch(typeof(Situation))]
public class TransitionToStateSpecter
{
    [HarmonyPrefix]
    [HarmonyPatch("TransitionToState")]
    public static void Prefix(Situation __instance, SituationState newState)
    {
        // ArchipelagoCatalogue.Scribe.LogInfo("TransitionToStateSpecter:Prefix", $"Instance: {__instance.Id}");
        // ArchipelagoCatalogue.Scribe.LogInfo("TransitionToStateSpecter:Prefix", $"The new state is: {newState.Identifier}");
    }
}
