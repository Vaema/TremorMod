using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class ShadowCloudPro : ModProjectile
{
		public override void SetDefaults()
		{
			Projectile.width = 48;
			Projectile.height = 48;
			Projectile.DamageType = DamageClass.Magic;
			Projectile.penetrate = 8;
			Projectile.aiStyle = ProjAIStyleID.ToxicCloud;
			Projectile.friendly = true;
			Projectile.timeLeft = 600;
			Projectile.light = 1.0f;
		}

		public override bool PreAI()
		{
			if (Projectile.timeLeft == 600)
				Projectile.alpha = 255;

			return true;
		}

		public override void AI()
		{
			Projectile.rotation = 0f;
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(5))
			{
				target.AddBuff(BuffID.ShadowFlame, 180, false);
			}
		}

	}