using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TremorMod.Content.Projectiles;

public class RedStormLaser : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 10;
        Projectile.height = 300; // Ëàçåð äëèííûé
        Projectile.friendly = true;
        Projectile.DamageType = DamageClass.Ranged;
        Projectile.penetrate = -1; // Ëàçåð áóäåò íàíîñèòü óðîí íåñêîëüêî ðàç
        Projectile.timeLeft = 300;
        Projectile.ignoreWater = true;
        Projectile.tileCollide = false; // Ëàçåð íå áóäåò âçàèìîäåéñòâîâàòü ñ ïëèòêàìè
    }

    public override void AI()
    {
        // Ëàçåð âñåãäà äâèãàåòñÿ âíèç
        Projectile.velocity = new Vector2(0, 10f);

        // Äîáàâëåíèå âèçóàëüíûõ ýôôåêòîâ
        if (Main.rand.NextBool(5))
        {
            int dustID = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.PurpleCrystalShard);
            Main.dust[dustID].noGravity = true;
        }
    }
}
