using Terraria;
using Terraria.ModLoader;
using TremorMod.Content.Tiles.GloomstoneTiles;
using TremorMod.Content.Items.Materials;
using Terraria.ID;

namespace TremorMod.Content.Items.Placeable.GloomstonePlaceable;

	public class GloomstoneChair : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 16;
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
			Item.createTile = ModContent.TileType<GloomstoneChairTile>();
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Gloomstone Chair");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 4);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}