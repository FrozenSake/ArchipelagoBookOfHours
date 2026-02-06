using UnityEngine;
using HarmonyLib;
using System;
using SecretHistories.Commands;
using SecretHistories.UI; // Types used: Token, Context, AbstractDominion
using SecretHistories.Entities; // Types used: Situation, FucineRoot

namespace ArchipelagoBookOfHours.Redactions;

[HarmonyPatch(typeof(CharacterCreationCommand))]
public class CharacterCreationCommandSpecter
{
    //ExecuteToProtagonist(Stable)
    //IncarnateFromLegacy(Legacy,Dictionary<String,String>)
}

[HarmonyPatch(typeof(ElementStackCreationCommand))]
public class ElementStackCreationCommandSpecter
{
    //Excute(Context)
        //Context is a top level class inside SecretHistories

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("ElementStackCreationCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(ElementStackXTriggerCommand))]
public class ElementStackXTriggerCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
    //RunXTriggersOnStack(ElementStack)
        //ElementStack is a class from SecretHistories.UI

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(Token) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("ElementStackXTriggerCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(EnviroFxCommand))]
public class EnviroFxCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
    //MatchConcern(String)
    //MatchEffect(String)
    //ParameterAsInt()

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(Token) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("EnviroFxCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(MinimalPayloadCreationCommand))]
public class MinimalPayloadCreationCommandSpecter
{
    //Execute(Context)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("MinimalPayloadCreationCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(NullElementStackCreationCommand))]
public class NullElementStackCreationCommandSpecter
{
    //Execute(Context)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("NullElementStackCreationCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(PopulateNxCommand))]
public class PopulateNxCommandSpecter
{
    //Execute(Context)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("PopulateNxCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(PopulateTerrainFeatureCommand))]
public class PopulateTerrainFeatureCommandSpecter
{
    //Execute(Context)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("PopulateTerrainFeatureCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(PopulateXamanekCommand))]
public class PopulateXamanekCommandSpecter
{
    //Execute(Context)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("PopulateXamanekCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(RecipeCompletionEffectCommand))]
public class RecipeCompletionEffectCommandSpecter
{
    //AudioEvents(Recipe)
    //Execute(Situation)
    //Execute(Sphere, Sphere)
    //Execute(Sphere, List<Sphere>, List<Sphere>, ITokenPayload)
    //IsObsoleteInState(StateEnum)
    //IsValidForState(StateEnum)
    //RequestFX(ITokenPayload)
    //RespectNotables(Recipe)
    //RunDeckEffect(Sphere, AspectsDictionary)
    //RunElementPurges()
    //RunMutationEffects(Sphere, AspectsDictionary)
    //RunRecipeEffects(Sphere)
    //RunVerbManipulations()
    //RunXPans(Dictionary<string, int>)
    //RunXTriggersInSphere(Sphere, Sphere, AspectsDictionary)
    //RunXTriggersInSphere(List<Sphere>, Sphere, AspectsDisctionary)
    //RunXTriggersOnPayload(ITokenPayload, Sphere, AspectsDictionary)

    [HarmonyPatch("Execute")]
    [HarmonyPatch(new Type[] { typeof(Situation) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("RecipeCompletionEffectCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(RootPopulationCommand))]
public class RootPopulationCommandSpecter
{
    //DefaultSphereCreationCommand()
    //Execute(Context)
    //RootcommandForLegacy(Legacy)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("RootPopulationCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(SetupChamberlainCommand))]
public class SetupChamberlainCommandSpecter
{
    //Execute()

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("SetupChamberlainCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(SituationCreationCommand))]
public class SituationCreationCommandSpecter
{
    //AlreadyInState(StateEnum)
    //AttachWindow(Situation)
    //CreateSituation(Verb, string)
    //Execute(Context)
    //SetupState(Situation, string)
    //WithRecipeAboutToActivate(string)
    //WithRecipeId(string)
    //WithVerbId(string)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("SituationCreationCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(SituationXTriggerCommand))]
public class SituationXTriggerCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
    //RunXTriggersOnSituation(ITokenPayload)

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(Token) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("SituationXTriggerCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(SpawnNewTokenFromThisOneCommand))]
public class SpawnNewTokenFromThisOneCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(Token) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("SpawnNewTokenFromThisOneCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(SphereCreationCommand))]
public class SphereCreationCommandSpecter
{
    //ExecuteOn(FucineRoot, Context)
    //ExecuteOn(AbstractDominion, Context)

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(FucineRoot), typeof(Context) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("SphereCreationCommandSpecter:Prefix", "Called");
    }

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(AbstractDominion), typeof(Context) })]
    public static void Postfix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("SphereCreationCommandSpecter:Postfix", "Called");
    }
}

[HarmonyPatch(typeof(TokenCreationCommand))]
public class TokenCreationCommandSpecter
{
    //Execute(Context, Sphere)
    //InstantiateTokenInSphere(ITokenPayload, Context, Sphere)
    //PopulatePermanentToken(Sphere, ITokenPayload)
    //SetTokenTravellingFromSourceToken(Token, Token, TokenLocation, float)
    //SetTokenTravellingToDestination(Token, TokenLocation)
    //WithAssertivePlacement()
    //WithDestination(TokenLocation, float)
    //WithElementStack(string, int)
    //WithLocation(TokenLocation)
    //WithSourceToken(Token)
    //WithUnstartedVerb(string)

    [HarmonyPatch("Execute")]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("TokenCreationCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(XextCommand))]
public class XextCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)

    [HarmonyPatch("ExecuteOn")]
    [HarmonyPatch(new Type[] { typeof(Token) })]
    public static void Prefix()
    {
        ArchipelagoCatalogue.Scribe.LogInfo("XextCommandSpecter:Prefix", "Called");
    }
}

[HarmonyPatch(typeof(ZxCommand))]
public class ZxCommandSpecter
{
    //No Methods
}