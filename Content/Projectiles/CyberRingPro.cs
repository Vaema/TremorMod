using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.Projectiles;

public class CyberRingPro : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 90;
        Projectile.height = 90;
        Projectile.hostile = true;
        Projectile.timeLeft = 500;
        Projectile.light = 0.8f;
        Projectile.tileCollide = false; // Ïðîõîäèò ñêâîçü áëîêè
        Projectile.penetrate = -1; // Íå èñ÷åçàåò ïðè ñòîëêíîâåíèè
    }

    public override void AI()
    {
        // Ïîèñê öåëè (èãðîêà)
        Player target = Main.player[Player.FindClosest(Projectile.Center, Projectile.width, Projectile.height)];
        if (target != null && target.active && !target.dead)
        {
            // Íàïðàâëåíèå íà èãðîêà
            Vector2 direction = (target.Center - Projectile.Center).SafeNormalize(Vector2.Zero);

            // Ïëàâíîå èçìåíåíèå íàïðàâëåíèÿ ñíàðÿäà
            float turnSpeed = 0.1f; // ×åì ìåíüøå çíà÷åíèå, òåì ìåäëåííåå ñíàðÿä áóäåò ïîâîðà÷èâàòü
            Projectile.velocity = Vector2.Lerp(Projectile.velocity, direction * Projectile.velocity.Length(), turnSpeed);
        }

        // Âðàùåíèå ñíàðÿäà
        Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

        // Ýôôåêò ïûëè
        if (Main.rand.NextBool(3)) // Ïûëü ïîÿâëÿåòñÿ ðåæå
        {
            Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, DustID.Electric, Projectile.velocity.X * 0.5f, Projectile.velocity.Y * 0.5f);
        }
    }
}
