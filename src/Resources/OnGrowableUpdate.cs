using API.Hooks;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Resources
{
	public partial class Resources_GrowableEntity
	{
		[HookAttribute.Patch("OnGrowableUpdate", "OnGrowableUpdate", typeof(GrowableEntity), "RunUpdate", new System.Type[] { })]

		[MetadataAttribute.Parameter("growable", typeof(GrowableEntity))]
		[MetadataAttribute.Info("Called right before the growable entity is updated.")]

		public class OnGrowableUpdate : Patch
		{
			public static void Prefix(ref GrowableEntity __instance)
				=> HookCaller.CallStaticHook(63864217, __instance);
		}
	}
}
