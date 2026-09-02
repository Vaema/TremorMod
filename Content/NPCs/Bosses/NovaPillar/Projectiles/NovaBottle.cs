using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.NPCs.Bosses.NovaPillar.Projectiles;

	public class NovaBottle : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Nova Flask");
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 2;
		}
		public override void SetDefaults()
		{
			Projectile.width = 18;
			Projectile.height = 28;
			Projectile.aiStyle = ProjAIStyleID.ThrownProjectile;
			Projectile.timeLeft = 1200;
			Projectile.hostile = true;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

    public override void OnKill(int timeLeft)
    {
        SoundEngine.PlaySound(SoundID.Item107, Projectile.position);
        Gore.NewGore(Projectile.GetSource_FromThis(), Projectile.position, -Projectile.oldVelocity * 0.2f, 704, 1f);
        Gore.NewGore(Projectile.GetSource_FromThis(), Projectile.position, -Projectile.oldVelocity * 0.2f, 705, 1f);
        Gore.NewGore(Projectile.GetSource_FromThis(), Projectile.position, -Projectile.oldVelocity * 0.2f, 705, 1f);

        if (Projectile.owner == Main.myPlayer)
        {
            int num220 = Main.rand.Next(5, 8);
            for (int num221 = 0; num221 < num220; num221++)
            {
                Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
                value17.Normalize();
                value17 *= Main.rand.Next(10, 201) * 0.01f;

                int k = Projectile.NewProjectile(
                    Projectile.GetSource_FromThis(),
                    Projectile.position, // Ïîçèöèÿ
                    value17,             // Ñêîðîñòü
                    ModContent.ProjectileType<NovaFlask_Proj>(),
                    Projectile.damage,
                    1f,
                    Projectile.owner,
                    0f,
                    Main.rand.Next(-45, 1)
                );

                Main.projectile[k].friendly = false;
            }
        }
    }


    public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			Projectile.Kill();
		}
	}