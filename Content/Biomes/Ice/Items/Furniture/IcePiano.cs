using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice.Items.Furniture;

	public class IcePiano : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Glacier Wood Piano");
			//Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			Item.width = 62;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.rare = ItemRarityID.Blue;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<IcePianoTile>();
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Bone, 4);
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 15);
			recipe.AddIngredient(ItemID.Book);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Sawmill);
			recipe.Register();
		}
	}