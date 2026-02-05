using System;
using System.Collections.Generic;
using Archipelago.MultiClient.Net.BounceFeatures.DeathLink;
using BepInEx;

namespace ArchipelagoBookOfHours.Archipelago;


/// DeathLink is defined https://archipelagomw.github.io/Archipelago.MultiClient.Net/api/Archipelago.MultiClient.Net.BounceFeatures.DeathLink.DeathLink.html
/// in BoH a "DeathLink" can be triggered by failing to solve a book
/// When a deathLink is triggered, do some of the following:
/// - Clear all memories
/// - Fail all active books
/// - Destroy some items
public class DeathLinkHandler
{
    private string slotName;
    private static bool deathLinkEnabled;
    private readonly DeathLinkService service;
    private readonly Queue<DeathLink> deathLinks = new();

    /// <summary>
    /// instantiates a death link handler, sets up the hook for receiving death links, and enables death link if necessary
    /// </summary>
    /// <param name="deathLinkService">The new DeathLinkService that our handler will use to send and receive catastrophes</param>
    /// <param name="name">Slotname</param>
    /// <param name="enableDeathLink">Wether we should enable Deathlinks or not on startup</param>
    public DeathLinkHandler(DeathLinkService deathLinkService, string name, bool enableDeathLink = false)
    {
        service = deathLinkService;
        service.OnDeathLinkReceived += DeathLinkReceived;
        slotName = name;
        deathLinkEnabled = enableDeathLink;

        if (deathLinkEnabled)
        {
            service.EnableDeathLink();
        }
    }

    /// <summary>
    /// enables or disables death link
    /// </summary>
    public void ToggleDeathLink()
    {
        deathLinkEnabled = !deathLinkEnabled;

        if (deathLinkEnabled)
        {
            service.EnableDeathLink();
        }
        else
        {
            service.DisableDeathLink();
        }
    }

    /// <summary>
    /// receives a death link and defines logic
    /// </summary>
    /// <param name="deathLink">Received Death Link object to handle</param>
    private void DeathLinkReceived(DeathLink deathLink)
    {
        deathLinks.Enqueue(deathLink);

        var cause = String.IsNullOrWhiteSpace(deathLink.Cause) ? $"Received Death Link from: {deathLink.Source}" : deathLink.Cause;
        ArchipelagoCatalogue.Scribe.LogInfo("DeathLinkHandler:DeathLinkReceived", cause);
    }

    /// <summary>
    /// can be called when in a valid state and blows up a bunch of stuff, checks the queue,
    /// dequeues, and triggers the deathlink state
    /// </summary>
    public void Catastrophe()
    {
        try
        {
            // No deaths queued? Dip out early
            if (deathLinks.Count < 1) return;

            var deathLink = deathLinks.Dequeue();
            var cause = String.IsNullOrWhiteSpace(deathLink.Cause) ? GetDeathLinkCause(deathLink) : deathLink.Cause;

            // Implement the Catastrophe

            ArchipelagoCatalogue.Scribe.LogInfo("DeathLinkHandler:Catastrophe", cause);
        }
        catch (Exception e)
        {
            ArchipelagoCatalogue.Scribe.LogError("DeathLinkHandler:Catastrophe", e);
        }
    }

    /// <summary>
    /// returns message for the player to see when a death link is received without a cause
    /// </summary>
    /// <param name="deathLink">death link object to get relevant info from</param>
    /// <returns>
    /// A string explaining where the death (catastrophe) came from
    /// </returns>
    private string GetDeathLinkCause(DeathLink deathLink)
    {
        return $"Received catastrophe from {deathLink.Source}";
    }

    /// <summary>
    /// Called to send a death lik to the multiworld
    /// </summary>
    /// <param name="cause">What you did to cause this terrible travesty</param>
    public void SendDeathLink(string cause)
    {
        try
        {
            // Does nothing if death links are off
            if (!deathLinkEnabled) return;

            ArchipelagoCatalogue.Scribe.LogInfo("DeathLinkHandler:SendDeathLink", "Your catastrophic failure has impacted your allies...");

            var linkToSend = new DeathLink(slotName, cause);

            service.SendDeathLink(linkToSend);
        }
        catch (Exception e)
        {
            ArchipelagoCatalogue.Scribe.LogError("DeathLinkHandler:SendDeathLink", e);
        }
    }
}