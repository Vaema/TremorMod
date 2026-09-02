using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class SharkhalisPro : ModProjectile
	{
    protected virtual float HoldoutRangeMin => 67f;
    protected virtual float HoldoutRangeMax => 145f;

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
        // DisplayName.SetDefault("SharkhalisPro");

    }

    public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
    {
        if (Main.rand.NextBool())
        {
            target.AddBuff(BuffID.CursedInferno, 180, false);
        }
    }
}
