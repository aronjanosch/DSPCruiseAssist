using HarmonyLib;
using System;

namespace tanu.CruiseAssist
{
	[HarmonyPatch(typeof(PlayerMove_Drift))]
	public class Patch_PlayerMoveDrift
	{
		[HarmonyPatch(nameof(PlayerMove_Drift.GameTick)), HarmonyPrefix]
		public static void GameTick_Prefix(PlayerMove_Drift __instance)
		{
			CruiseAssistPlugin.Extensions.ForEach(extension =>
			{
				try { extension.OperateDrift(__instance); }
				catch (Exception e) { LogManager.LogError($"Extension OperateDrift error: {e.Message}"); }
			});
		}
	}
}
