using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class AdamantiteWarhammer : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 49;
        Item.DamageType = DamageClass.Melee;
        Item.width = 48;
			Item.height = 48;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.hammer = 86;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 7;
			Item.value = 27600;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Warhammer");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.AdamantiteBar, 12);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
