using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Items.Weapons.Magic;

	public class SoulFlames : ModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 200;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.shoot = ProjectileID.MolotovFire;
			Item.shootSpeed = 31f;
			Item.mana = 6;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 3;
			Item.value = 150000;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Soul Flames");
			// Tooltip.SetDefault("");
		}

    public override bool Shoot(Player player, Terraria.DataStructures.EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        for (int i = 0; i < 1; ++i)
        {
            Projectile.NewProjectile(source, position, velocity + new Vector2(+1, +1), type, damage, knockback, Main.myPlayer);
            Projectile.NewProjectile(source, position, velocity, type, damage, knockback, Main.myPlayer);
            Projectile.NewProjectile(source, position, velocity - new Vector2(-1, -1), type, damage, knockback, Main.myPlayer);
        }
        return false;
    }

}
