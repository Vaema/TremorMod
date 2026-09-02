using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

public class RedStormProjectile : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 10;
        Projectile.height = 10;
        Projectile.aiStyle = ProjAIStyleID.Arrow;
        Projectile.friendly = true;
        Projectile.DamageType = DamageClass.Ranged;
        Projectile.penetrate = 1;
        Projectile.timeLeft = 300;
        AIType = ProjectileID.WoodenArrowFriendly; // Ïîâåäåíèå ñòðåëû
    }

    public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
    {
        // Ïðè ïîïàäàíèè ñîçäàåì ëàçåðû ñ íåáà
        int laserCount = 5; // Êîëè÷åñòâî ëàçåðîâ
        for (int i = 0; i < laserCount; i++)
        {
            // Ïîçèöèÿ ëàçåðà íàä âðàãîì
            Vector2 laserPosition = new Vector2(
                target.Center.X + Main.rand.Next(-100, 100), // Ñëó÷àéíîå ñìåùåíèå ïî ãîðèçîíòàëè
                target.Center.Y - 600f                       // Âûñîòà ïîÿâëåíèÿ
            );

            Vector2 laserVelocity = new Vector2(0, 10f); // Ëàçåð äâèæåòñÿ âíèç

            // Ñîçäàåì ñíàðÿä ëàçåðà
            Projectile.NewProjectile(
                Projectile.GetSource_OnHit(target),
                laserPosition,
                laserVelocity,
                ModContent.ProjectileType<RedStormLaser>(), // Òèï ñíàðÿäà äëÿ ëàçåðà
                Projectile.damage / 2,  // Óðîí ëàçåðà (ïîëîâèíà îò èñõîäíîãî)
                0f,                     // Íåò îòäà÷è
                Projectile.owner        // Âëàäåëåö
            );
        }
    }
}
