using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Projectiles;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class TrueBloodCarnage : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 92;
			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.width = 50;
			Item.height = 52;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.shoot = ModContent.ProjectileType<TrueBloodCarnagePro>();
			Item.shootSpeed = 10f;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Blood Carnage");
			// Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.RedTorch);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<BloodCarnage>(), 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
