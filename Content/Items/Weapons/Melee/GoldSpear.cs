using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class GoldSpear : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 14;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.shoot = ModContent.ProjectileType<GoldSpearPro>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 4;
			Item.value = 1000;
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Spear");
			Tooltip.SetDefault("");
		}*/

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 9);
			recipe.AddTile(TileID.Anvils);
			//recipe.SetResult(this);
			recipe.Register();
		}
	}
