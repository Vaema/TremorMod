using Microsoft.Xna.Framework;
using Terraria;

namespace TremorMod.Content.NPCs.Bosses;

	public class HeaterOfWorldsTail : HeaterofWorldsPart
	{
		public override void SetDefaults()
		{
			base.SetDefaults();
			NPC.width = 30;
			NPC.height = 62;	
		}

		public override void AI()
		{
			CheckSegments();
		}

		public override bool CheckActive()
		{
			return false;
		}

		public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
		{
			return false;
		}
	}