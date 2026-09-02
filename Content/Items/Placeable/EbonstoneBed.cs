using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Placeable;

	public class EbonstoneBed : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 64;
			Item.height = 26;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<EbonstoneBedTile>();
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ebonstone Bed");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EbonstoneBlock, 15);
			recipe.AddIngredient(ItemID.DemoniteBar, 1);
			recipe.AddIngredient(ItemID.Silk, 5);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}