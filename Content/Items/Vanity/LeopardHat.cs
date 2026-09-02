using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class LeopardHat : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 22;
			Item.value = 100000;
			Item.rare = ItemRarityID.Purple;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Leopard Hat");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<FashionableHat>());
			recipe.AddIngredient(ItemID.LeopardSkin);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
	}