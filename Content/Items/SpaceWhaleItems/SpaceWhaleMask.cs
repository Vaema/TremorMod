using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.SpaceWhaleItems;

	[AutoloadEquip(EquipType.Head)]
	public class SpaceWhaleMask : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 20;
			Item.rare = ItemRarityID.Blue;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Space Whale Mask");
			//Tooltip.SetDefault("");
		}
	}