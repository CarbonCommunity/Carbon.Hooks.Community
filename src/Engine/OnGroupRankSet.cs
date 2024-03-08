using API.Hooks;
using Oxide.Core.Libraries;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Engine
{
	public partial class Engine_Hooks
	{
		[HookAttribute.Patch("OnGroupRankSet", "OnGroupRankSet", typeof(Permission), nameof(Permission.SetGroupRank))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Permissions")]
		[MetadataAttribute.Info("Gets called when group rank is set.")]
		[MetadataAttribute.Parameter("group", typeof(string))]
		[MetadataAttribute.Parameter("rank", typeof(int))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnGroupRankSet : Patch
		{

		}
	}
}
