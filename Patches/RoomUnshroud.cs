using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Stationery;
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
        ArchipelagoCatalogue.Scribe.LogInfo("UnshroudRoomPatch:Prefix", $"The Manifestable is: {manifestable.Id}");
    }
}
