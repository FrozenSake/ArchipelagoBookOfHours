using MelonLoader;
using HarmonyLib;
using ArchipelagoBookOfHours;
using ArchipelagoBookOfHours.Dovecote;
using ArchipelagoBookOfHours.Stationery;
using ArchipelagoBookOfHours.Illuminations;
using UnityEngine;
using System;

[assembly: MelonInfo(typeof(ArchipelagoBookOfHoursMod), "Book of Hours Client", "0.0.1", "FrozenSake")]
[assembly: MelonGame("Weather Factory", "Book of Hours")]

namespace ArchipelagoBookOfHours;

public class ArchipelagoBookOfHoursMod : MelonMod
{
    public const string PluginGUID = "com.frozensake.ArchipelagoBookOfHours";
    public const string PluginName = "Book of Hours Client";
    public const string PluginVersion = "0.0.1";

    public const string ModInfo = $"{PluginName} v{PluginVersion}";
    public const string APInfo = $"Archipelago v{Columbarium.APVersion}";

    public static Columbarium Columbarium;

    public override void OnInitializeMelon()
    {

        ArchipelagoCatalogue.Scribe = new Scribe();
        Columbarium = new Columbarium();
        ArchipelagoConsole.Awake();

        ArchipelagoCatalogue.Scribe.LogInfo("Initialize Melon", $"{ModInfo} loaded!");
    }

    public override void OnUpdate()
    {
        Columbarium.OnUpdate();
    }

    // This can be faceted out into an Illumination, but for now it's here to make things simple
    public override void OnGUI()
    {
        // Show the Mod is loaded
        GUI.Label(new Rect(16, 16, 300, 20), ModInfo);
        ArchipelagoConsole.OnGUI();

        string statusMessage = "Status: ";

        if (Columbarium.Authenticated)
        {
            statusMessage += "Connected";
            GUI.Label(new Rect(16, 50, 300, 20), APInfo + " " + statusMessage);
            if (GUI.Button(new Rect(16, 130, 100, 20), "Disconnect"))
            {
                Columbarium.Disconnect();
            }
        }
        else
        {
            statusMessage += "Disconnected";
            GUI.Label(new Rect(16, 50, 300, 20), APInfo + " " + statusMessage);

            // Host label and text entry
            GUI.Label(new Rect(16, 70, 150, 20), "Host: ");
            Columbarium.ServerData.Uri = GUI.TextField(new Rect(150, 70, 150, 20),
                Columbarium.ServerData.Uri);

            // Player label and text entry
            GUI.Label(new Rect(16, 90, 150, 20), "Player Name: ");
            Columbarium.ServerData.SlotName = GUI.TextField(new Rect(150, 90, 150, 20),
                Columbarium.ServerData.SlotName);
 
            // Password label and text entry
            GUI.Label(new Rect(16, 110, 150, 20), "Password: ");
            Columbarium.ServerData.Password = GUI.TextField(new Rect(150, 110, 150, 20),
                Columbarium.ServerData.Password);

            if (GUI.Button(new Rect(16, 130, 100, 20), "Connect") &&
                !String.IsNullOrWhiteSpace(Columbarium.ServerData.SlotName))
            {
                Columbarium.Connect();
            }
        }
    }
}
