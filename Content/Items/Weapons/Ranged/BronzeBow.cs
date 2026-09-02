using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class BronzeBow : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 10;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 30;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 12f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 5;
			Item.value = 540;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bronze Bow");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<BronzeBar>(), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
