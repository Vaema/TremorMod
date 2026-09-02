using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice.Items.Furniture;

	public class IceChestt : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Glacier Wood Chest");
			//Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<IceChestTile>();
		}

		public override void AddRecipes()
		{
			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ModContent.ItemType<GlacierWood>(), 8);
			recipe1.AddIngredient(ItemID.IronBar, 2);
			//recipe.SetResult(this);
			recipe1.AddTile(TileID.WorkBenches);
			recipe1.Register();

			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 8);
			recipe.AddIngredient(ItemID.LeadBar, 2);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}