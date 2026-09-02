using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Placeable;

	public class EbonstoneGrandfatherClock : ModItem
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
			Item.createTile = ModContent.TileType<EbonstoneGrandfatherClockTile>();
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ebonstone Grandfather Clock");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EbonstoneBlock, 10);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.Glass, 6);
			recipe.AddIngredient(ItemID.DemoniteBar, 1);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();

			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.EbonstoneBlock, 10);
			recipe1.AddIngredient(ItemID.LeadBar, 3);
			recipe1.AddIngredient(ItemID.Glass, 6);
			recipe1.AddIngredient(ItemID.DemoniteBar, 1);
			//recipe.SetResult(this);
			recipe1.AddTile(TileID.Furnaces);
			recipe1.Register();
		}
	}