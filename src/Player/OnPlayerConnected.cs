using API.Hooks;
using Carbon.Core;
using Network;

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
		[HookAttribute.Patch("OnPlayerConnected", "OnPlayerConnected", typeof(CorePlugin), "IOnPlayerConnected")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Called after the player object is created, but before the player has spawned.")]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]

		public class OnPlayerConnected : Patch
		{

		}
	}
}
