using System.Threading.Tasks;
using API.Hooks;
using Carbon.Client;
using Carbon.Client.SDK;
using ConVar;
using Network;
using Oxide.Core;
using Oxide.Core.Libraries.Covalence;
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
		[HookAttribute.Patch("OnPlayerBanned", "OnPlayerBanned", null, null, null)]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Player")]
		[MetadataAttribute.Info("Gets called when a connection gets banned.")]
		[MetadataAttribute.Parameter("connection", typeof(Connection))]
		[MetadataAttribute.Parameter("reason", typeof(string))]

		public class OnPlayerBanned : Patch
		{

		}
	}
}
