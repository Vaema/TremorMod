using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Biomes.Ice.Items;

	public class GlacierWoodBow : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 9;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 29;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 11f;
			Item.useAnimation = 29;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 0;
			Item.value = 20;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Glacier Wood Bow");
			//Tooltip.SetDefault("");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-1, 0);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 10);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
