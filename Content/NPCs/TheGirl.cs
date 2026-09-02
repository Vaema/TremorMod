using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.Items.Placeable.Banners;

namespace TremorMod.Content.NPCs;

	public class TheGirl : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Girl");
			Main.npcFrameCount[NPC.type] = 9;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 3000;
			NPC.damage = 175;
			NPC.defense = 48;
			NPC.knockBackResist = 0.3f;
			NPC.width = 34;
			NPC.height = 54;
			AnimationType = NPCID.DesertLamiaDark;
			NPC.aiStyle = NPCAIStyleID.Fighter;
			NPC.npcSlots = 0.5f;
			NPC.HitSound = SoundID.NPCHit1;
			AIType = NPCID.DesertLamiaDark;
			NPC.DeathSound = SoundID.NPCDeath52;
			NPC.value = Item.buyPrice(0, 3, 1, 0);
        Banner = NPC.type;
        BannerItem = ModContent.ItemType<TheGirlBanner>();
        ItemID.Sets.KillsToBanner[BannerItem] = 50;
    }

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrokenHeroArmorplate>(), 5));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 60; k++)
				{
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}

				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Wraith, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        => spawnInfo.SpawnTileY < Main.rockLayer && NPC.downedMoonlord && Main.eclipse ? 0.20f : 0f;
}