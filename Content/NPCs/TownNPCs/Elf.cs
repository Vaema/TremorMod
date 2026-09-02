using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using TremorMod.Content.Items;
using TremorMod.Content.Items.Placeable;
using TremorMod.Content.Items.Weapons.Magic;
using TremorMod.Content.Items.Weapons.Melee;
using TremorMod.Content.Items.Weapons.Ranged;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class Elf : ModNPC
	{
		public override string Texture => $"{typeof(Elf).NamespaceToPath()}/Elf";

    public override bool IsLoadingEnabled(Mod mod) => true;

    public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Elf");
			Main.npcFrameCount[NPC.type] = 26;
			NPCID.Sets.ExtraFramesCount[NPC.type] = 5;
			NPCID.Sets.AttackFrameCount[NPC.type] = 6;
			NPCID.Sets.DangerDetectRange[NPC.type] = 1000;
			NPCID.Sets.AttackType[NPC.type] = 0;
			NPCID.Sets.AttackTime[NPC.type] = 30;
			NPCID.Sets.AttackAverageChance[NPC.type] = 30;
		}

		public override void SetDefaults()
		{
			NPC.townNPC = true;
			NPC.friendly = true;
			NPC.width = 36;
			NPC.height = 44;
			NPC.aiStyle = NPCAIStyleID.Passive;
			NPC.damage = 20;
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
            if (player.InventoryHas(ModContent.ItemType<SuspiciousLookingPresent>()))
            {
                return true; 
            }
        }

        return false; 
    }

    public override List<string> SetNPCNameList() => new List<string>()
    {
        this.GetLocalizedValue("Name.Nick"),
        this.GetLocalizedValue("Name.Elfie"),
        this.GetLocalizedValue("Name.Jingle"),
        this.GetLocalizedValue("Name.Sparkle"),
        this.GetLocalizedValue("Name.Twinkle"),
        this.GetLocalizedValue("Name.Elvis"),
        this.GetLocalizedValue("Name.Peppermint"),
        this.GetLocalizedValue("Name.Snowflake")
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
            shopName = "Elf";
    }

    public override void AddShops()
    {
        var downedBoss1Condition = new Condition("DownedBoss1", () => NPC.downedBoss1);
        var downedBoss3Condition = new Condition("DownedBoss3", () => NPC.downedBoss3);
        var hardmodeCondition = new Condition("Hardmode", () => Main.hardMode);

        NPCShop shop = new(Type, "Elf");

        shop.Add(ModContent.ItemType<CandyCane>())
            .Add(ModContent.ItemType<RedChristmasStocking>())
            .Add(ModContent.ItemType<BlueChristmasStocking>())
            .Add(ModContent.ItemType<GreenChristmasStocking>());

        shop.Add(ModContent.ItemType<SnowShotgun>(), downedBoss1Condition)
            .Add(ModContent.ItemType<CandyBow>(), downedBoss1Condition);

        shop.Add(ModContent.ItemType<TheSnowBall>(), downedBoss3Condition);

        shop.Add(ModContent.ItemType<Blizzard>(), hardmodeCondition);

        shop.Register(); 
    }

    public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 1;
			attackDelay = 2;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}     
} 