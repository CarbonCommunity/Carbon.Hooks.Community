using System.Threading.Tasks;
using API.Hooks;
using Carbon.Client.SDK;
using ConVar;
using Oxide.Core;
using Oxide.Core.Plugins;
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

public partial class Category_Client
{
	public partial class Client_Hooks
	{
		[HookAttribute.Patch("OnClientAddonsFinalized", "OnClientAddonsFinalized", null, null, null)]
		[HookAttribute.Options(HookFlags.MetadataOnly)]

		[MetadataAttribute.Category("Client")]
		[MetadataAttribute.Info("Gets called when a Carbon client finishes downloading addons.")]
		[MetadataAttribute.Parameter("client", typeof(ICarbonClient))]

		public class OnClientAddonsFinalized : Patch
		{

		}
	}
}
