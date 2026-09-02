using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Materials.OreAndBar;

	public class CandyBar : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 6000;
			Item.rare = ItemRarityID.Red;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.createTile = ModContent.TileType<CandyBarTile>();
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Candy Bar");
			//Tooltip.SetDefault("");
		}
	}