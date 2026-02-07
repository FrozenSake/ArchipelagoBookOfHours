using Archipelago.MultiClient.Net;
using Archipelago.MultiClient.Net.Helpers;
using UnityEngine;

namespace ArchipelagoBookOfHours.Dovecote;

public class Postman {

    private readonly Dovemail _doves;

    public Postman() {}

    // Deliver Package is a problem because I used three different sources which handle things differently
    // WIP here for sure

    /// <summary>
    /// Gives the player the specified package (item, room, etc.).
    /// </summary>
    public static void DeliverPackage(IReceivedItemsHelper helper) {
        ArchipelagoCatalogue.Scribe.LogInfo("Postman:DeliverPackage(ReceivedItemsHelper)", $"Delivering {helper.Index} items");
         while (helper.Any()) {
            var networkItem = helper.DequeueItem();
        }
        
    }

    /// <summary>
    /// Delivers all waiting packages in the current game.
    /// </summary>
    public void DeliverAllPackages() {

    }

    private string lookupItem(long item) {
        // Takes an item ID as a long, returns the name as a string
        return "not implemented";
    }
}