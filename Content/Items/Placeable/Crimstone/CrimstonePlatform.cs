using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles.Crimstone;

namespace TremorMod.Content.Items.Placeable.Crimstone;

	public class CrimstonePlatform : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<CrimstonePlatformTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crimstone Platform");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(2);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
