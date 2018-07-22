// Copyright 2018 Toni "ToLanHD" Langbein. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftExampleServerTarget : TargetRules
{
	public GameLiftExampleServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;

        bForceEnableExceptions = true;

        ExtraModuleNames.AddRange( new string[] { "GameLiftExample" } );
	}
}
