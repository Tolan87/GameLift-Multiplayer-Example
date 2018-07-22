// Copyright 2018 Toni "ToLanHD" Langbein. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftExampleEditorTarget : TargetRules
{
	public GameLiftExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        ExtraModuleNames.AddRange( new string[] { "GameLiftExample" } );
	}
}
