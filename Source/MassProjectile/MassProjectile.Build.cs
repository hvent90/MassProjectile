// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MassProjectile : ModuleRules
{
	public MassProjectile(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core", "CoreUObject", "Engine", "InputCore", "Niagara", "AIModule", "SmartObjectsModule"
		});

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"MassEntity",
				"StructUtils",
				"MassCommon",
				"MassMovement",
				"MassActors",
				"MassSpawner",
				"MassGameplayDebug",
				"MassSignals",
				"MassCrowd",
				"MassActors",
				"MassSpawner",
				"MassRepresentation",
				"MassReplication",
				"MassNavigation",

				//needed for replication setup
				"NetCore",
				"AIModule",

				"ZoneGraph",
				"MassGameplayDebug",
				"MassZoneGraphNavigation", 
				"Niagara",
				"DeveloperSettings",
				"GeometryCore",
				"MassAIBehavior",
				"StateTreeModule",
				"MassLOD",
				"NavigationSystem",
				"DerivedDataCache"
			}
		);
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
