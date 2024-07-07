using API.Hooks;
using Carbon.Core;
using static ConVar.Chat;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;
#pragma warning disable IDE0051

public partial class Category_Player
{
	public partial class Player_Hooks
	{
		[HookAttribute.Patch("OnPlayerOfflineChat", "OnPlayerOfflineChat", typeof(CorePlugin), "OnPlayerOfflineChat")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Gets called when a player sends an offline chat message.")]
		[MetadataAttribute.Parameter("playerid", typeof(ulong))]
		[MetadataAttribute.Parameter("username", typeof(string))]
		[MetadataAttribute.Parameter("message", typeof(string))]
		[MetadataAttribute.Parameter("channel", typeof(ChatChannel))]

		public class OnPlayerOfflineChat : Patch;
	}
}
