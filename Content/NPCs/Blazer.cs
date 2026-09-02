using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using TremorMod.Content.Items.Placeable.Banners;

namespace TremorMod.Content.NPCs;

	public class Blazer : ModNPC
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Blazer");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 350;
			NPC.damage = 100;
			NPC.defense = 12;
			NPC.knockBackResist = 0.5f;
			NPC.width = 40;
			NPC.height = 40;
			AnimationType = NPCID.Slimer;
			NPC.aiStyle = NPCAIStyleID.Bat;
			NPC.noGravity = true;
			NPC.npcSlots = 1f;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = Item.buyPrice(0, 0, 10, 0);
			Banner = NPC.type;
			BannerItem = ModContent.ItemType<BlazerBanner>();
        ItemID.Sets.KillsToBanner[BannerItem] = 50; // 50 óáèéñòâ äëÿ áàííåðà
    }

		public override void HitEffect(NPC.HitInfo hit)
    {
        if (NPC.life <= 0)
        {
            for (int k = 0; k < 20; k++)
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Torch, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

            if (Main.netMode != NetmodeID.MultiplayerClient)
                NPC.NewNPC(NPC.GetSource_Death(), (int)NPC.position.X, (int)NPC.position.Y - 48, NPCID.LavaSlime);
        }
    }

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        return (spawnInfo.Player.ZoneUnderworldHeight && Main.hardMode && spawnInfo.SpawnTileY > Main.maxTilesY - 200) ? 0.05f : 0f;
    }
}