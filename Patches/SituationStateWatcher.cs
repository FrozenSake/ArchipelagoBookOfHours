using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Entities;
using SecretHistories.States;

namespace ArchipelagoBookOfHours.Patches;

[HarmonyPatch(typeof(Situation))]
public class TransitionToStateWatcher
{
    [HarmonyPrefix]
    [HarmonyPatch("TransitionToState")]
    public static void Prefix(Situation __instance, SituationState newState)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("TransitionToStateWatcher:Prefix", $"Instance: {__instance.Id}");
        ArchipelagoCatalogue.Scribe.LogInfo("TransitionToStateWatcher:Prefix", $"The new state is: {newState.Identifier}");
    }
}
