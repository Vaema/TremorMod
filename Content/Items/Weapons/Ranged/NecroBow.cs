using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class NecroBow : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 36;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 38;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 22f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 5;
			Item.value = 12540;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Necro Bow");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddIngredient(ItemID.Cobweb, 30);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
