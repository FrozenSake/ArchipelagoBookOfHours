using Archipelago.MultiClient.Net;
using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Models;
using Archipelago.MultiClient.Net.Packets;
using Archipelago.MultiClient.Net.Helpers;
using ArchipelagoBookOfHours;
using UnityEngine;
using System.Collections.Generic;

namespace ArchipelagoBookOfHours.Dovecote;

/// A lot of this implementation is pieced together from two other mods:
/// https://github.com/DeamonHunter/ArchipelagoMuseDash/tree/main/ArchipelagoMuseDash
/// https://github.com/TRPG0/ArchipelagoULTRAKILL/tree/main/mod
/// Everything here is subject to change, this is a first pass for validation purposes.
public class Dovemail {

    private readonly ArchipelagoSession _currentSession;
    private readonly int _currentPlayerSlot;

    public Dovemail (ArchipelagoSession session, int playerSlot) {
        _currentSession = session;
        _currentPlayerSlot = playerSlot;

        Postman = new Postman();
    }

    public Postman Postman { get; }

    /// <summary>
    /// Takes an ArchipelagoData instance and uses it to set up the existing system.
    /// Probably overkill and can be reduced to a smaller payload.
    /// </summary>
    public void Setup(ArchipelagoData manifest) {
        ArchipelagoCatalogue.Scribe.LogInfo("Dovemail:Setup", "Clearing state");

        // Clear any logic state

        // Extract goal from manifest

        // Extract any conditions from manifest

        // Build out the randomizer options, e.g.
        // if manifest.[RandomizeRooms] -> 
        // if manifest.[RandomizeTomes] ->
        // etc. - specific structure and logic is not defined, so leaving this as scaffolding
    }

    /// <summary>
    /// Locations are the checks in game, handle one or more of them
    /// </summary>
    public void NewLocationChecked(IReadOnlyCollection<long> locations) {
        foreach (var location in locations) {
            ArchipelagoCatalogue.Scribe.LogInfo("Dovemail:NewLocationChecked", $"Location: {location}");
            // do check
        }
    }

    public void OnUpdate() {
        CheckForNewItems();
    }

     private void CheckForNewItems() {
        //ArchipelagoCatalogue.Scribe.LogInfo("Dovemail:CheckForNewItems", $"Current Session Items: {_currentSession.Items}");
        while (_currentSession.Items.Any()) {
            ArchipelagoCatalogue.Scribe.LogInfo("Dovemail:CheckForNewItems", "Current session has items");
            /*
            var networkItem = _currentSession.Items.DequeueItem();
            if (networkItem.Player != _currentPlayerSlot) {
                ArchipelagoCatalogue.Scribe.LogInfo("Dovemail:CheckForNewItems", $"Received item for another player. Player: ${networkItem.Player}, Item: ${networkItem.ItemId}, ItemName: ${networkItem.ItemName}");
                return;
            }
            */
            Postman.DeliverPackage(_currentSession.Items);
        }
    }

#region Locations
    public void CheckLocation() {
        // Parse type of location
        // Pass to handler for type
        // Do thing
        var locationsToCheck = new List<long>();

        // Add locations to list

        var locationsArray = locationsToCheck.ToArray();

        // Uses the Archipelago Multiclient Lib's functions
        // https://archipelagomw.github.io/Archipelago.MultiClient.Net/api/Archipelago.MultiClient.Net.Helpers.ILocationCheckHelper.html
        _currentSession.Locations.CompleteLocationChecks(locationsArray);
    }
#endregion
}