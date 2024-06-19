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
		[HookAttribute.Patch("OnGroupPermissionGranted", "OnGroupPermissionGranted", typeof(Permission), nameof(Permission.GrantGroupPermission))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Permissions")]
		[MetadataAttribute.Info("Gets called when a permission has been assigned to a group.")]
		[MetadataAttribute.Parameter("group", typeof(string))]
		[MetadataAttribute.Parameter("permission", typeof(string))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnGroupPermissionGranted : Patch;
	}
}
