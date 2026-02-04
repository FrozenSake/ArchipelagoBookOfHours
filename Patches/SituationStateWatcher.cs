using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Utils;
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
        Plugin.BepinLogger.LogMessage($"Hello from TransitionToState.Prefix() on {__instance.Id}");
        Plugin.BepinLogger.LogMessage($"The new state is: {newState.Identifier}");
    }
}
