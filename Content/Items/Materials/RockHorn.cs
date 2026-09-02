using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials;

	public class RockHorn : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 14;
			Item.height = 22;
			Item.maxStack = 9999;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.buyPrice(0, 0, 5, 0);
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Rock Horn");
			//Tooltip.SetDefault("");
		}
	}