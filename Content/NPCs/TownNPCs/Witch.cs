using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using TremorMod.Content.Items.Placeable;
using TremorMod.Content.Items.Vanity;
using TremorMod.Content.Items.Weapons.Magic;
using TremorMod.Content.Items.Weapons.Melee;
using TremorMod.Content.Items.Weapons.Throwing;
using TremorMod.Content.Projectiles;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class Witch : ModNPC
	{
		public override string Texture => $"{typeof(Witch).NamespaceToPath()}/Witch";

		public override bool IsLoadingEnabled(Mod mod) => true;

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Witch");
			Main.npcFrameCount[NPC.type] = 26;
			NPCID.Sets.ExtraFramesCount[NPC.type] = 5;
			NPCID.Sets.AttackFrameCount[NPC.type] = 5;
			NPCID.Sets.DangerDetectRange[NPC.type] = 1000;
			NPCID.Sets.AttackType[NPC.type] = 0;
			NPCID.Sets.AttackTime[NPC.type] = 30;
			NPCID.Sets.AttackAverageChance[NPC.type] = 30;
		}

		public override void SetDefaults()
		{
			NPC.townNPC = true;
			NPC.friendly = true;
			NPC.width = 32;
			NPC.height = 54;
			NPC.aiStyle = NPCAIStyleID.Passive;
			NPC.damage = 10;
			NPC.defense = 15;
			NPC.lifeMax = 250;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 0.5f;
			AnimationType = NPCID.Guide;
		}

    public override bool CanTownNPCSpawn(int numTownNPCs)
    {
        foreach (Player player in Main.ActivePlayers)
        {
            bool Goodie = player.InventoryHas(ItemID.GoodieBag);
            if (!Main.dayTime || Goodie)
            {
                return false;
            }

        }
        return true;
    }

    public override List<string> SetNPCNameList() => new List<string>()
    {
        this.GetLocalizedValue("Name.Circe"),
        this.GetLocalizedValue("Name.Kikimora"),
        this.GetLocalizedValue("Name.Morgana"),
        this.GetLocalizedValue("Name.Hecate")
    };

    public override string GetChat()
    {
        WeightedRandom<string> dialogue = new WeightedRandom<string>();

        dialogue.Add(this.GetLocalizedValue("Chat.Normal1"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal2"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal3"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal4"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal5"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal6"));

        return dialogue;
    }

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref string shopName)
		{
			if (firstButton)
				shopName = "Witch";
		}

    public override void AddShops()
    {
        var downedBoss1Condition = new Condition("DownedBoss1", () => NPC.downedBoss1);
        var downedBoss2Condition = new Condition("DownedBoss2", () => NPC.downedBoss2);
        var downedBoss3Condition = new Condition("DownedBoss3", () => NPC.downedBoss3);

        NPCShop shop = new(Type, "Witch");

        shop.Add(ModContent.ItemType<PlagueMask>())
            .Add(ModContent.ItemType<PlagueRobe>())
            .Add(ModContent.ItemType<SacrificalScythe>())
            .Add(ModContent.ItemType<Scarecrow>());

        shop.Add(ModContent.ItemType<BoomSpear>(), downedBoss1Condition);

        shop.Add(ModContent.ItemType<BlackRose>(), downedBoss2Condition);

        shop.Add(ModContent.ItemType<Pumpspell>(), downedBoss3Condition);

        shop.Register();
    }

    public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 25;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ModContent.ProjectileType<PumpkinPro>();
			attackDelay = 2;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			int hitDirection = hit.HitDirection;

			if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				//for (int i = 0; i < 3; i++)
				//Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("WitchGore1").Type, 1f);
			}
		}
	}