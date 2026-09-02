using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs;

	public class MagiumFlyer : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magium Flyer");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 100;
			NPC.damage = 30;
			NPC.defense = 20;
			NPC.knockBackResist = 0.0f;
			NPC.width = 34;
			NPC.height = 48;
			AnimationType = NPCID.GiantBat;
			NPC.aiStyle = NPCAIStyleID.Bat;
			NPC.npcSlots = 1f;
			NPC.noTileCollide = true;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.noGravity = true;
			NPC.DeathSound = SoundID.NPCDeath4;
			NPC.value = Item.buyPrice(0, 0, 6, 9);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("MagiumFlayerBanner");
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 60; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
			}
			else
			{
				for (int k = 0; k < hit.Damage / NPC.lifeMax * 50.0; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hitDirection, -2f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hitDirection, -2f, 0, default(Color), 0.7f);
				}
			}
		}
	}