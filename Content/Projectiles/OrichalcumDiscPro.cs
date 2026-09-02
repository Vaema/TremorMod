using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

public class OrichalcumDiscPro : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.CloneDefaults(106);

        AIType = ProjectileID.LightDisc;
    }

    /*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("OrichalcumDiscPro");
		}*/
}