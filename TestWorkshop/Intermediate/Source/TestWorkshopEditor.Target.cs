using UnrealBuildTool;

public class TestWorkshopEditorTarget : TargetRules
{
	public TestWorkshopEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TestWorkshop");
	}
}
