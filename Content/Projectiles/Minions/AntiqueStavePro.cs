using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles.Minions;

public class AntiqueStavePro : ModProjectile
{
    public override void SetStaticDefaults()
    {
        // Óñòàíîâèòå êîëè÷åñòâî êàäðîâ àíèìàöèè äëÿ ñíàðÿäà
        Main.projFrames[Projectile.type] = 1;

        // Íàçâàíèå ñíàðÿäà (îïöèîíàëüíî, åñëè òðåáóåòñÿ)
        // DisplayName.SetDefault("Antique Soul");
    }

    public override void SetDefaults()
    {
        Projectile.width = 30;
        Projectile.height = 30;
        Projectile.hostile = false;
        Projectile.friendly = false;
        Projectile.ignoreWater = true;
        Projectile.timeLeft = 900;
        Projectile.penetrate = -1;
        Projectile.tileCollide = true;
        Projectile.sentry = true;

        // Âêëþ÷åíèå ôóíêöèè ïðèöåëèâàíèÿ ìèíüîíîâ
        ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true;
    }

    public override void AI()
    {
        for (int i = 0; i < 200; i++)
        {
            NPC target = Main.npc[i];

            float shootToX = target.position.X + target.width * 0.5f - Projectile.Center.X;
            float shootToY = target.position.Y + target.height * 0.5f - Projectile.Center.Y;
            float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);

            if (distance < 520f && !target.friendly && target.active)
            {
                if (Projectile.ai[0] > 35f) // Çàäåðæêà â 35 êàäðîâ (ïðèìåðíî 0.58 ñåêóíäû)
                {
                    distance = 1.6f / distance;
                    shootToX *= distance * 3;
                    shootToY *= distance * 3;
                    int damage = 30;

                    // Èñïîëüçóåì êîððåêòíûé èñòî÷íèê
                    Projectile.NewProjectile(
                        Projectile.GetSource_FromAI(),
                        Projectile.Center.X,
                        Projectile.Center.Y,
                        shootToX,
                        shootToY,
                        ProjectileID.TopazBolt, // Òèï ñíàðÿäà
                        damage,
                        0,
                        Main.myPlayer
                    );

                    Projectile.ai[0] = 0f;
                }
                Projectile.ai[0] += 1f;
            }
        }
    }
}
