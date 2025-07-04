using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System;
using API.Hooks;
using HarmonyLib;
using Patch = API.Hooks.Patch;

namespace Carbon.Hooks;

#pragma warning disable IDE0051

public partial class Category_Team
{
	public partial class Team_OnTeamOfflineInvite
	{
		[HookAttribute.Patch("OnTeamOfflineInvite", "OnTeamOfflineInvite", typeof(RelationshipManager), "sendofflineinvite", [typeof(ConsoleSystem.Arg)])]
		[MetadataAttribute.Category("Team")]
		[MetadataAttribute.Parameter("inviter", typeof(BasePlayer))]
		[MetadataAttribute.Parameter("invitee", typeof(VendingMachine))]
		[MetadataAttribute.Parameter("invitee_steamid", typeof(ulong))]
		[MetadataAttribute.Info("Called before inviting an offline player to a team.")]
		[MetadataAttribute.Info("invitee parameter can be null if the player is not on the server")]
		[MetadataAttribute.Return(typeof(bool))]
		public class OnTeamOfflineInvite : Patch
		{
			static bool Hook(BasePlayer inviter, BasePlayer invitee, ulong invitee_steamid)
			{
				return HookCaller.CallStaticHook(3751401922, inviter, invitee, invitee_steamid) == null;
			}

			static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
			{
				List<CodeInstruction> o = new(instructions);
				List<CodeInstruction> n = new();
				var jump_target = generator.DefineLabel();

				for (int i = 0; i < o.Count; i++)
				{
					if (i + 3 < o.Count &&
						o[i + 0].opcode == OpCodes.Ldloc_3 &&
						o[i + 1].opcode == OpCodes.Ldnull &&
						o[i + 2].opcode == OpCodes.Call && (MethodInfo)o[i + 2].operand == AccessTools.Method(typeof(UnityEngine.Object), "op_Inequality") &&
						(o[i + 3].opcode == OpCodes.Brfalse_S || o[i + 3].opcode == OpCodes.Brfalse))
					{
						n.Add(new(OpCodes.Ldloc_0) { labels = o[i + 0].labels, blocks = o[i + 0].blocks });
						n.Add(new(OpCodes.Ldloc_3));
						n.Add(new(OpCodes.Ldloc_2));
						n.Add(new(OpCodes.Call, AccessTools.Method(typeof(OnTeamOfflineInvite), nameof(Hook))));
						n.Add(new(OpCodes.Brtrue_S, jump_target));
						n.Add(new(OpCodes.Ret));
						n.Add(new(OpCodes.Nop) { labels = [jump_target] });

						o[i + 0].labels = new();
						o[i + 0].blocks = new();
					}

					n.Add(o[i]);
				}

				return n;
			}
		}
	}
}
