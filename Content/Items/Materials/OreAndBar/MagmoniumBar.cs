using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Materials.OreAndBar;

	public class MagmoniumBar : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 10000;
			Item.rare = ItemRarityID.Yellow;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.createTile = ModContent.TileType<MagmoniumBarTile>();
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magmonium Bar");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.HellstoneBar, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 2);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.AdamantiteForge);
        recipe.Register();
    }
	}
