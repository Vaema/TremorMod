using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.Items.Placeable;

	public class ChristmasFireplace : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 48;
			Item.height = 32;
			Item.maxStack = 9999;
			Item.rare = ItemRarityID.Blue;
			Item.createTile = ModContent.TileType<ChristmasFireplaceTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Christmas Fireplace");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RedBrick, 10);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddIngredient(ItemID.Torch, 2);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
