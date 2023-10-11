using API.Hooks;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Entity
{
	public partial class Entity_AutoTurret
	{
		[HookAttribute.Patch("OnInterferenceUpdate", "OnInterferenceUpdate", typeof(AutoTurret), "UpdateInterference", new System.Type[] { })]
		[HookAttribute.Identifier("ea17a8f56481baa178df1dfc19e133da")]

		[MetadataAttribute.Info("Gets called whenever the AutoTurret updates interference.")]
		[MetadataAttribute.Parameter("turret", typeof(AutoTurret))]
		[MetadataAttribute.Return(typeof(bool))]

		public class Entity_AutoTurret_ea17a8f56481baa178df1dfc19e133da : Patch
		{
			public static bool Prefix(ref AutoTurret __instance)
			{
				return HookCaller.CallStaticHook(2728560177, __instance) == null;
			}
		}
	}
}
