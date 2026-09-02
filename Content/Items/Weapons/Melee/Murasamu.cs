using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class Murasamu : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 24;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 1000;
			Item.rare = ItemRarityID.Orange;
			Item.shoot = ProjectileID.WaterStream;
			Item.shootSpeed = 16f;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Murasamu");
			//Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 16);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}