using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Placeable;

	public class SandstoneBookcase : ModItem
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
			Item.value = 2000;
			Item.createTile = ModContent.TileType<SandstoneBookcaseTile>();
		}

    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandstone Bookcase");
			Tooltip.SetDefault("");
		}*/

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.SandstoneBrick, 15);
        recipe.AddIngredient(ItemID.Silk, 5);
        //recipe.SetResult(this);
        recipe.AddTile(TileID.Furnaces);
        recipe.Register();
    }
}
