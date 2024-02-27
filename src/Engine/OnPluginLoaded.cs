using API.Hooks;
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

public partial class Category_Engine
{
	public partial class Engine_Hooks
	{
		[HookAttribute.Patch("OnPluginLoaded", "OnPluginLoaded", typeof(ScriptLoader), nameof(ScriptLoader.Compile))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Permissions")]
		[MetadataAttribute.Info("Gets called when a plugin is loaded.")]
		[MetadataAttribute.Parameter("plugin", typeof(RustPlugin))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnPluginLoaded : Patch
		{

		}
	}
}
