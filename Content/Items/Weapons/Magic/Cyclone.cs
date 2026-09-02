using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class Cyclone : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 84;
			Item.width = 14;
			Item.height = 84;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 16;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.shoot = ModContent.ProjectileType<CyclonePro>();
			Item.shootSpeed = 4f;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 4;
			Item.value = 230000;
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Cyclone");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTechnology>(), 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 30);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 25);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
