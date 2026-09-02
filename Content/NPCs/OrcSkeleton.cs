using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using TremorMod.Content.Items.Placeable.Banners;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs;

	public class OrcSkeleton : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orc Skeleton");
			Main.npcFrameCount[NPC.type] = 20;
		}

		public override void SetDefaults()
		{
			AIType = NPCID.ArmoredSkeleton;
			NPC.lifeMax = 150;
			NPC.damage = 30;
			NPC.defense = 10;
			NPC.knockBackResist = 0.3f;
			NPC.width = 36;
			NPC.height = 44;
			AnimationType = NPCID.GraniteGolem;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			NPC.npcSlots = 0.6f;
			NPC.HitSound = SoundID.NPCHit4;
			NPC.DeathSound = SoundID.NPCDeath6;
			NPC.value = Item.buyPrice(0, 0, 6, 9);
        Banner = NPC.type;
        BannerItem = ModContent.ItemType<OrcSkeletonBanner>();
        ItemID.Sets.KillsToBanner[BannerItem] = 50;
    }

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OrcSkeletonGore1").Type, 1f);
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OrcSkeletonGore2").Type, 1f);
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OrcSkeletonGore2").Type, 1f);
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OrcSkeletonGore3").Type, 1f);
            //Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("OrcSkeletonGore3").Type, 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && NPC.downedBoss1 && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}