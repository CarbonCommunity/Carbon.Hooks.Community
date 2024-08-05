using API.Hooks;
using Oxide.Plugins;

namespace Carbon.Hooks;

#pragma warning disable IDE0051

public partial class Category_Engine
{
	public partial class Engine_Hooks
	{
		[HookAttribute.Patch("OnPluginLoaded", "OnPluginLoaded", null, null)]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Engine")]
		[MetadataAttribute.Info("Gets called when a plugin is loaded.")]
		[MetadataAttribute.Parameter("plugin", typeof(RustPlugin))]
		[MetadataAttribute.Assembly("Carbon.Common.dll")]

		public class OnPluginLoaded : Patch
		{

		}
	}
}
