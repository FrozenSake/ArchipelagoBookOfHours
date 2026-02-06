using HarmonyLib;
using ArchipelagoBookOfHours.Dovecote;
using ArchipelagoBookOfHours.Illuminations;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Spheres;

namespace ArchipelagoBookOfHours.Redactions;

//[HarmonyPatch(typeof(PermanentRootSphereSpec))]
public class ArchipelagoServerUIRedaction
{
    //[HarmonyPrefix]
    //[HarmonyPatch("Awake")]
    public static void Prefix(Sphere __instance)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("ArchipelagoServerUIRedaction:Prefix", "Called");
    }
}

// The goal here is to add a new group to `S4Library -> `CanvasUIScreenSpaceOverlay.ScreenEdgeControls`
// It will be `ArchipelagoControls`
// It will go in the top right
// It will essentially be a RectTransform
// It will contain two buttons
// ArchipelagoBookOfHours.Illuminations.LogButton and .Serverbutton
// They will be buttons that display the Archipelago log and the Archipelago server dialogue


//... How to do that I don't know yet. But that's the goal.