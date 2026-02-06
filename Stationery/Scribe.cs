using Archipelago.MultiClient.Net.MessageLog.Messages;
using MelonLoader;
using System;

namespace ArchipelagoBookOfHours.Stationery;

/// <summary>
/// The scribe records the secrets whispered by the machines and ghosts. It acts as a primary console logger.
/// </summary>
public class Scribe
{
    private readonly MelonLogger.Instance _logger;

    public Scribe() {
        _logger = new MelonLogger.Instance("Archipelago");
    }

    public void LogDebug(string source, string message) {
#if DEBUG
        _logger.Msg($"[{source}] {message}");
#endif
    }

    public void LogInfo(string source, string message) {
        _logger.Msg($"[{source}] {message}");
    }

    public void LogWarning(string source, string message) {
        _logger.Warning($"[{source}] {message}");
    }

    public void LogError(string source, Exception e) {
        _logger.Error($"Exception occured in: {source}.", e);
    }

    public void LogMessage(LogMessage message) {
        _logger.Msg(message.ToString());
    }
}