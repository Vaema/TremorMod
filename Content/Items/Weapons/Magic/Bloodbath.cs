using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class Bloodbath : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 98;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.shoot = ProjectileID.IchorSplash;
			Item.shootSpeed = 6f;
			Item.mana = 6;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 3;
			Item.value = 122355;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item21;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Bloodbath");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldenShower, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 8);
			recipe.AddTile(TileID.LunarCraftingStation);
			//recipe.SetResult(this);
			recipe.Register();
		}
	}
