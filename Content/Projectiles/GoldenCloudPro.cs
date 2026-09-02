using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class GoldenCloudPro : ModProjectile
{
		public override void SetDefaults()
		{
			Projectile.width = 16;
			Projectile.height = 16;
			Projectile.DamageType = DamageClass.Magic;
			Projectile.penetrate = 8;
			Projectile.aiStyle = ProjAIStyleID.ToxicCloud;
			Projectile.friendly = true;
			Projectile.timeLeft = 600;
			Projectile.light = 1.0f;
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool())
			{
				target.AddBuff(BuffID.Midas, 10000, false);
			}
		}
	}