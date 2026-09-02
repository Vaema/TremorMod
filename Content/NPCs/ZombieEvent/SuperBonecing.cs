using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TremorMod.Content.NPCs.ZombieEvent;


	public class SuperBonecing : ModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bonecing");
			Main.npcFrameCount[NPC.type] = 3;
		}

		public override void SetDefaults()
		{
			NPC.lifeMax = 320;
			NPC.damage = 160;
			NPC.defense = 40;
			NPC.knockBackResist = 0.0f;
			NPC.width = 58;
			NPC.height = 44;
			AnimationType = NPCID.Derpling;
			AIType = NPCID.Derpling;
			NPC.aiStyle = NPCAIStyleID.Herpling;
			NPC.npcSlots = 0.2f;
			NPC.HitSound = SoundID.NPCHit2;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = Item.buyPrice(0, 0, 9, 9);
			// banner = npc.type;
			// Todo: bannerItem = mod.ItemType("BigCorpseBanner");
		}

		public override void AI()
		{
			if (!NPC.AnyNPCs(ModContent.NPCType<Cryptomage>()))
			{
				NPC.Transform(ModContent.NPCType<Bonecing>());
			}
		}
	}