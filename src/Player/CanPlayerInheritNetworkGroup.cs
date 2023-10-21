﻿using API.Hooks;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Player
{
	public partial class BasePlayer_Player
	{
		[HookAttribute.Patch("CanPlayerInheritNetworkGroup", "CanPlayerInheritNetworkGroup", typeof(BasePlayer), "ShouldInheritNetworkGroup", new System.Type[] { })]

		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Info("Overrides the IsSpectating check, overriding the result.")]
		[MetadataAttribute.Return(typeof(bool))]

		public class CanPlayerInheritNetworkGroup : Patch
		{
			public static bool Prefix(ref BasePlayer __instance, ref bool __result)
			{
				if (HookCaller.CallStaticHook(3308399298, __instance) is bool hookValue)
				{
					__result = hookValue;
					return false;
				}

				return true;
			}
		}
	}
}
