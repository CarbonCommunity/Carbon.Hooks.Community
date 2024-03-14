using API.Hooks;
using Carbon.Core;
using Network;
using Oxide.Core.Libraries.Covalence;

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
		[HookAttribute.Patch("OnUserConnected", "OnUserConnected", typeof(CorePlugin), "IOnPlayerConnected")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Parameter("player", typeof(IPlayer))]

		public class OnUserConnected : Patch
		{

		}
	}
}
