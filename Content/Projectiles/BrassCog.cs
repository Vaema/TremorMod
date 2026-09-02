using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TremorMod.Content.Projectiles;

	public class BrassCog : ModProjectile
	{
		public override void SetDefaults()
		{
        Projectile.CloneDefaults(1);  // Èñïîëüçóåò ïàðàìåòðû ñòàíäàðòíîãî ñíàðÿäà (íàïðèìåð, äëÿ ñòðåë)
        Projectile.aiStyle = ProjAIStyleID.Arrow;
    }

		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BrassCog");

		}*/

	}
