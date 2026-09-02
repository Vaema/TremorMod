using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content;
using TremorMod;
using TremorMod.Content.Buffs;

namespace TremorMod.Content.Projectiles.Minions;

public class CyberStaffPro : ModProjectile
{
    public override void SetDefaults()
    {
        // Èñïîëüçóåì ïàðàìåòðû ñòàíäàðòíîãî ñíàðÿäà (íàïðèìåð, 533 - ýòî òèï ñíàðÿäà ìèíüîíà)
        Projectile.CloneDefaults(533);
        Projectile.aiStyle = 533;
        Projectile.width = 50;
        Projectile.height = 50;
        Main.projFrames[Projectile.type] = 1;
        Projectile.friendly = true;
        Projectile.damage = 60; // Íàñòðàèâàåì óðîí
        Projectile.minion = true; // Óêàçûâàåì, ÷òî ýòî ìèíüîí
        Projectile.minionSlots = 1; // Êîëè÷åñòâî ñëîòîâ äëÿ ìèíüîíîâ, êîòîðûå ìîæåò èìåòü èãðîê
        Projectile.penetrate = -1; // Ìèíüîí ìîæåò ïðîáèâàòü äî áåñêîíå÷íîñòè (ïî ñóòè ýòî "íåóáèâàåìûé" îáúåêò)
        Projectile.timeLeft = 18000; // Âðåìÿ æèçíè ìèíüîíà
        Projectile.ignoreWater = true;
        Projectile.tileCollide = false; // Ìèíüîí íå ñòàëêèâàåòñÿ ñ ïëèòêàìè
        ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true; // Âêëþ÷àåì âîçìîæíîñòü äëÿ ìèíüîíà àòàêîâàòü öåëè
    }

    public override void SetStaticDefaults()
    {
       // DisplayName.SetDefault("CyberStaffPro");
        //Main.projPet[Projectile.type] = true; // Ïîìåòêà êàê ïèòîìöà
    }

    public override bool OnTileCollide(Vector2 oldVelocity)
    {
        // Ïðè ñòîëêíîâåíèè ñ ïëèòêàìè, ñîõðàíÿåì ïðåæíþþ ñêîðîñòü
        if (Projectile.velocity.X != oldVelocity.X)
        {
            Projectile.velocity.X = oldVelocity.X;
        }
        if (Projectile.velocity.Y != oldVelocity.Y)
        {
            Projectile.velocity.Y = oldVelocity.Y;
        }
        return false; // Íå óíè÷òîæàåì ìèíüîíà ïðè ñòîëêíîâåíèè ñ ïëèòêàìè
    }

    public override void AI()
    {
        Player player = Main.player[Projectile.owner];

        // Ïðîâåðêà, àêòèâåí ëè ïèòîìåö
        if (!player.active || player.dead || !player.HasBuff(ModContent.BuffType<CyberSawBuff>()))
        {
            Projectile.Kill();
            return;
        }

        // Ïðèâÿçêà ê èãðîêó
        Vector2 targetPosition = player.Center + new Vector2(0f, -48f);
        float speed = 10f;
        Vector2 direction = targetPosition - Projectile.Center;
        float distance = direction.Length();

        if (distance > 2000f) // Åñëè ïèòîìåö ñëèøêîì äàëåêî, òåëåïîðòèðóåì
        {
            Projectile.Center = player.Center;
        }
        else if (distance > 10f)
        {
            direction.Normalize();
            direction *= speed;
            Projectile.velocity = (Projectile.velocity * 20f + direction) / 21f;
        }
        else
        {
            Projectile.velocity *= 0.95f; // Çàìåäëåíèå
        }

        Projectile.rotation += 0.1f; // Ýôôåêò âðàùåíèÿ

        // Àòàêà âðàãîâ
        NPC target = FindTarget();
        if (target != null)
        {
            Vector2 attackDirection = target.Center - Projectile.Center;
            attackDirection.Normalize();
            attackDirection *= speed;
            Projectile.velocity = (Projectile.velocity * 10f + attackDirection) / 11f;

            // Ïðîâåðÿåì ðàññòîÿíèå äî öåëè
            if (Vector2.Distance(Projectile.Center, target.Center) < 50f)
            {
                int damage = Projectile.damage; // Óðîí ïèòîìöà
                //float knockBack = 2f; // Îòáðàñûâàíèå
                //bool crit = Main.rand.Next(100) < player.meleeCrit; // Êðèòè÷åñêèé óäàð
                //target.StrikeNPC(damage, knockBack, Projectile.direction, crit); // Íàíîñèì óðîí
            }
        }
    }
    private NPC FindTarget()
    {
        NPC closestNPC = null;
        float closestDistance = 500f; // Ðàäèóñ ïîèñêà âðàãîâ

        foreach (NPC npc in Main.npc)
        {
            if (npc.CanBeChasedBy(this) && Vector2.Distance(Projectile.Center, npc.Center) < closestDistance)
            {
                closestNPC = npc;
                closestDistance = Vector2.Distance(Projectile.Center, npc.Center);
            }
        }

        return closestNPC;
    }
}