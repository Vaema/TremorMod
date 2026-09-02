using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class StormJellyfishMask : ModItem
	{

		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 24;
			Item.rare = ItemRarityID.Blue;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Storm Jellyfish Mask");
			// Tooltip.SetDefault("");
		}

	}
