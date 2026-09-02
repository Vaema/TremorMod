using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;


namespace TremorMod.Content.Projectiles;

public class LightningOrb : ModProjectile
{
    private const int NormalFrameCount = 4;
    private int hitCount = 0; // Ñ÷åò÷èê óäàðîâ

    public override void SetDefaults()
    {
        Projectile.width = 32;
        Projectile.height = 32;
        Projectile.friendly = false;
        Projectile.hostile = true;
        Projectile.tileCollide = false;
        Projectile.penetrate = -1;
        Projectile.timeLeft = 180; // Èñ÷åçàåò ÷åðåç 3 ñåêóíäû (60 êàäðîâ = 1 ñåêóíäà)
        Projectile.light = 1f;
        Projectile.aiStyle = -1; // Ïîëüçîâàòåëüñêàÿ ëîãèêà AI
    }

    public override void AI()
    {
        // Îáíîâëåíèå àíèìàöèè ñíàðÿäà
        int totalFrames = 4; // Êîëè÷åñòâî êàäðîâ
        //int frameHeight = 99; // Âûñîòà îäíîãî êàäðà
        //int frameWidth = 99; // Øèðèíà îäíîãî êàäðà

        // Ñ÷¸ò÷èê êàäðîâ
        Projectile.frameCounter++;

        // Ñìåíèòü êàäð ïîñëå îïðåäåë¸ííîãî âðåìåíè
        if (Projectile.frameCounter >= 6) // Ñêîðîñòü àíèìàöèè, ÷åì áîëüøå ÷èñëî, òåì ìåäëåííåå
        {
            Projectile.frameCounter = 0;
            Projectile.frame++;

            if (Projectile.frame >= totalFrames) // Ïåðåõîä ê ïåðâîìó êàäðó ïîñëå ïîñëåäíåãî
            {
                Projectile.frame = 0;
            }
        }
        // Íàöåëèâàíèå íà áëèæàéøåãî èãðîêà
        Player targetPlayer = Main.player[Player.FindClosest(Projectile.Center, 0, 0)];
        if (targetPlayer != null && !targetPlayer.dead)
        {
            Vector2 direction = Vector2.Normalize(targetPlayer.Center - Projectile.Center);
            Projectile.velocity = direction * 10f; // Ñêîðîñòü ìîëíèè

            // Ñîçäàíèå âèçóàëüíûõ ýôôåêòîâ
            if (Main.rand.NextBool(3))
            {
                int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Electric, 0f, 0f, 100, default, 1.5f);
                Main.dust[dust].noGravity = true;
            }
        }

        // Ïðîâåðÿåì, ñêîëüêî ðàç ñíàðÿä íàíåñ óäàð
        if (hitCount >= 5)
        {
            Projectile.Kill(); // Ñíàðÿä èñ÷åçàåò ïîñëå 5 óäàðîâ
        }
    }

    public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
    {
        hitCount++; // Óâåëè÷èâàåì ñ÷åò÷èê ïðè óäàðå ïî èãðîêó
    }
    public override void OnKill(int timeLeft)
    {
        for (int i = 0; i < 10; i++)
        {
            int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Electric, 0f, 0f, 100, default, 1.5f);
            Main.dust[dust].noGravity = true;
        }
    }


    public override bool PreDraw(ref Color lightColor)
    {
        // Ïîëó÷àåì òåêñòóðó ñíàðÿäà
        Texture2D texture = ModContent.Request<Texture2D>("TremorMod/Content/Projectiles/LightningOrb").Value;
        // Ðèñóåì ñíàðÿä ñ àíèìàöèåé
        Rectangle frameRectangle = new Rectangle(0, Projectile.frame * 99, 99, 99);
        Vector2 position = Projectile.Center - Main.screenPosition;

        Main.spriteBatch.Draw(texture, position, frameRectangle, lightColor);

        return false; // Âîçâðàùàåì false, ÷òîáû ñòàíäàðòíûé ìåòîä ðèñîâàíèÿ íå âûçûâàëñÿ
    }
}