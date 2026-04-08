namespace tanu.CruiseAssist
{
	public abstract class CruiseAssistExtensionAPI
	{
		public virtual void CheckConfig(ConfigManager.Step step) { }
		public virtual void SetTargetAstroId(int astroId) { }
		public virtual void OperateWalk(PlayerMove_Walk __instance) { }
		public virtual void OperateDrift(PlayerMove_Drift __instance) { }
		public virtual void OperateFly(PlayerMove_Fly __instance) { }
		public virtual void OperateSail(PlayerMove_Sail __instance) { }
		public virtual void SetInactive() { }
		public virtual void CancelOperate() { }
		public virtual void OnGUI() { }
	}
}
