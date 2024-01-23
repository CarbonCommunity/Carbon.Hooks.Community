using System.Threading.Tasks;
using API.Hooks;
using Carbon.Base;
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

public partial class Category_Engine
{
	public partial class Engine_Hooks
	{
		[HookAttribute.Patch("CanUseUI", "CanUseUI", null, null, null)]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Engine")]
		[MetadataAttribute.Info("Gets called when an UI is about to be sent to a player.")]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Parameter("json", typeof(string))]

		public class CanUseUI : Patch
		{

		}
	}
}
