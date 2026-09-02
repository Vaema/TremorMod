using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs.Bosses.Jellyfish;

	public class FlyingJelly : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flying Jelly");
			Main.npcFrameCount[NPC.type] = 6;
		}

		public override void SetDefaults()
		{
			NPC.width = 30;
			NPC.height = 30;
			NPC.damage = 28;
			NPC.defense = 10;
			NPC.lifeMax = 125;
			NPC.HitSound = SoundID.NPCHit25;
			NPC.DeathSound = SoundID.NPCDeath28;
			NPC.knockBackResist = 0.1f;
			AIType = NPCID.ShadowFlameApparition;
			NPC.noGravity = true;
			NPC.aiStyle = NPCAIStyleID.AncientVision;
			AnimationType = NPCID.ShadowFlameApparition;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;
        if (NPC.life <= 0)
			{
				for (int k = 0; k < 60; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
			}
			else
			{
				for (int k = 0; k < hit.Damage / NPC.lifeMax * 50; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, hitDirection, -2f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Shadowflame, hitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}
	}