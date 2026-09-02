using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

public class PurpleBoomPro : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 90;  // Ðàçìåð âçðûâà
        Projectile.height = 34;
        Projectile.hostile = true;  // Âðàæäåáíûé
        Projectile.timeLeft = 7;  // Óâåëè÷èâàåì âðåìÿ æèçíè (íàïðèìåð, 60 êàäðîâ = 1 ñåêóíäà)
        Projectile.penetrate = -1;  // Áåñêîíå÷íîå ïðîíèêíîâåíèå
        Projectile.light = 1f;  // ßðêîå îñâåùåíèå
        Projectile.ignoreWater = true;
        Projectile.tileCollide = true;  // Íå âçàèìîäåéñòâóåò ñ áëîêàìè
    }

    public override void AI()
    {
        // Ñîçäàíèå ýôôåêòîâ
        for (int i = 0; i < 30; i++)
        {
            int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.PurpleCrystalShard, Main.rand.Next(-5, 6), Main.rand.Next(-5, 6), 150, default, 1.8f);
            Main.dust[dust].noGravity = true;  // Ïûëü áåç ãðàâèòàöèè
        }

        Terraria.Audio.SoundEngine.PlaySound(SoundID.Item14, Projectile.position);  // Çâóê âçðûâà

        // Óìåíüøàåì âðåìÿ æèçíè ñíàðÿäà, åñëè íåîáõîäèìî
        if (Projectile.timeLeft <= 1)
        {
            // Ñíàðÿä èñ÷åçíåò ïîñëå âñåõ ýôôåêòîâ
            Projectile.Kill();
        }
    }
}