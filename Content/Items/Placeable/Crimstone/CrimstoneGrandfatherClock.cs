using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles.Crimstone;

namespace TremorMod.Content.Items.Placeable.Crimstone;

	public class CrimstoneGrandfatherClock : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 74;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<CrimstoneGrandfatherClockTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crimstone Grandfather Clock");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CrimstoneBlock, 10);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.Glass, 6);
			recipe.AddIngredient(ItemID.CrimtaneBar, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();

			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.CrimstoneBlock, 10);
			recipe1.AddIngredient(ItemID.LeadBar, 3);
			recipe1.AddIngredient(ItemID.Glass, 6);
			recipe1.AddIngredient(ItemID.CrimtaneBar, 1);
			recipe1.AddTile(TileID.Furnaces);
			recipe1.Register();
		}
	}