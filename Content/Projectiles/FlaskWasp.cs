using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

public class FlaskWasp : ModProjectile
{
    public override void SetStaticDefaults()
    {
        Main.projFrames[Projectile.type] = 3; // Óñòàíàâëèâàåì êîëè÷åñòâî êàäðîâ àíèìàöèè
    }

    public override void SetDefaults()
    {
        Projectile.netImportant = true;
        Projectile.CloneDefaults(388); // Êëîíèðóåì ïîâåäåíèå ñíàðÿäà ID 388 (Hornet)
        AIType = ProjectileID.Spazmamini; // Èñïîëüçóåì òó æå ëîãèêó AI
        Projectile.width = 40;
        Projectile.height = 36;
        Projectile.friendly = true;
        Projectile.penetrate = 1;
        Projectile.timeLeft = 600;
        Projectile.ignoreWater = true;
        Projectile.tileCollide = false;
    }

    public override Color? GetAlpha(Color lightColor)
    {
        return Color.White;
    }

    public void OnHitNPC(NPC target, int damage, float knockback, bool crit)
    {
        target.AddBuff(BuffID.Poisoned, 80); // Íàêëàäûâàåì ýôôåêò "Poisoned" íà 80 òèêîâ
    }

    public override void AI()
    {
        Projectile.spriteDirection = Projectile.direction; // Íàïðàâëåíèå ñïðàéòà ñîîòâåòñòâóåò äâèæåíèþ
        Projectile.rotation = 0f; // Ñíàðÿä íå âðàùàåòñÿ
    }

    public override bool OnTileCollide(Vector2 oldVelocity)
    {
        if (Projectile.velocity.X != oldVelocity.X)
        {
            Projectile.velocity.X = oldVelocity.X; // Ñîõðàíÿåì ñòàðóþ ñêîðîñòü ïî X
        }
        if (Projectile.velocity.Y != oldVelocity.Y)
        {
            Projectile.velocity.Y = oldVelocity.Y; // Ñîõðàíÿåì ñòàðóþ ñêîðîñòü ïî Y
        }
        return false; // Ñíàðÿä íå óíè÷òîæàåòñÿ ïðè ñòîëêíîâåíèè ñ ïëèòîé
    }
}