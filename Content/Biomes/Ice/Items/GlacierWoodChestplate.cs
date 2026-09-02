using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice.Items;

	[AutoloadEquip(EquipType.Body)]
	public class GlacierWoodChestplate : ModItem
	{
		public override void SetDefaults()
		{ 
			Item.width = 26;
			Item.height = 18;
			Item.value = 600;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 3;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacier Wood Chestplate");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 30);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
