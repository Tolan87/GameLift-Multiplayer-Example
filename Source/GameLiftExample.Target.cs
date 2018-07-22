// Copyright 2018 Toni "ToLanHD" Langbein. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftExampleTarget : TargetRules
{
	public GameLiftExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

        bForceEnableExceptions = true;

        ExtraModuleNames.AddRange( new string[] { "GameLiftExample" } );
	}
}
