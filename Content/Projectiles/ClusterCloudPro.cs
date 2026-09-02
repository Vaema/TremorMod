using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class ClusterCloudPro : ModProjectile
{
		public override void SetDefaults()
		{
			Projectile.width = 40;
			Projectile.height = 40;
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
	}