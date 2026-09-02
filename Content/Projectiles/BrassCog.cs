using Terraria;
using Terraria.ModLoader;


namespace TremorMod.Content.Projectiles;

	public class BrassCog : ModProjectile
	{
		public override void SetDefaults()
		{
        Projectile.CloneDefaults(1);  // Èñïîëüçóåò ïàðàìåòðû ñòàíäàðòíîãî ñíàðÿäà (íàïðèìåð, äëÿ ñòðåë)
        Projectile.aiStyle = 1;
    }

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BrassCog");

		}*/

	}
