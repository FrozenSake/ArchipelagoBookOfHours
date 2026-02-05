using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Components;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Spheres;

namespace ArchipelagoBookOfHours.Patches;

//[HarmonyPatch(typeof(PermanentRootSphereSpec))]
public class ArchipelagoLogUIPatch
{
    //[HarmonyPrefix]
    //[HarmonyPatch("Awake")]
    public static void Prefix(Sphere __instance)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("ArchipelagoLogUIPatch:Prefix", "Called");
    }
}
