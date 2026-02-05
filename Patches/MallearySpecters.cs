using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Meta;

namespace ArchipelagoBookOfHours.Patches;

[HarmonyPatch(typeof(MiscMalleary))]
public class MiscMallearySpecters
{
    [HarmonyPrefix]
    [HarmonyPatch("Start")]
    public static void Prefix(MiscMalleary __instance)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(MiscMalleary))]
public class MiscMallearySpecters1
{
    [HarmonyPrefix]
    [HarmonyPatch("BroadcastFX")]
    public static void Prefix(MiscMalleary __instance, ref string ___input)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters1:Prefix", "Called");
	    if (!string.IsNullOrEmpty(___input)) {
            ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters1:Prefix", $"The input to this MiscMalleary was: {___input}");
        }
    }
}

[HarmonyPatch(typeof(MiscMalleary))]
public class MiscMallearySpecters2
{
    [HarmonyPrefix]
    [HarmonyPatch("OpenAllRooms")]
    public static void Prefix(MiscMalleary __instance, string containingPath, ref string ___input)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters2:Prefix", "Called");
	    if (!string.IsNullOrEmpty(___input)) {
            ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters2:Prefix", $"The input to this MiscMalleary was: {___input}");
        }
    }
}

[HarmonyPatch(typeof(MiscMalleary))]
public class MiscMallearySpecters3
{
    [HarmonyPrefix]
    [HarmonyPatch("SetHouse")]
    public static void Prefix(MiscMalleary __instance, ref string ___input)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters3:Prefix", "Called");
	    if (!string.IsNullOrEmpty(___input)) {
            ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters3:Prefix", $"The input to this MiscMalleary was: {___input}");
        }
    }

}

[HarmonyPatch(typeof(MiscMalleary))]
public class MiscMallearySpecters4
{
    [HarmonyPrefix]
    [HarmonyPatch("LoadGame")]
    public static void Prefix(MiscMalleary __instance)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("MiscMallearySpecters4:Prefix", "Called");
    }
}

