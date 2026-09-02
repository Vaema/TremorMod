using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Placeable;

	public class MarbleVase : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 22;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
			Item.createTile = ModContent.TileType<MarbleVaseTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Marble Vase");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MarbleBlock, 10);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
