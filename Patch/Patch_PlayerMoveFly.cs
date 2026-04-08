using HarmonyLib;
using System;

namespace tanu.CruiseAssist
{
	[HarmonyPatch(typeof(PlayerMove_Fly))]
	public class Patch_PlayerMoveFly
	{
		[HarmonyPatch(nameof(PlayerMove_Fly.GameTick)), HarmonyPrefix]
		public static void GameTick_Prefix(PlayerMove_Fly __instance)
		{
			CruiseAssistPlugin.Extensions.ForEach(extension =>
			{
				try { extension.OperateFly(__instance); }
				catch (Exception e) { LogManager.LogError($"Extension OperateFly error: {e.Message}"); }
			});
		}
	}
}
