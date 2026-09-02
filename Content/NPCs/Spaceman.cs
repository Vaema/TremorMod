using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;

namespace TremorMod.Content.NPCs;

	public class Spaceman : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Spaceman");
			Main.npcFrameCount[NPC.type] = 15;
		}

		public override void SetDefaults()
		{
			NPC.width = 30;
			NPC.height = 52;
			NPC.damage = 22;
			NPC.defense = 12;
			NPC.lifeMax = 200;
			NPC.HitSound = SoundID.NPCHit48;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = Item.buyPrice(0, 0, 3, 12);
			NPC.knockBackResist = 0.3f;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			AIType = NPCID.GoblinScout;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			AnimationType = NPCID.AngryBones;
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("SpacemanBanner");
		}

		public override void AI()
		{
			if (Utils.NextBool(Main.rand, 1000))
				SoundEngine.PlaySound(SoundID.DrumTamaSnare, NPC.position);
			if (Utils.NextBool(Main.rand, 1000))
				SoundEngine.PlaySound(SoundID.DrumFloorTom, NPC.position);
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ItemID.Meteorite, 6));
        npcLoot.Add(ItemDropRule.Common(ItemID.MeteoriteBar, 6, 1, 3));
        npcLoot.Add(ItemDropRule.Common(ItemID.SpaceGun, 46));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);


            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("SpaceManGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("SpaceManGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("SpaceManGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("SpaceManGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("SpaceManGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("SpaceManGore4").Type, 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && spawnInfo.Player.ZoneMeteor && Main.dayTime ? 0.03f : 0f;
	}
