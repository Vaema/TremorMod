using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs.ZombieEvent;


	public class FarmerZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Farmer Zombie");
			Main.npcFrameCount[NPC.type] = 15;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 100;
			NPC.damage = 26;
			NPC.defense = 24;
			NPC.knockBackResist = 0.3f;
			NPC.width = 36;
			NPC.height = 44;
			AnimationType = NPCID.Skeleton;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			NPC.npcSlots = 0.5f;
			NPC.HitSound = SoundID.NPCHit2;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = Item.buyPrice(0, 0, 4, 7);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("FarmerZombieBanner");
		}

    /*public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        if (Main.netMode != 1)
        {
            int centerX = (int)(NPC.position.X + NPC.width / 2) / 16;
            int centerY = (int)(NPC.position.Y + NPC.height / 2) / 16;
            int halfLength = NPC.width / 2 / 16 + 1;
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Tomato>(), 1, 1, 2));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Potato>(), 1, 1, 2));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Carrot>(), 1, 1, 6));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Wheat>(), 1, 1, 6));
        }
    }*/

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmForkGore").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore3").Type, 1f);
			}
		}
	}