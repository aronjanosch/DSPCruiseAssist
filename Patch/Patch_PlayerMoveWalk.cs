using HarmonyLib;
using System;

namespace tanu.CruiseAssist
{
	[HarmonyPatch(typeof(PlayerMove_Walk))]
	public class Patch_PlayerMoveWalk
	{
		[HarmonyPatch(nameof(PlayerMove_Walk.GameTick)), HarmonyPrefix]
		public static void GameTick_Prefix(PlayerMove_Walk __instance)
		{
			CruiseAssistPlugin.Extensions.ForEach(extension =>
			{
				try { extension.OperateWalk(__instance); }
				catch (Exception e) { LogManager.LogError($"Extension OperateWalk error: {e.Message}"); }
			});
		}
	}
}
