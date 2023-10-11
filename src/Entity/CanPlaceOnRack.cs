using API.Hooks;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community 
 * All rights reserved.
 *
 */

namespace Carbon.Hooks;

public partial class Category_Entity
{
	public partial class WeaponRack_Entity
	{
		[HookAttribute.Patch("CanPlaceOnRack", "CanPlaceOnRack", typeof(WeaponRack), "MountWeapon", new System.Type[] { typeof(Item), typeof(BasePlayer), typeof(int), typeof(int), typeof(bool) })]
		[HookAttribute.Identifier("68f53adc59a14185a3d6d518cfe64e3f")]

		[MetadataAttribute.Info("Returning a non-null value disallows the weapon to be placed.")]
		[MetadataAttribute.Parameter("rack", typeof(WeaponRack))]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Parameter("item", typeof(Item))]
		[MetadataAttribute.Parameter("gridCellIndex", typeof(int))]
		[MetadataAttribute.Parameter("rotation", typeof(int))]
		[MetadataAttribute.Return(typeof(bool))]

		public class Entity_WeaponRack_68f53adc59a14185a3d6d518cfe64e3f : Patch
		{
			public static bool Prefix(Item item, BasePlayer player, int gridCellIndex, int rotation, bool sendUpdate, ref bool __result, WeaponRack __instance)
			{
				if (HookCaller.CallStaticHook(2507203607, __instance, player, item, gridCellIndex, rotation) is bool hookValue)
				{
					__result = hookValue;
					return false;
				}

				return true;
			}
		}
	}
}
