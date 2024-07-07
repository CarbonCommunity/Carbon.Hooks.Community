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
		[HookAttribute.Patch("OnCupboardAuthorize", "OnCupboardAuthorize", typeof(CorePlugin), "IOnCupboardAuthorize")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Structure")]
		[MetadataAttribute.Info("Called when a cupboard attempts to authorize a player.")]
		[MetadataAttribute.Parameter("priv", typeof(BuildingPrivlidge))]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Return(typeof(object))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnCupboardAuthorize : Patch
		{

		}
	}
}
