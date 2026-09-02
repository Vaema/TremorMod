using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class ObsidianSaberPro : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(595);

			Projectile.width = 96;
			Projectile.height = 48;
			AIType = ProjectileID.Arkhalis;
			Main.projFrames[Projectile.type] = 28;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("ObsidianSaberPro");

		}

	}
