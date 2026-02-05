# BepinEx Setup

Support Docs -> https://docs.google.com/document/d/1BZiUrSiT8kKvWIEvx5DObThL4HMGVI1CluJR20CWBU0/preview?tab=t.0
Harmony -> https://harmony.pardeike.net/articles/basics.html

1. IDE
2. Install BepinEx into Book of hours
    a. Make a new copy of BoH if you want
3. Run BoH and check for the BepinEx folder having a `LogOutput.log`
4. Copy the `Archipelago.MultiClient.Net.dll` into the BepInEx plugins
5. `dotnet build` the client
6. Copy the `ArchipelagoBookOfHours.dll` dll to the BepInEx plugins folder in book of hours


# Code Terminology

In keeping with the spirit of Book of Hours, and the Code we're interacting with here, I've decided to use some special (but made up) terminology in my mod:

## Redactions (Currently `Patches`)

Various harmony patches

### Specters

### Inkstains

### Daemons

## Dovecote (Currently `Archipelago`)

Communicates with the Archipelago Server

## Illuminations (Currently `Components`)

UI Elements

## Stationery (Currently `Utils`)

Miscellaneous helpers and utilities

### Scribe (Logger)