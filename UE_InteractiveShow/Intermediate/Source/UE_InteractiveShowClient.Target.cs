using UnrealBuildTool;

public class UE_InteractiveShowClientTarget : TargetRules
{
	public UE_InteractiveShowClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("UE_InteractiveShow");
	}
}
