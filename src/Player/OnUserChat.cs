﻿using API.Hooks;
using Carbon.Core;
using Oxide.Core.Libraries.Covalence;

namespace Carbon.Hooks;

#pragma warning disable IDE0051

public partial class Category_Player
{
	public partial class Player_Hooks
	{
		[HookAttribute.Patch("OnUserChat", "OnUserChat", typeof(CorePlugin), "IOnPlayerChat")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Gets called when a player sends a chat message.")]
		[MetadataAttribute.Parameter("player", typeof(IPlayer))]
		[MetadataAttribute.Parameter("message", typeof(string))]

		public class OnUserChat : Patch;
	}
}
