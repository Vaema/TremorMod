using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

public class PurplePulsePro : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 90;
        Projectile.height = 34;
        Projectile.hostile = true;
        Projectile.timeLeft = 300;  // Âðåìÿ æèçíè ñíàðÿäà
        Projectile.tileCollide = false;
    }

    public override void AI()
    {
        this.Projectile.rotation = this.Projectile.velocity.ToRotation();

        if (this.Projectile.localAI[0] == 0f)
        {
            Terraria.Audio.SoundEngine.PlaySound(SoundID.Item91, this.Projectile.position);
        }

        this.Projectile.localAI[0] += 1f;

        if (this.Projectile.localAI[0] > 3f)
        {
            int dustID = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.PurpleTorch);
            Main.dust[dustID].noGravity = true;
        }

        // Êîãäà âðåìÿ æèçíè ñíàðÿäà çàêàí÷èâàåòñÿ, ñîçäàåì ñíàðÿä âçðûâà
        if (Projectile.timeLeft <= 1)
        {
            Explode();  // Âûçîâ âçðûâà
        }
    }

    // Ñîçäàíèå ñíàðÿäà PurpleBoomPro (âçðûâ)
    private void Explode()
    {
        // Ñîçäàåì ñíàðÿä PurpleBoomPro íà ìåñòå òåêóùåãî ñíàðÿäà
        Projectile.NewProjectile(
            Projectile.GetSource_Death(),  // Èñòî÷íèê ñìåðòè
            Projectile.Center.X,  // Êîîðäèíàòû öåíòðà ñíàðÿäà
            Projectile.Center.Y,
            0f, 0f,  // Íà÷àëüíàÿ ñêîðîñòü (ñíàðÿä âçðûâàåòñÿ íà ìåñòå)
            ModContent.ProjectileType<PurpleBoomPro>(),  // Òèï ñíàðÿäà (âçðûâ)
            Projectile.damage,  // Óðîí âçðûâà
            0f,  // Ñèëà óäàðà
            Projectile.owner  // Âëàäåëåö ñíàðÿäà
        );
    }
}
