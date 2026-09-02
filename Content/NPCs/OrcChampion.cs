using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Utilities;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs;

	public class OrcChampion : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orc Champion");
			Main.npcFrameCount[NPC.type] = 20;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 500;
			NPC.damage = 25;
			NPC.defense = 32;
			NPC.knockBackResist = 0.1f;
			NPC.width = 40;
			NPC.height = 40;
			AnimationType = NPCID.GraniteGolem;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			AIType = NPCID.GraniteGolem;
			NPC.npcSlots = 0.8f;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.buffImmune[20] = true;
			NPC.buffImmune[24] = true;
			NPC.buffImmune[39] = true;
			NPC.buffImmune[31] = false;
			NPC.DeathSound = SoundID.NPCDeath27;
			NPC.value = Item.buyPrice(0, 0, 25, 0);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("OrcChampionBanner");
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 1.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 2.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OCGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OCGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OCGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OCGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OCGore4").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OCGore4").Type, 1f);

				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 1.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.6f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.005f : 0f;
	}