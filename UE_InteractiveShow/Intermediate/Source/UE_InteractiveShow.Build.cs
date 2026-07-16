using UnrealBuildTool;

public class UE_InteractiveShow : ModuleRules
{
	public UE_InteractiveShow(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
