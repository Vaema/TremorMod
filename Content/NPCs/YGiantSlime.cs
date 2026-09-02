using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;

namespace TremorMod.Content.NPCs;

	public class YGiantSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Yellow Slime");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 1800;
			NPC.damage = 100;
			NPC.defense = 32;
			NPC.knockBackResist = 0.3f;
			NPC.width = 70;
			NPC.alpha = 175;
			NPC.color = new Color(255, 255, 0, 100);
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
        npcLoot.Add(ItemDropRule.Common(ItemID.Gel, 1, 1, 4));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Yellow, 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Yellow, 0.7f);
				}

				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Yellow, 0.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Yellow, 0.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Yellow, 0.7f);
				Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.TintableDust, 2.5f * hitDirection, -2.5f, 0, Color.Yellow, 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && NPC.downedMoonlord && !spawnInfo.Player.ZoneDungeon && spawnInfo.SpawnTileY > Main.rockLayer ? 0.1f : 0f;
	}