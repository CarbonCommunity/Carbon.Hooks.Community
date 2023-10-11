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
		[HookAttribute.Patch("OnInterferenceOthersUpdate", "OnInterferenceOthersUpdate", typeof(AutoTurret), "UpdateInterferenceOnOthers", new System.Type[] { })]
		[HookAttribute.Identifier("bc34b4a6394c41051cad2a6847d83d09")]

		[MetadataAttribute.Info("Gets called whenever the AutoTurret updates interference on others.")]
		[MetadataAttribute.Parameter("turret", typeof(AutoTurret))]
		[MetadataAttribute.Return(typeof(bool))]

		public class Entity_AutoTurret_bc34b4a6394c41051cad2a6847d83d09 : Patch
		{
			public static bool Prefix(ref AutoTurret __instance)
			{
				return HookCaller.CallStaticHook(2749698302, __instance) == null;
			}
		}
	}
}
