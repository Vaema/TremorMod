using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class TitaniumWarhammer : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 50;
			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.width = 44;
			Item.height = 44;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.hammer = 86;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 7;
			Item.value = 32200;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Titanium Warhammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TitaniumBar, 13);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
