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
		[HookAttribute.Patch("OnUserGroupRemoved", "OnUserGroupRemoved", typeof(Permission), nameof(Permission.RemoveUserGroup))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Permissions")]
		[MetadataAttribute.Info("Whenever an user is removed from a group.")]
		[MetadataAttribute.Parameter("playerId", typeof(string))]
		[MetadataAttribute.Parameter("group", typeof(string))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnUserGroupRemoved : Patch
		{

		}
	}
}
