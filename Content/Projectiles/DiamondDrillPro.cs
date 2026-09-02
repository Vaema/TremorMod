using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;


	public class DiamondDrillPro : ModProjectile
	{
		public override void SetDefaults()
		{

			Projectile.width = 22;
			Projectile.height = 22;
			Projectile.aiStyle = ProjAIStyleID.Drill;
			Projectile.friendly = true;
			Projectile.penetrate = -1;
			Projectile.tileCollide = false;
			Projectile.hide = true;
			Projectile.ownerHitCheck = true;
			Projectile.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Diamond Drill");

		}

		public override void AI()
		{
			int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.WhiteTorch, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 100, default(Color), 1.9f);
			Main.dust[dust].noGravity = true;
		}

	}
