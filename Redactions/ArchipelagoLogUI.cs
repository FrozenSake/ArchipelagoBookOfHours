using HarmonyLib;
using ArchipelagoBookOfHours.Dovecote;
using ArchipelagoBookOfHours.Illuminations;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Spheres;

namespace ArchipelagoBookOfHours.Redactions;

//[HarmonyPatch(typeof(PermanentRootSphereSpec))]
public class ArchipelagoLogUIRedaction
{
    //[HarmonyPrefix]
    //[HarmonyPatch("Awake")]
    public static void Prefix(Sphere __instance)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("ArchipelagoLogUIRedaction:Prefix", "Called");
    }
}
