﻿using API.Hooks;
using Carbon.Core;

namespace Carbon.Hooks;

#pragma warning disable IDE0051

public partial class Category_Player
{
	public partial class Player_Hooks
	{
		[HookAttribute.Patch("CanUserLogin", "CanUserLogin", typeof(CorePlugin), "IOnUserApprove")]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Gets called when a client should or not should join the server.")]
		[MetadataAttribute.Parameter("username", typeof(string))]
		[MetadataAttribute.Parameter("userid", typeof(string))]
		[MetadataAttribute.Parameter("ip", typeof(string))]
		[MetadataAttribute.Return(typeof(bool))]

		public class CanUserLogin : Patch;
	}
}
