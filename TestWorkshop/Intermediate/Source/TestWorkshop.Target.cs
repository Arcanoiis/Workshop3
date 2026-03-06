using UnrealBuildTool;

public class TestWorkshopTarget : TargetRules
{
	public TestWorkshopTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TestWorkshop");
	}
}
