using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class ZellariumCloudPro : ModProjectile
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
		}

		public override void AI()
		{
			Projectile.rotation = 0f;
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			int k = Main.rand.Next(2, 3);
			Main.player[Projectile.owner].statLife += k;
			Main.player[Projectile.owner].HealEffect(k);
		}
	}