using API.Hooks;
using Carbon.Core;
using Carbon.Modules;
using Network;

namespace Carbon.Hooks;

#pragma warning disable IDE0051

public partial class Category_Player
{
	public partial class Player_Hooks
	{
		[HookAttribute.Patch("OnCarbonBlinded", "OnCarbonBlinded", typeof(AdminModule), "BlindPlayer")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Called when a player is blinded.")]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]

		public class OnCarbonBlinded : Patch;
	}
}
