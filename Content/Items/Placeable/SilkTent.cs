using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Placeable;

	public class SilkTent : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 32;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<SilkTentTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Silk Tent");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
	}
