using UnrealBuildTool;

public class UE_InteractiveShowEditorTarget : TargetRules
{
	public UE_InteractiveShowEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("UE_InteractiveShow");
	}
}
