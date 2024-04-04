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

public partial class Category_Engine
{
	public partial class Engine_Hooks
	{
		[HookAttribute.Patch("OnCompilationFail", "OnCompilationFail", typeof(ScriptLoader), nameof(ScriptLoader.Compile))]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Engine")]
		[MetadataAttribute.Info("Gets called when a plugin is unloaded.")]
		[MetadataAttribute.Parameter("filePath", typeof(string))]
		[MetadataAttribute.Parameter("compilation", typeof(ModLoader.FailedCompilation))]
		[MetadataAttribute.Assembly("Carbon.dll")]

		public class OnCompilationFail : Patch
		{

		}
	}
}
