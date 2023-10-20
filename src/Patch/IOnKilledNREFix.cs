using System;
using System.Security.Cryptography;
using System.Text;
using API.Hooks;
using UnityEngine;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Fixes
{
	public partial class Fixes_OnKilledNREFix
	{
		[HookAttribute.Patch("IOnKilledNREFix", "IOnKilledNREFix", typeof(LootContainer), "OnKilled", new Type[] { typeof(HitInfo) })]
		[HookAttribute.Identifier("adf38a97475361e166aa4f987d3e8985")]
		[HookAttribute.Options(HookFlags.Hidden | HookFlags.Static | HookFlags.IgnoreChecksum)]

		public class Fixes_OnKilledNREFix_adf38a97475361e166aa4f987d3e8985 : Patch
		{
			internal static HitInfo _reusableNulledHit = new();

			public static void Prefix(ref HitInfo info)
			{
				if (info == null)
				{
					info = _reusableNulledHit ?? (_reusableNulledHit = new());
				}
			}
		}
	}
}
