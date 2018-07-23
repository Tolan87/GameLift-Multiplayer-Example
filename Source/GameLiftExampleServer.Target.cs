// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftExampleServerTarget : TargetRules
{
	public GameLiftExampleServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;

        // Suppress build error 4577
        bForceEnableExceptions = true;

        ExtraModuleNames.AddRange( new string[] { "GameLiftExample" } );
	}
}
