using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs;

	public class FlamingReaper : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flaming Reaper");
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 100;
			NPC.damage = 60;
			NPC.defense = 24;
			NPC.knockBackResist = 0f;
			NPC.width = 34;
			NPC.height = 34;
			AnimationType = NPCID.None;
			NPC.aiStyle = NPCAIStyleID.Flocko;
			NPC.noGravity = true;
			NPC.npcSlots = 15f;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath6;
			NPC.value = Item.buyPrice(0, 0, 0, 9);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;
        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Torch, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
			}
		}
	}