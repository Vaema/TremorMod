using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.Items.Weapons.Melee;

	public class FlamingTooth : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 18;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 46;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ProjectileID.ImpFireball;
			Item.shootSpeed = 6f;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2;
			Item.value = 46000;
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Flaming Tooth");
			//Tooltip.SetDefault("");
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(BuffID.OnFire, 60);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBroadsword, 1);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 8);
			//recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.PlatinumBroadsword, 1);
			recipe1.AddIngredient(ModContent.ItemType<FireFragment>(), 8);
			//recipe.SetResult(this);
			recipe1.AddTile(TileID.Anvils);
			recipe1.Register();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool())
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch);
			}
		}
	}
