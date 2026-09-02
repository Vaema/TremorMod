using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles; 

namespace TremorMod.Content.Items.Placeable;

	public class RedBrickChimney : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 9999;
			Item.rare = ItemRarityID.Blue;
			Item.createTile = ModContent.TileType<RedBrickChimneyTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Red Brick Chimney");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RedBrick, 10);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}