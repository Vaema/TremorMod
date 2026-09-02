using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Biomes.Ice.Items;

namespace TremorMod.Content.Items.Materials;

	public class FrostCore : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 9999;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Frost Chunk");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Icicle>(), 4);
			//recipe.SetResult(this);
			recipe.Register();
		}
	}
