using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.Projectiles;

	public class LivingTombstonePro : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(198);
			AIType = ProjectileID.BabyHornet;
			Main.projFrames[Projectile.type] = 4;
			Projectile.width = 24;
			Projectile.height = 36;
			Main.projPet[Projectile.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Living Tombstone");
		}

		public override bool PreAI()
		{
			Player player = Main.player[Projectile.owner];
			player.bunny = false; // Relic from aiType
			return true;
		}
	}
