using HarmonyLib;
using ArchipelagoBookOfHours.Dovecote;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Manifestations;
using SecretHistories.Abstract;

namespace ArchipelagoBookOfHours.Redactions;

[HarmonyPatch(typeof(RoomManifestation))]
public class UnshroudRoomRedaction
{
    [HarmonyPrefix]
    [HarmonyPatch("Initialise")]
    public static void Prefix(IManifestable manifestable)
    {
        //ArchipelagoCatalogue.Scribe.LogInfo("UnshroudRoomRedaction:Prefix", $"The Manifestable is: {manifestable.Id}");
    }
}
