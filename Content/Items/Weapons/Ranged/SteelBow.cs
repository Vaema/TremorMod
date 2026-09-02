using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class SteelBow : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 30;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 11f;
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
			// DisplayName.SetDefault("Steel Bow");
			// Tooltip.SetDefault("");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-1, 0);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 9);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
