using API.Hooks;
using Carbon.Core;
using Carbon.Managers;
using Oxide.Plugins;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Structure
{
	public partial class Structure_Hooks
	{
		[HookAttribute.Patch("OnCupboardAssign", "OnCupboardAssign", typeof(CorePlugin), "IOnCupboardAuthorize")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Structure")]
		[MetadataAttribute.Info("Called when a player is assigned to a cupboard.")]
		[MetadataAttribute.Parameter("priv", typeof(BuildingPrivlidge))]
		[MetadataAttribute.Parameter("targetId", typeof(ulong))]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Return(typeof(object))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnCupboardAssign : Patch
		{

		}
	}
}
