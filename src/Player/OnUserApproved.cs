using API.Hooks;
using Carbon.Core;

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
		[HookAttribute.Patch("OnUserApproved", "OnUserApproved", typeof(CorePlugin), "IOnUserApprove")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Gets called when a connection is approved to join the server.")]
		[MetadataAttribute.Parameter("username", typeof(string))]
		[MetadataAttribute.Parameter("userid", typeof(string))]
		[MetadataAttribute.Parameter("ip", typeof(string))]

		public class OnUserApproved : Patch;
	}
}
