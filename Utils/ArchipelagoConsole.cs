using System.Collections.Generic;
using System.Linq;
using BepInEx;
using ArchipelagoBookOfHours.Archipelago;
using UnityEngine;

namespace ArchipelagoBookOfHours.Utils;

// Shamelessly retyped (so I'd learn from it) from https://github.com/alwaysintreble/ArchipelagoBepInExPluginTemplate/blob/master/templates/ArchipelagoBepin5Template/Utils/ArchipelagoConsole.cs
// who shamelessly acquired it from oc2-modding https://github.com/toasterparty/oc2-modding/blob/main/OC2Modding/GameLog.cs
public static class ArchipelagoConsole
{
    public static bool Hidden = true;

    private static List<string> logLines = new();
    private static Vector2 scrollView;
    private static Rect window;
    private static Rect scroll;
    private static Rect text;
    private static Rect hideShowButton;

    private static GUIStyle textStyle = new();
    private static string scrollText = "";
    private static float lastUpdateTime = Time.time;
    private const int MaxLogLines = 80;
    private const float HideTimeout = 15f;

    private static string CommandText = "!help";
    private static Rect CommandTextRect;
    private static Rect SendCommandButton;

    public static void Awake()
    {
        UpdateWindow();
    }

    public static void LogMessage(string Message)
    {
        // Early exit if there's no content
        if (Message.IsNullOrWhiteSpace()) return;

        // Make space in the scrollback for the new message
        if (logLines.Count == MaxLogLines)
        {
            logLines.RemoveAt(0);
        }

        Plugin.BepinLogger.LogMessage(Message);
        lastUpdateTime = Time.time;
        UpdateWindow();
    }

    public static void OnGUI()
    {
        // Early exit if there's no content
        if (logLines.Count == 0) return;

        // Always if not hidden, otherwise show for $HideTimeout after a new line
        if (!Hidden || Time.time - lastUpdateTime < HideTimeout)
        {
            scrollView = GUI.BeginScrollView(window, scrollView, scroll);
            GUI.Box(text, "");
            GUI.Box(text, scrollText, textStyle);
            GUI.EndScrollView();
        }

        if (GUI.Button(hideShowButton, Hidden ? "Show" : "Hide"))
        {
            // Swap boolean state
            Hidden = !Hidden;
            UpdateWindow();
        }

        CommandText = GUI.TextField(CommandTextRect, CommandText);
        if (!CommandText.IsNullOrWhiteSpace() && GUI.Button(SendCommandButton, "Send"))
        {
            Plugin.ArchipelagoClient.SendMessage(CommandText);
            // Clear after sending
            CommandText = "";
        }
    }

    public static void UpdateWindow()
    {
        scrollText = "";

        // Mild refactor from here https://github.com/alwaysintreble/ArchipelagoBepInExPluginTemplate/blob/master/templates/ArchipelagoBepin5Template/Utils/ArchipelagoConsole.cs#L79
        // combine both if (Hidden) blocks into one singular block
        var width = (int)(Screen.width * 0.4f);
        int height = (int)(Screen.height * 0.03f);
        int scrollDepth;

        // When hidden show a single line of text?
        if (Hidden)
        {
            if (logLines.Count > 0)
            {
                scrollText = logLines[logLines.Count - 1];
            }

            // Set hidden scrollDepth
            scrollDepth = height;
        }
        // When visible
        else
        {
            for (var i = 0; i < logLines.Count; i++)
            {
                scrollText += "> ";
                scrollText += logLines.ElementAt(i);
                if (i < logLines.Count - 1)
                {
                    // Why two new lines, hmm
                    scrollText += "\n\n";
                }
            }

            // Set visible scrollDepth
            scrollDepth = height * 10;
        }

        // Chat Window stuff
        // I won't lie, the sizing math is hard for me to wrap my head around
        // But it feels a little overly complex, althoug since I don't understand it I should probably
        // shut my teeth.
        window = new Rect(Screen.width / 2 - width / 2, 0, width, height);
        scroll = new Rect(0, 0, width * 0.9f, scrollDepth);
        text   = new Rect(0, 0, width, scrollDepth);
        scrollView = new Vector2(0, scrollDepth);
        
        textStyle.alignment = TextAnchor.LowerLeft;
        textStyle.fontSize = Hidden ? (int)(Screen.height * 0.0165f) : (int)(Screen.height * 0.0185f);
        textStyle.normal.textColor = Color.white;
        textStyle.wordWrap = !Hidden;

        var xPadding = (int)(Screen.width * 0.01f);
        var yPadding = (int)(Screen.height * 0.01f);

        textStyle.padding = Hidden
            ? new RectOffset(xPadding / 2, xPadding / 2, yPadding / 2, yPadding /2)
            : new RectOffset(xPadding, xPadding, yPadding, yPadding);

        var buttonWidth = (int)(Screen.width * 0.12f);
        var buttonHeight = (int)(Screen.height * 0.03f);

        hideShowButton = new Rect(
            Screen.width / 2 + width / 2 + buttonWidth / 3,
            Screen.height * 0.004f,
            buttonWidth,
            buttonHeight);

        // draw server commant text field and button
        width = (int)(Screen.width * 0.4f);
        height = (int)(Screen.height * 0.022f);
        var xPos = (int)(Screen.width / 2.0f - width / 2.0f);
        var yPos = (int)(Screen.height * 0.307f);

        CommandTextRect = new Rect(xPos, yPos, width, height);

        width = (int)(Screen.width * 0.05f);
        yPos += (int)(Screen.height * 0.03f);
        SendCommandButton = new Rect(xPos, yPos, width, height);
    }
}