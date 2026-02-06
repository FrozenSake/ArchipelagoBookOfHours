using HarmonyLib;
using ArchipelagoBookOfHours.Dovecote;
using ArchipelagoBookOfHours.Stationery;
using UnityEngine;
using SecretHistories.Manifestations;
using SecretHistories.Abstract;
using SecretHistories.Spheres;

namespace ArchipelagoBookOfHours.Redactions;

[HarmonyPatch(typeof(BookManifestation))]
public class BookManifestationSpecter
{
    [HarmonyPrefix]
    [HarmonyPatch("Initialise")]
    public static void Prefix(IManifestable manifestable)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("BookManifestationSpecter:Prefix", $"The Manifestable for this BookManifestationSpecter is: {manifestable.Id}");
        manifestable.Unshroud();
    }

    [HarmonyPrefix]
    [HarmonyPatch("UpdateStateAimedAtSphere")]
    public static void Prefix(IManifestable manifestable, Sphere aimedAtSphere)
    {
        ArchipelagoCatalogue.Scribe.LogInfo("BookManifestationSpecter:Prefix", $"This Specter is on: {manifestable.Id}. The sphere's type is: {typeof(Sphere)}");
        
    }
}

