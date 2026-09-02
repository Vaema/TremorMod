using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Materials;

	public class NightmareBar : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 15000;
			Item.rare = ItemRarityID.Purple;
			Item.createTile = ModContent.TileType<NightmareBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare Bar");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareOre>(), 6);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
