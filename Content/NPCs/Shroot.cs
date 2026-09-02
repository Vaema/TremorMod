using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Utilities;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;
using TremorMod.Content.Items.Materials;

namespace TremorMod.Content.NPCs;

	public class Shroot : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shroot");
			Main.npcFrameCount[NPC.type] = 3;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 275;
			NPC.damage = 28;
			NPC.defense = 34;
			NPC.knockBackResist = 0.3f;
			NPC.width = 130;
			NPC.height = 140;
			AnimationType = NPCID.ToxicSludge;
			NPC.aiStyle = NPCAIStyleID.Slime;
			NPC.npcSlots = 1f;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath17;
			NPC.scale = 0.7f;
			NPC.value = Item.buyPrice(0, 0, 1, 24);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("ShrootBanner");
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Gloomstone>(), 2, 6, 16));
        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RockHorn>(), 2, 1, 3));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 60; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ShnootGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ShnootGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ShnootGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ShnootGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ShnootGore2").Type, 1f);
			}
			else
			{
				for (int k = 0; k < hit.Damage / NPC.lifeMax * 50; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.SpawnTileY > Main.rockLayer ? 0.003f : 0f;
	}