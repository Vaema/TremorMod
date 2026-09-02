using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Utilities;
using Microsoft.Xna.Framework;

namespace TremorMod.Content.NPCs;

	public class JungleSpirit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Jungle Spirit");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 140;
			NPC.damage = 15;
			NPC.defense = 14;
			NPC.knockBackResist = 0.3f;
			NPC.width = 34;
			NPC.height = 48;
			AnimationType = NPCID.Ghost;
			NPC.aiStyle = NPCAIStyleID.HoveringFighter;
			NPC.npcSlots = 0.4f;
			NPC.noTileCollide = true;
			NPC.HitSound = SoundID.NPCHit44;
			NPC.noGravity = true;
			NPC.DeathSound = SoundID.NPCDeath58;
			NPC.value = Item.buyPrice(0, 0, 4, 15);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("JungleSpiritBanner");
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("JungleSpiritGore").Type, 1f);
        }
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo)) && spawnInfo.Player.ZoneJungle && spawnInfo.SpawnTileY > Main.rockLayer ? 0.005f : 0f;
	}

