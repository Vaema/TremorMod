using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Materials.OreAndBar;

	public class InvarBar : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = Item.sellPrice(silver: 1, copper: 25);
			Item.rare = 1;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Invar Bar");
			Tooltip.SetDefault("Can be used to make Invar equipment at an anvil");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe1 = Recipe.Create(ModContent.ItemType<InvarBar>(), 3); // Êîëè÷åñòâî ñîçäàâàåìûõ InvarBar
			recipe1.AddIngredient(ModContent.ItemType<BrokenInvarShield>()); // Ìàòåðèàë BrokenInvarShield
			recipe1.AddTile(TileID.Furnaces); // Ïëàâèëüíÿ
			recipe1.Register();

			// Âòîðîé ðåöåïò: BrokenInvarSword -> 1 InvarBar
			Recipe recipe2 = Recipe.Create(ModContent.ItemType<InvarBar>(), 2); // Êîëè÷åñòâî ñîçäàâàåìûõ InvarBar
			recipe2.AddIngredient(ModContent.ItemType<BrokenInvarSword>()); // Ìàòåðèàë BrokenInvarSword
			recipe2.AddTile(TileID.Furnaces); 
			recipe2.Register();

			Recipe recipe3 = Recipe.Create(ModContent.ItemType<InvarBar>(), 4);
			recipe3.AddIngredient(ModContent.ItemType<OldInvarPlate>());
        recipe3.AddTile(TileID.Furnaces);
			recipe3.Register();
    }
	}
