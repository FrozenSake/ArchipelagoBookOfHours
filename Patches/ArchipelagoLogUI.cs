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
public class ArchipelagoLogUIPatch
{
    //[HarmonyPrefix]
    //[HarmonyPatch("Awake")]
    public static void Prefix(Sphere __instance)
    {
        Plugin.BepinLogger.LogMessage("Hello from ArchipelagoLogUIPatch.Prefix()");
    }
}
