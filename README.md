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

## Redactions (`Patches`)

Redactions are alterations to the existing history, to bring it in line with this Sixth History. They represent Harmony Patches, and can take many forms.

### Specters (`Loggers`)

### Inkstains (`Replacements`)

### Daemons (`Queues`)

## Dovecote (`Archipelago`)

Communicates with the Archipelago Server

### Columbarium (`ArchipelagoClient`)

The primary building in this Dovecote, where the birds are stored and messages received.

## Illuminations (`Components`)

Illumninations include the borders, illustrations, and other visual accretia of the great works. They represent User Interface components.

## Stationery (`Utils`)

Stationery represent the bits and bobs necessary to assemble great works.

### Scribe (Logger)