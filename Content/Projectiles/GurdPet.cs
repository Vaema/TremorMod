using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Filters = Terraria.Graphics.Effects.Filters;

namespace TremorMod.Content.Projectiles;

	public class GurdPet : ModProjectile
	{
		public override void SetDefaults()
		{
        Main.projFrames[Projectile.type] = 8;
        Projectile.width = 46;
        Projectile.height = 38;
        Projectile.aiStyle = -1; // Óáèðàåì ñòàíäàðòíûé AI
        Projectile.friendly = true;
        Projectile.penetrate = -1; // Ïèòîìåö íå óíè÷òîæàåòñÿ
        Projectile.timeLeft = 2; // Ïîñòîÿííî îáíîâëÿåòñÿ
        Projectile.ignoreWater = false;
        Projectile.tileCollide = true; // Ïèòîìåö ìîæåò ñòàëêèâàòüñÿ ñ ïëèòêàìè
    }

    public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Gurd Pet");
        Main.projPet[Projectile.type] = true; // Ïîìåòêà êàê ïèòîìöà
		}

    public override void AI()
    {
        Player player = Main.player[Projectile.owner];

        // Ïðîâåðÿåì, æèâ ëè èãðîê
        if (player.dead || !player.active)
        {
            player.ClearBuff(ModContent.BuffType<Buffs.GurdPetBuff>());
        }

        // Ïðîâåðÿåì, åñòü ëè áàôô ïèòîìöà
        if (player.HasBuff(ModContent.BuffType<Buffs.GurdPetBuff>()))
        {
            Projectile.timeLeft = 2; // Ïîääåðæèâàåì ñóùåñòâîâàíèå
        }

        // Ïðèâÿçêà ê èãðîêó
        Vector2 playerPosition = player.Center + new Vector2(-50f, 0f); // Ñìåùåíèå îòíîñèòåëüíî èãðîêà
        float distanceToPlayer = Vector2.Distance(Projectile.Center, playerPosition);

        if (distanceToPlayer > 1000f) // Åñëè ïèòîìåö ñëèøêîì äàëåêî, òåëåïîðòèðóåì åãî
        {
            Projectile.Center = playerPosition;
        }

        // Õîäüáà ïî ïëèòêàì
        float speed = 2f; // Ñêîðîñòü äâèæåíèÿ
        float inertia = 20f;

        if (Projectile.Center.X < player.Center.X - 60f) // Èäòè âïðàâî
        {
            Projectile.velocity.X = (Projectile.velocity.X * (inertia - 1) + speed) / inertia;
        }
        else if (Projectile.Center.X > player.Center.X + 60f) // Èäòè âëåâî
        {
            Projectile.velocity.X = (Projectile.velocity.X * (inertia - 1) - speed) / inertia;
        }
        else // Åñëè ðÿäîì ñ èãðîêîì, çàìåäëÿåìñÿ
        {
            Projectile.velocity.X *= 0.9f;
        }

        // Ïðîâåðêà íà çåìëþ
        Point tileBelowPosition = (Projectile.Bottom / 16).ToPoint() + new Point(0, 1); // Êîîðäèíàòû ïëèòêè ïîä ïèòîìöåì
        Tile tileBelow = Framing.GetTileSafely(tileBelowPosition.X, tileBelowPosition.Y);

        if (Projectile.velocity.Y == 0f) // Åñëè íà çåìëå
        {
            if (!tileBelow.HasTile || !Main.tileSolid[tileBelow.TileType]) // Åñëè ïëèòêè íåò, ïàäàåì
            {
                Projectile.velocity.Y += 0.4f;
            }
        }
        else // Åñëè â âîçäóõå, óñêîðÿåì ïàäåíèå
        {
            Projectile.velocity.Y += 0.4f;
        }

        // Îãðàíè÷åíèå âåðòèêàëüíîé ñêîðîñòè
        if (Projectile.velocity.Y > 10f)
        {
            Projectile.velocity.Y = 10f;
        }

        // Óñòàíàâëèâàåì íàïðàâëåíèå ïèòîìöà
        Projectile.spriteDirection = Projectile.velocity.X > 0 ? 1 : -1;

        // Àíèìàöèÿ
        if (Projectile.velocity.X != 0)
        {
            Projectile.frameCounter++;
            if (Projectile.frameCounter >= 8) // Ñêîðîñòü ñìåíû êàäðîâ
            {
                Projectile.frameCounter = 0;
                Projectile.frame = (Projectile.frame + 1) % Main.projFrames[Projectile.type];
            }
        }
        else
        {
            Projectile.frame = 0; // Åñëè ñòîèò, ïîêàçûâàåì ïåðâûé êàäð
        }
    }
}
