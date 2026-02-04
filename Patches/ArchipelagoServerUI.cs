using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Components;
using ArchipelagoBookOfHours.Utils;
using UnityEngine;
using SecretHistories.Spheres;

namespace ArchipelagoBookOfHours.Patches;

//[HarmonyPatch(typeof(PermanentRootSphereSpec))]
public class ArchipelagoServerUIPatch
{
    //[HarmonyPrefix]
    //[HarmonyPatch("Awake")]
    public static void Prefix(Sphere __instance)
    {
        Plugin.BepinLogger.LogMessage("Hello from ArchipelagoServerUIPatch.Prefix()");
    }
}

// The goal here is to add a new group to `S4Library -> `CanvasUIScreenSpaceOverlay.ScreenEdgeControls`
// It will be `ArchipelagoControls`
// It will go in the top right
// It will essentially be a RectTransform
// It will contain two buttons
// ArchipelagoBookOfHours.Components.LogButton and .Serverbutton
// They will be buttons that display the Archipelago log and the Archipelago server dialogue


//... How to do that I don't know yet. But that's the goal.