using UnrealBuildTool;

public class VREditorTarget : TargetRules
{
    public VREditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V6;  // 改为 V6
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange(new string[] { "VR" });

        // UE5.7.1 推荐设置
        bOverrideBuildEnvironment = true; // 允许覆盖构建环境

        // 使用新的方式设置编译器警告
        CppCompileWarningSettings.UndefinedIdentifierWarningLevel = WarningLevel.Error;
        WindowsPlatform.bStrictConformanceMode = true;

        // UE5.7.1 必须使用C++20
        CppStandard = CppStandardVersion.Cpp20;

        // 其他兼容性设置
        bValidateFormatStrings = true;
        WindowsPlatform.bStrictInlineConformance = true;
        bLegacyParentIncludePaths = false;  // UE5.7 推荐设置为 false
    }
}