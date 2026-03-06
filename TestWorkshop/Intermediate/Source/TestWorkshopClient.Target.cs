using UnrealBuildTool;

public class TestWorkshopClientTarget : TargetRules
{
	public TestWorkshopClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TestWorkshop");
	}
}
