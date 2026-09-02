using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using Terraria.GameContent.ItemDropRules;
using TremorMod.Content.Items.Accessories;
using TremorMod.Content.Items.BossSumonItems;
using TremorMod.Content.Items;
using TremorMod.Content.Items.Vanity;
using TremorMod.Content.Items.Weapons.Ranged;
using TremorMod.Content.Projectiles;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class ArabianMerchant : ModNPC
	{
		public override string Texture => $"{typeof(ArabianMerchant).NamespaceToPath()}/ArabianMerchant";

    public override bool IsLoadingEnabled(Mod mod) => true;

    public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Arabian Merchant");
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
			NPC.width = 28;
			NPC.height = 48;
			NPC.aiStyle = NPCAIStyleID.Passive;
			NPC.damage = 10;
			NPC.defense = 15;
			NPC.lifeMax = 250;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 0.5f;
			//npc.homeless = true;
			//npc.active = false;
			AnimationType = NPCID.Guide;
		}

    public override bool CanTownNPCSpawn(int numTownNPCs)
    {
        if (!TremorSpawnEnemys.downedRukh)
            return false;

        foreach (Player player in Main.ActivePlayers)
        {
            if (!player.dead)
            {
                return true;
            }
        }

        return false;
    }

    public override List<string> SetNPCNameList() =>
    [
        this.GetLocalizedValue("Name.Badruddin"),
        this.GetLocalizedValue("Name.Galib"),
        this.GetLocalizedValue("Name.Salavat"),
        this.GetLocalizedValue("Name.Zafar"),
        this.GetLocalizedValue("Name.Valid"),
        this.GetLocalizedValue("Name.Tunak"),
        this.GetLocalizedValue("Name.Nadim")
    ];

    public override string GetChat()
    {
        WeightedRandom<string> dialogue = new WeightedRandom<string>();

        dialogue.Add(this.GetLocalizedValue("Chat.Normal1"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal2"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal3"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal4"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal5"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal6"));
        dialogue.Add(this.GetLocalizedValue("Chat.Normal7"));

        return dialogue;
    }       

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

    public override void OnChatButtonClicked(bool firstButton, ref string shopName)
    {
        if (firstButton)
            shopName = "Arabian";
    }

    public override void AddShops()
    {
        var downedBoss1Condition = new Condition("DownedBoss1", () => NPC.downedBoss1);
        var downedBoss2Condition = new Condition("DownedBoss2", () => NPC.downedBoss2);

        NPCShop shop = new(Type, "Arabian");

        shop.Add(ModContent.ItemType<GenieLamp>())
            .Add(ModContent.ItemType<JavaHood>())
            .Add(ModContent.ItemType<JavaRobe>())
            .Add(ModContent.ItemType<SandstoneRing>())
            .Add(ItemID.StinkPotion)
            .Add(ItemID.LovePotion);

        shop.Add(ModContent.ItemType<FossilSugar>(), downedBoss1Condition)
            .Add(ModContent.ItemType<DesertCrown>(), downedBoss1Condition);

        shop.Add(ItemID.BoneJavelin, downedBoss2Condition)
            .Add(ItemID.BoneDagger, downedBoss2Condition);

        shop.Add(ModContent.ItemType<DesertEagle>(), Condition.Hardmode);

        shop.Register(); 
    }

    public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 30;
			knockback = 3f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ModContent.ProjectileType<Sand>();
			attackDelay = 4;
		}

    public override void ModifyNPCLoot(NPCLoot npcLoot)
    {
        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WhiteTurban>(), 1));
    }

    public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for (int i = 0; i < 3; i++)
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ArabianMerchantGore1").Type, 1f);
        }
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}