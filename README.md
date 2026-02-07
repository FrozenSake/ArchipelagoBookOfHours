# Modding Setup

Support Docs -> https://docs.google.com/document/d/1BZiUrSiT8kKvWIEvx5DObThL4HMGVI1CluJR20CWBU0/preview?tab=t.0
Harmony -> https://harmony.pardeike.net/articles/basics.html

1. IDE
2. Install [MelonLoader](https://melonloader.app/) into Book of hours
    a. Make a new copy of BoH if you want, the auto-loader won't work for that though
3. Run BoH and check for the MelonLoader folder having a `LogOutput.log`
4. Copy the `Archipelago.MultiClient.Net.dll` into the mod folder
5. `dotnet build` the client
6. Copy the `ArchipelagoBookOfHours.dll` dll to the Mod folder in book of hours

# Local Setup

1. Your dev flow is your business if you want to mess with this code.
2. Create an APQuest multiworld for yourself
    1. Generate a yaml (use Player1 as your name for easy set-up)
    2. Generate the multiworld
    3. Run the local server
3. If you wanna connect to a different game, that's all stored in `Dovecote/ArchipelagoData.ArchipelagoData()`
4. Pop open the text client, join your localhost as Player1
5. Play with !getitem

# Glossary

In keeping with the spirit of Book of Hours, and the Code we're interacting with here, I've decided to lean into the Sixth History by using some terminology in my mod:

## Redactions (`Patches`)

Redactions are alterations to the existing history, to bring it in line with this Sixth History. They represent Harmony Patches, and can take many forms.

### Specters (`Loggers`)

### Inkstains (`Replacements`)

## Dovecote (`Archipelago`)

Communicates with the Archipelago Server

### Columbarium (`ArchipelagoClient`)

The primary building in this Dovecote, where the birds are stored and messages received. It's the core client for communicating with and receiving messages from the Archipelago Client.

### Catastrophizer (`DeathLinkHandler`)

### Dovemail (`ItemHandler`)

Dovemail handles packages, both into the game and out of the game.

### Postman (`ItemUnlockHandler`)

The postman delivers packages from the Dovecote to the game

#### Packages (`Items`)

## Illuminations (`Components`)

Illumninations include the borders, illustrations, and other visual accretia of the great works. They represent User Interface components.

## Stationery (`Utils`)

Stationery represent the bits and bobs necessary to assemble great works.

### Scribe (`Logger`)

The scribe records the whispers and groans of the machinations, and the rustling feathers of the Dovecote. It is the primary logger.