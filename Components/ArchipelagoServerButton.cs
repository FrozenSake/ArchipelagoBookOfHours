using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ArchipelagoBookOfHours.Archipelago;
using ArchipelagoBookOfHours.Utils;
using UnityEngine;
using SecretHistories.Spheres;

namespace ArchipelagoBookOfHours.Components
{
    public class ServerButton : MonoBehaviour
{
	public void OnClick()
	{
		//Watchman.Get<LocalNexus>().ToggleMenuEvent.Invoke();
	}
}
}