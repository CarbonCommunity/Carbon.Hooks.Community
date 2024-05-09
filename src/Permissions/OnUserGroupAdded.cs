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
		[HookAttribute.Patch("OnUserGroupAdded", "OnUserGroupAdded", typeof(Permission), nameof(Permission.AddUserGroup))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Permissions")]
		[MetadataAttribute.Info("Whenever an user is added to a group.")]
		[MetadataAttribute.Parameter("playerId", typeof(string))]
		[MetadataAttribute.Parameter("group", typeof(string))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnUserGroupAdded : Patch
		{

		}
	}
}
