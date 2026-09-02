using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using TremorMod.Content.Items.Placeable.Banners;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs;

	public class GhostKnight : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ghost Knight");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 500;
			NPC.damage = 80;
			NPC.defense = 26;
			NPC.knockBackResist = 0.6f;
			NPC.width = 38;
			NPC.height = 44;
			AnimationType = NPCID.Wraith;
			NPC.noGravity = true;
			NPC.noTileCollide = true;
			NPC.aiStyle = NPCAIStyleID.HoveringFighter;
			AIType = NPCID.Wraith;
			NPC.npcSlots = 1f;
			NPC.HitSound = SoundID.NPCHit54;
			NPC.DeathSound = SoundID.NPCDeath52;
			NPC.value = Item.buyPrice(0, 0, 8, 0);
        Banner = NPC.type;
        BannerItem = ModContent.ItemType<GhostKnightBanner>();
        ItemID.Sets.KillsToBanner[BannerItem] = 50;
    }

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 60; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for(int i = 0; i < 2; ++i)
					Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("IBGore1").Type, 1f);
					Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("IBGore2").Type, 1f);
        }
			else
			{
				for (int k = 0; k < hit.Damage / NPC.lifeMax * 50; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, hitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && NPC.downedPlantBoss && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.01f : 0f;
	}