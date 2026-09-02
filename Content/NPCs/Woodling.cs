using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Utilities;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;

namespace TremorMod.Content.NPCs;

	public class Woodling : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Woodling");
			Main.npcFrameCount[NPC.type] = 10;
		}
		
		public override void SetDefaults()
		{
			NPC.lifeMax = 90;
			NPC.damage = 14;
			NPC.defense = 9;
			NPC.knockBackResist = 0.3f;
			NPC.width = 56;
			NPC.height = 48;
			AIType = NPCID.VortexSoldier;
			AnimationType = NPCID.VortexSoldier;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			NPC.npcSlots = 0.2f;
			NPC.HitSound = SoundID.NPCHit37;
			NPC.DeathSound = SoundID.NPCDeath57;
			NPC.value = Item.buyPrice(0, 0, 6, 9);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("WoodlingBanner");
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ItemID.Wood, 1, 1, 6));
    }


    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.GreenFairy, 2.5f * hitDirection, -2.5f, 0, default(Color), 1f);

            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("WoodlingGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("WoodlingGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("WoodlingGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("WoodlingGore3").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("WoodlingGore3").Type, 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && NPC.downedBoss1 && Helper.NoZoneAllowWater(spawnInfo) && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.002f : 0f;
	}