// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class HelloSteam : ModuleRules
{
	public HelloSteam(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
