using System;
using System.Collections.Generic;

namespace tanu.CruiseAssist
{
	public static class CruiseAssistPlugin
	{
		internal static readonly List<CruiseAssistExtensionAPI> Extensions = new List<CruiseAssistExtensionAPI>();

		public static void RegistExtension(CruiseAssistExtensionAPI extension)
		{
			Extensions.Add(extension);
		}

		public static void UnregistExtension(Type extensionType)
		{
			Extensions.RemoveAll(e => e.GetType() == extensionType);
		}
	}
}
