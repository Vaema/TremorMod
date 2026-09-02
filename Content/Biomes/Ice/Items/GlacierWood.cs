using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice.Items;

	public class GlacierWood : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 12;
			Item.value = 1;
			Item.height = 12;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = ItemRarityID.Blue;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<GlacierWoodTile>();
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacier Wood");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ModContent.ItemType<GlacierWoodWallItem>(), 4);
			//recipe.SetResult(this, 1);
			recipe1.AddTile(TileID.WorkBenches);
			recipe1.Register();

			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ModContent.ItemType<GlacierFence>(), 4);
			//recipe.SetResult(this, 1);
			recipe2.AddTile(TileID.WorkBenches);
			recipe2.Register();
		}
	}
