using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Tools;

	public class IceDrill : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 32;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 5;
			Item.useAnimation = 25;
			Item.channel = true;
			Item.noUseGraphic = true;
			//Item.noMelee = true;
			Item.pick = 200;
			Item.axe = 24;
			Item.tileBoost++;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 20, 0, 0);
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<IceDrillPro>();
			Item.shootSpeed = 40f;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Ice Drill");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<FrostoneBar>(), 12);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.SetResult(this);
			recipe.Register();
		}
	}