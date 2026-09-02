using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using TremorMod.Content.Items.Placeable.Banners;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs;

	public class Parasprite : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Parasprite");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 30;
			NPC.damage = 7;
			NPC.defense = 2;
			NPC.knockBackResist = 0.3f;
			NPC.width = 34;
			NPC.height = 48;
			AnimationType = NPCID.Pixie;
			NPC.aiStyle = NPCAIStyleID.Bat;
			NPC.npcSlots = 0.5f;
			NPC.HitSound = SoundID.NPCHit35;
			NPC.noGravity = true;
			NPC.DeathSound = SoundID.NPCDeath57;
        Banner = NPC.type;
        BannerItem = ModContent.ItemType<ParaspriteBanner>();
        ItemID.Sets.KillsToBanner[BannerItem] = 50;
    }

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ParaspriteGore").Type, 1f);
        }
			else
			{
				for (int k = 0; k < hit.Damage / NPC.lifeMax * 50; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hitDirection, -1f, 0, default(Color), 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> (Helper.NoZoneAllowWater(spawnInfo)) && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}