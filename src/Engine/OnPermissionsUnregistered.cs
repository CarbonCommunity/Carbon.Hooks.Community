using API.Hooks;
using Oxide.Core.Libraries;
using Oxide.Core.Plugins;

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
		[HookAttribute.Patch("OnPermissionsUnregistered", "OnPermissionsUnregistered", typeof(Permission), nameof(Permission.UnregisterPermissions))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Permissions")]
		[MetadataAttribute.Info("Gets called when all permission of a plugin have been unregistered.")]
		[MetadataAttribute.Parameter("plugin", typeof(Plugin))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnPermissionsUnregistered : Patch
		{

		}
	}
}
