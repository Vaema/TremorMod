using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.EvilCornItems;

	class CornSeed : ModItem
	{
		public override void SetDefaults()
		{
			//Tile tile = new Tile();

			Item.maxStack = 999;
			Item.height = 2;
			Item.width = 2;
			Item.createTile = ModContent.TileType<CornTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.value = 100;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Green;
			Item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Corn Seeds");
			//Tooltip.SetDefault("");
		}
	}