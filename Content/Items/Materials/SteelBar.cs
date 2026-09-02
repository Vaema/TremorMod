using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Materials;

	public class SteelBar : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 300;
			Item.rare = ItemRarityID.Blue;
			Item.createTile = ModContent.TileType<SteelBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Bar");
			Tooltip.SetDefault("");
		}*/

    public override void AddRecipes()
    {
        Recipe recipe1 = CreateRecipe();
        recipe1.AddIngredient(ItemID.IronBar, 2);
        recipe1.AddIngredient(ModContent.ItemType<Charcoal>(), 2);
        recipe1.AddTile(ModContent.TileType<BlastFurnaceTile>()); // Çäåñü íóæíî èñïîëüçîâàòü ïëèòêó, à íå ïðåäìåò
        recipe1.Register();

        Recipe recipe2 = CreateRecipe();
        recipe2.AddIngredient(ItemID.LeadBar, 2);
        recipe2.AddIngredient(ModContent.ItemType<Charcoal>(), 2);
        recipe2.AddTile(ModContent.TileType<BlastFurnaceTile>()); // Àíàëîãè÷íî
        recipe2.Register();
    }

}
