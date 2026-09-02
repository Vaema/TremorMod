using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using TremorMod.Content.Items.Materials;
using Terraria.GameContent.ItemDropRules;
using TremorMod.Content.Tiles;

namespace TremorMod.Content.NPCs;


	public class Astrofly : ModNPC
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Astrofly");
			Main.npcFrameCount[NPC.type] = 7;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 5000;
			NPC.damage = 160;
			NPC.defense = 115;
			NPC.knockBackResist = 0.2f;
			NPC.width = 56;
			NPC.height = 12;
			AnimationType = NPCID.RedDevil;
			NPC.aiStyle = NPCAIStyleID.HoveringFighter;
			NPC.npcSlots = 15f;
			NPC.noTileCollide = true;
			NPC.noGravity = true;
			NPC.HitSound = SoundID.NPCHit3;
			NPC.noGravity = true;
			NPC.DeathSound = SoundID.NPCDeath5;
			NPC.value = Item.buyPrice(0, 2, 4, 9);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("AstroflyBanner");
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
       npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CometiteOre>(), 1, 2, 5));
       npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ChargedCrystal>(), 1, 1, 3));
    }

    public override void HitEffect(NPC.HitInfo hit)
    {
        if (NPC.life <= 0) // Åñëè NPC óìèðàåò
        {
            for (int k = 0; k < 20; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Shadowflame, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
            }

            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("AstroflyGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("AstroflyGore1").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("AstroflyGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("AstroflyGore2").Type, 1f);
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("AstroflyGore3").Type, 1f);
        }
        else // Åñëè NPC íå óìèðàåò
        {
            int dustAmount = (int)(hit.Damage / (float)NPC.lifeMax * 50.0f); // Êîëè÷åñòâî ïûëè â çàâèñèìîñòè îò óðîíà
            for (int k = 0; k < dustAmount; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.BlueTorch, hit.HitDirection, -1f, 0, default(Color), 0.7f);
            }
        }
    }

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        // Ïðîâåðêà, íàõîäèòñÿ ëè êîîðäèíàòà â ïðåäåëàõ êàðòû
        if (spawnInfo.SpawnTileX < 0 || spawnInfo.SpawnTileX >= Main.maxTilesX ||
            spawnInfo.SpawnTileY < 0 || spawnInfo.SpawnTileY >= Main.maxTilesY)
        {
            return 0f;
        }

        // Ñïèñîê äîïóñòèìûõ òàéëîâ
        int[] cometTiles = [ModContent.TileType<CometiteOreTile>(), ModContent.TileType<HardCometiteOreTile>()];

        // Ïðîâåðÿåì íàëè÷èå òàéëà è äîïîëíèòåëüíûå óñëîâèÿ
        if (cometTiles.Contains(Main.tile[spawnInfo.SpawnTileX, spawnInfo.SpawnTileY].TileType) &&
            NPC.downedMoonlord && spawnInfo.SpawnTileY < Main.rockLayer)
        {
            return 15f;
        }

        return 0f;
    }
}