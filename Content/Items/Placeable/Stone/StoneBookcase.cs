using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles.Stone;

namespace TremorMod.Content.Items.Placeable.Stone;

	public class StoneBookcase : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 42;
			Item.height = 16;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 0;
			Item.createTile = ModContent.TileType<StoneBookcaseTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone Bookcase");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(ItemID.Book, 10);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
