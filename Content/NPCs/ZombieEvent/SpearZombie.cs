using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs.ZombieEvent;


	public class SpearZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zombie Spearman");
			Main.npcFrameCount[NPC.type] = 15;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 150;
			NPC.damage = 36;
			NPC.defense = 24;
			NPC.knockBackResist = 0.3f;
			NPC.width = 36;
			NPC.height = 44;
			AnimationType = NPCID.Skeleton;
			NPC.aiStyle = NPCAIStyleID.Unicorn;
			NPC.npcSlots = 0.5f;
			NPC.HitSound = SoundID.NPCHit2;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = Item.buyPrice(0, 0, 4, 7);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("SpearZombieBanner");
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ZombieSpearHead").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("DeadlingArm").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("DeadlingArm").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("DeadlingLeg").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("DeadlingLeg").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ZombieSpearGore").Type, 1f);
			}
		}

	}