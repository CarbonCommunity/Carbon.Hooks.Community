using System.Threading.Tasks;
using API.Hooks;
using Carbon.Client;
using Carbon.Client.SDK;
using ConVar;
using Oxide.Core;
using Oxide.Core.Plugins;
using Oxide.Plugins;
using UnityEngine;
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
		[HookAttribute.Patch("CanUserLogin", "CanUserLogin", null, null, null)]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Gets called when a client should or not should join the server.")]
		[MetadataAttribute.Parameter("username", typeof(string))]
		[MetadataAttribute.Parameter("userid", typeof(string))]
		[MetadataAttribute.Parameter("ip", typeof(string))]

		public class CanUserLogin : Patch
		{

		}
	}
}
