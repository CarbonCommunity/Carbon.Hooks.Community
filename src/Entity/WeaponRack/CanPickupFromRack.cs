using API.Hooks;
using static BaseEntity;

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
		[HookAttribute.Patch("CanPickupFromRack", "CanPickupFromRack", typeof(WeaponRack), "GivePlayerWeapon", new System.Type[] { typeof(BasePlayer), typeof(int), typeof(int), typeof(bool), typeof(bool) })]
		[HookAttribute.Identifier("ca34645d39b24c328b84ce4efd4fdb34")]

		[MetadataAttribute.Info("Returning a non-null value disallows the weapon to be picked up.")]
		[MetadataAttribute.Parameter("rack", typeof(WeaponRack))]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Parameter("item", typeof(Item))]
		[MetadataAttribute.Parameter("mountSlotIndex", typeof(int))]
		[MetadataAttribute.Parameter("playerBeltIndex", typeof(int))]
		[MetadataAttribute.Parameter("tryHold", typeof(bool))]
		[MetadataAttribute.Return(typeof(bool))]

		public class Entity_WeaponRack_ca34645d39b24c328b84ce4efd4fdb34 : Patch
		{
			internal static bool _hasPickedUp;
			internal static Item _currentItem;

			public static bool Prefix(BasePlayer player, int mountSlotIndex, int playerBeltIndex, bool tryHold, bool sendUpdate, WeaponRack __instance)
			{
				if (player == null)
				{
					return false;
				}

				var weaponAtIndex = __instance.GetWeaponAtIndex(mountSlotIndex);
				if (weaponAtIndex == null)
				{
					return false;
				}

				var slot = __instance.inventory.GetSlot(weaponAtIndex.InventoryIndex);
				if (slot == null)
				{
					return false;
				}

				_currentItem = slot;

				if (HookCaller.CallStaticHook(2308599075, __instance, player, _currentItem, mountSlotIndex, playerBeltIndex, tryHold) is bool hookValue)
				{
					_hasPickedUp = hookValue;
					return hookValue;
				}

				_hasPickedUp = true;
				return true;
			}

			public static void Postfix(BasePlayer player, int mountSlotIndex, int playerBeltIndex, bool tryHold, bool sendUpdate, WeaponRack __instance)
			{
				if (!_hasPickedUp)
				{
					return;
				}

				HookCaller.CallStaticHook(1687007383, __instance, player, _currentItem, mountSlotIndex, playerBeltIndex, tryHold);
			}
		}
	}
}
