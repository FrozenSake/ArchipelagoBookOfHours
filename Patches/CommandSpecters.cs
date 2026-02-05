using UnityEngine;
using SecretHistories.Commands;

namespace ArchipelagoBookOfHours.Patches;

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
}

[HarmonyPatch(typeof(ElementStackXTriggerCommand))]
public class ElementStackXTriggerCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
    //RunXTriggersOnStack(ElementStack)
        //ElementStack is a class from SecretHistories.UI
}

[HarmonyPatch(typeof(EnviroFxCommand))]
public class EnviroFxCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
    //MatchConcern(String)
    //MatchEffect(String)
    //ParameterAsInt()
}

[HarmonyPatch(typeof(MinimalPayloadCreationCommand))]
public class MinimalPayloadCreationCommandSpecter
{
    //Execute(Context)
}

[HarmonyPatch(typeof(NullElementStackCreationCommand))]
public class NullElementStackCreationCommandSpecter
{
    //Execute(Context)
}

[HarmonyPatch(typeof(PopulateNxCommand))]
public class PopulateNxCommandSpecter
{
    //Execute(Context)
}

[HarmonyPatch(typeof(PopulateTerrainFeatureCommand))]
public class PopulateTerrainFeatureCommandSpecter
{
    //Execute(Context)
}

[HarmonyPatch(typeof(PopulateXamanekCommand))]
public class PopulateXamanekCommandSpecter
{
    //Execute(Context)
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
}

[HarmonyPatch(typeof(RootPopulationCommand))]
public class RootPopulationCommandSpecter
{
    //DefaultSphereCreationCommand()
    //Execute(Context)
    //RootcommandForLegacy(Legacy)
}

[HarmonyPatch(typeof(SetupChamberlainCommand))]
public class SetupChamberlainCommandSpecter
{
    //Execute()
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
}

[HarmonyPatch(typeof(SituationXTriggerCommand))]
public class SituationXTriggerCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
    //RunXTriggersOnSituation(ITokenPayload)
}

[HarmonyPatch(typeof(SpawnNewTokenFromThisOneCommand))]
public class SpawnNewTokenFromThisOneCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
}

[HarmonyPatch(typeof(SphereCreationCommand))]
public class SphereCreationCommandSpecter
{
    //ExecuteOn(FucineRoot, Context)
    //ExecuteOn(AbstractDominion, Context)
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
}

[HarmonyPatch(typeof(XextCommand))]
public class XextCommandSpecter
{
    //ExecuteOn(Token)
    //ExecuteOn(ITokenPayload)
}

[HarmonyPatch(typeof(ZxCommand))]
public class ZxCommandSpecter
{
    //No Methods
}