using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.Weapons.Throwing;

	public class HolyJavelin : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 57;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 18;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 38;
			Item.useTime = 32;
			Item.useAnimation = 32;
			Item.shoot = ModContent.ProjectileType<HolyJavelinPro>();
			Item.shootSpeed = 16f;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Holy Javelin");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(50);
			recipe.AddIngredient(ItemID.HallowedBar, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
