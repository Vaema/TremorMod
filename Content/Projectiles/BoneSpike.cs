using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class BoneSpike : ModProjectile
	{
		public override void SetDefaults()
		{

			Projectile.width = 22;
			Projectile.height = 22;
			Projectile.aiStyle = ProjAIStyleID.GroundProjectile;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.penetrate = 5;
			Projectile.timeLeft = 1500;
			Projectile.extraUpdates = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Spike");

		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 40; k++)
			{
				int dust = Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, DustID.Bone, Projectile.oldVelocity.X * 0.7f, Projectile.oldVelocity.Y * 0.7f);
			}
			SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
		}
	}
