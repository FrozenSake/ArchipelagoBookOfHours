using MelonLoader;
using HarmonyLib;
using ArchipelagoBookOfHours;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Stationery;
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
    public const string APInfo = $"Archipelago v{ArchipelagoClient.APVersion}";

    public static ArchipelagoClient ArchipelagoClient;

    public override void OnInitializeMelon()
    {

        ArchipelagoCatalogue.Scribe = new Scribe();
        ArchipelagoClient = new ArchipelagoClient();
        ArchipelagoConsole.Awake();

        ArchipelagoCatalogue.Scribe.LogInfo("Initialize Melon", $"{ModInfo} loaded!");
    }

    public override void OnGUI()
    {
        // Show the Mod is loaded
        GUI.Label(new Rect(16, 16, 300, 20), ModInfo);
        ArchipelagoConsole.OnGUI();

        string statusMessage = "Status: ";

        if (ArchipelagoClient.Authenticated)
        {
            statusMessage += "Connected";
            GUI.Label(new Rect(16, 50, 300, 20), APInfo + " " + statusMessage);
        }
        else
        {
            statusMessage += "Disconnected";
            GUI.Label(new Rect(16, 50, 300, 20), APInfo + " " + statusMessage);

            // Host label and text entry
            GUI.Label(new Rect(16, 70, 150, 20), "Host: ");
            ArchipelagoClient.ServerData.Uri = GUI.TextField(new Rect(150, 70, 150, 20),
                ArchipelagoClient.ServerData.Uri);

            // Player label and text entry
            GUI.Label(new Rect(16, 90, 150, 20), "Player Name: ");
            ArchipelagoClient.ServerData.SlotName = GUI.TextField(new Rect(150, 90, 150, 20),
                ArchipelagoClient.ServerData.SlotName);
 
            // Password label and text entry
            GUI.Label(new Rect(16, 110, 150, 20), "Password: ");
            ArchipelagoClient.ServerData.Password = GUI.TextField(new Rect(150, 110, 150, 20),
                ArchipelagoClient.ServerData.Password);

            if (GUI.Button(new Rect(16, 130, 100, 20), "Connect") &&
                !String.IsNullOrWhiteSpace(ArchipelagoClient.ServerData.SlotName))
            {
                ArchipelagoClient.Connect();
            }
        }
    }
}
