using UnrealBuildTool;

public class UE_InteractiveShowTarget : TargetRules
{
	public UE_InteractiveShowTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("UE_InteractiveShow");
	}
}
