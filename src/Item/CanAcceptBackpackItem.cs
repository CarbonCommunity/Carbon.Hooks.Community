﻿using API.Hooks;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Fun
{
	public partial class Fun_AnimalBrain
	{
		[HookAttribute.Patch("CanAcceptBackpackItem", "CanAcceptBackpackItem", typeof(ItemModBackpack), "CanAcceptItem", new System.Type[] { typeof(Item), typeof(Item), typeof(int) })]

		[MetadataAttribute.Info("Gets called whenever attempting to place an item in a backpack item, overriding returning output.")]
		[MetadataAttribute.Parameter("backpack", typeof(Item))]
		[MetadataAttribute.Parameter("item", typeof(Item))]
		[MetadataAttribute.Return(typeof(bool))]

		public class CanAcceptBackpackItem : Patch
		{
			public static bool Prefix(Item backpack, Item item, int slot, ref bool __result)
			{
				if (HookCaller.CallStaticHook(2803314817, backpack, item) is bool hookValue)
				{
					__result = hookValue;
					return false;
				}

				return true;
			}
		}
	}
}
