using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class ToxicFlaskCloud : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 32;
        Projectile.height = 32;
        Projectile.penetrate = 8;
        Projectile.aiStyle = ProjAIStyleID.ToxicCloud;
        AIType = ProjectileID.ToxicCloud;
        Projectile.friendly = true;
        Projectile.timeLeft = 600;
    }
}