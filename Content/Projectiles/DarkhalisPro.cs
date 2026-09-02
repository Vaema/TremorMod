using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class DarkhalisPro : ModProjectile
	{
		public override void SetDefaults()
		{
        Projectile.CloneDefaults(595);
        Projectile.width = 100;
        Projectile.height = 70;
        AIType = ProjectileID.Arkhalis;
        Main.projFrames[Projectile.type] = 28;
    }

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("DarkhalisPro");

		}

	}
