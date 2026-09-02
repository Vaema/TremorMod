using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class FrostJavelinPro : ModProjectile
	{
		public override void SetDefaults()
		{

			Projectile.width = 3;
			Projectile.height = 11;
			Projectile.friendly = true;
			Projectile.aiStyle = ProjAIStyleID.StickProjectile;
			Projectile.timeLeft = 1200;
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Javelin");

		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(3))
			{
				target.AddBuff(BuffID.Frostburn, 280, false);
			}
		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, DustID.MagicMirror, Projectile.oldVelocity.X * 0.1f, Projectile.oldVelocity.Y * 0.1f);
			}
			SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
		}

	}
