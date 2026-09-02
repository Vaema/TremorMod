using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;


	public class CrystalChainmerPro : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 22;
			Projectile.height = 22;
			Projectile.aiStyle = ProjAIStyleID.Drill;
			Projectile.friendly = true;
			Projectile.penetrate = -1;
			Projectile.tileCollide = false;
			Projectile.hide = true;
			Projectile.ownerHitCheck = true;
			Projectile.DamageType = DamageClass.Melee;
		}

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Chainmer");

		}*/

		public override void AI()
		{
			int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.UndergroundHallowedEnemies, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 100, default(Color), 1.9f);
			Main.dust[dust].noGravity = true;
		}

		public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
		{
			if (Utils.NextBool(Main.rand, 10))
			{
				target.AddBuff(BuffID.OnFire, 60); // Ïðèìåíÿåò ýôôåêò "Ãîðåíèå" íà 60 êàäðîâ.
			}
		}

    public override void OnHitPlayer(Player target, Player.HurtInfo info)
    {
        if (info.PvP && Main.rand.NextBool(2))
        {
            target.AddBuff(BuffID.OnFire, 60); 
        }
    }
}
