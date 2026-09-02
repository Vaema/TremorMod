using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Ranged;

	public class StartrooperFlameburstPistol : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 248;
			Item.width = 30;
			Item.height = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = ProjectileID.DD2FlameBurstTowerT2Shot;

			Item.shootSpeed = 20f;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 5;
			Item.value = 450000;
			Item.useAmmo = AmmoID.Bullet;
			Item.rare = ItemRarityID.Purple;
			Item.crit = 7;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Startrooper Flameburst Pistol");
			// Tooltip.SetDefault("Uses bullets as ammo");
		}

    public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        type = ProjectileID.DD2FlameBurstTowerT2Shot;
        Projectile.NewProjectile(source, position, velocity, type, damage, knockback, player.whoAmI);
        return false;
    }

    public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 2);
		}
	}
