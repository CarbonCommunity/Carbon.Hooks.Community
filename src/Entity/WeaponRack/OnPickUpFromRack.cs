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
		[HookAttribute.Patch("OnPickupFromRack", "OnPickupFromRack", typeof(WeaponRack), "GivePlayerWeapon", new System.Type[] { typeof(BasePlayer), typeof(int), typeof(int), typeof(bool), typeof(bool) })]
		[HookAttribute.Identifier("218d76c79e534841b0eacf66932f1769")]

		[MetadataAttribute.Info("Whenever a weapon was picked up from the rack.")]
		[MetadataAttribute.Parameter("rack", typeof(WeaponRack))]
		[MetadataAttribute.Parameter("player", typeof(BasePlayer))]
		[MetadataAttribute.Parameter("item", typeof(Item))]
		[MetadataAttribute.Parameter("mountSlotIndex", typeof(int))]
		[MetadataAttribute.Parameter("playerBeltIndex", typeof(int))]
		[MetadataAttribute.Parameter("tryHold", typeof(bool))]

		public class Entity_WeaponRack_218d76c79e534841b0eacf66932f1769 : Patch
		{
			// Implemented in CanPickupFromRack
		}
	}
}
