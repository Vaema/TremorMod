using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Wood;

	public class WoodenFrame : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 34;
			Item.value = 120000;
			Item.rare = ItemRarityID.Green;
			Item.defense = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Wooden Frame");
			//Tooltip.SetDefault("");
		}
	}