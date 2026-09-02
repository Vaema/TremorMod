using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;

namespace TremorMod.Content.NPCs.ZombieEvent;


	public class Zombomber : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zombomber");
			Main.npcFrameCount[NPC.type] = 17;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 200;
			NPC.damage = 25;
			NPC.defense = 14;
			NPC.knockBackResist = 0.3f;
			NPC.width = 36;
			NPC.height = 44;
			AnimationType = NPCID.DD2GoblinBomberT1;
			NPC.aiStyle = NPCAIStyleID.DD2Fighter;
			NPC.npcSlots = 0.5f;
			AIType = NPCID.DD2GoblinBomberT1;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = Item.buyPrice(0, 0, 4, 7);
			// banner = npc.type;
			// TODO: bannerItem = mod.ItemType("ZombomberBanner");
		}	

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        if (Main.netMode != NetmodeID.MultiplayerClient)
        {
            int centerX = (int)(NPC.position.X + NPC.width / 2) / 16;
            int centerY = (int)(NPC.position.Y + NPC.height / 2) / 16;
            int halfLength = NPC.width / 2 / 16 + 1;
            npcLoot.Add(ItemDropRule.Common(ItemID.Harpoon, 5, 2, 3));
            npcLoot.Add(ItemDropRule.Common(ItemID.Grenade, 5, 2, 3));
        }
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
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ZombomberGore1").Type, 1f);
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ZombomberGore2").Type, 1f);
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ZombomberGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmGore3").Type, 1f);
			}
		}

	}