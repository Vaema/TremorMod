using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class HuntingSpear : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 18;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<HuntingSpearPro>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 4;
			Item.value = 900;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Hunting Spear");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 5);
			recipe.AddIngredient(ItemID.BorealWood, 20);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 2);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.SetResult(this);
			recipe.Register();
		}
	}
