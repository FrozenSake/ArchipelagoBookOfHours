using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Utils;
using UnityEngine;
using SecretHistories.Manifestations;
using SecretHistories.Abstract;

namespace ArchipelagoBookOfHours.Patches;

[HarmonyPatch(typeof(RoomManifestation))]
public class UnshroudRoomPatch
{
    [HarmonyPrefix]
    [HarmonyPatch("Initialise")]
    public static void Prefix(IManifestable manifestable)
    {
        //Plugin.BepinLogger.LogMessage("Hello from UnshroudRoomPatch.Prefix(), acting on RoomManifestation.Initialise()");
        Plugin.BepinLogger.LogMessage($"The Manifestable is: {manifestable.Id}");
        manifestable.Unshroud(true);
    }
}
