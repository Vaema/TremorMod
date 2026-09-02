using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Vanity;

	[AutoloadEquip(EquipType.Head)]
	public class LaurelWreath : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 24;
			Item.rare = ItemRarityID.Green;
		}

		public override void SetStaticDefaults()
		{
        //DisplayName.SetDefault("Laurel Wreath");
        //Tooltip.SetDefault("'The latest fashion trend'");
        base.SetStaticDefaults();
        ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;
    }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Vine, 3);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
