using UnrealBuildTool;

public class TestWorkshopServerTarget : TargetRules
{
	public TestWorkshopServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TestWorkshop");
	}
}
