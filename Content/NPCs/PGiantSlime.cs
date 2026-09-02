using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Utilities;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;

namespace TremorMod.Content.NPCs;

	public class PGiantSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Purple Slime");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 700;
			NPC.damage = 100;
			NPC.defense = 30;
			NPC.knockBackResist = 0.3f;
			NPC.width = 70;
			NPC.alpha = 175;
			NPC.color = new Color(200, 0, 255, 150);
			NPC.height = 46;
			AnimationType = NPCID.RainbowSlime;
			NPC.aiStyle = NPCAIStyleID.Slime;
			AIType = NPCID.IlluminantSlime;
			NPC.npcSlots = 0.5f;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath23;
			NPC.value = Item.buyPrice(0, 0, 12, 15);
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ItemID.Gel, 1, 23, 23));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Purple, 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Purple, 0.7f);
				}
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Purple, 0.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Purple, 0.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Purple, 0.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Stone, 2.5f * hitDirection, -2.5f, 0, Color.Purple, 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> spawnInfo.SpawnTileY < Main.rockLayer && Main.hardMode && Helper.NoInvasion(spawnInfo) && NPC.downedMoonlord && Main.dayTime ? 0.02f : 0f;
	}