using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using TremorMod.Content.Items.EvilCornItems;
using TremorMod.Content.Items.Weapons.Melee;
using TremorMod.Content.Items.Weapons.Ranged;
using TremorMod.Content.Projectiles;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class Farmer : ModNPC
	{
		public override string Texture => $"{typeof(Farmer).NamespaceToPath()}/Farmer";

    public override bool IsLoadingEnabled(Mod mod) => true;

    public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Farmer");
			Main.npcFrameCount[NPC.type] = 23;
			NPCID.Sets.ExtraFramesCount[NPC.type] = 5;
			NPCID.Sets.AttackFrameCount[NPC.type] = 4;
			NPCID.Sets.DangerDetectRange[NPC.type] = 1000;
			NPCID.Sets.AttackType[NPC.type] = 0;
			NPCID.Sets.AttackTime[NPC.type] = 30;
			NPCID.Sets.AttackAverageChance[NPC.type] = 30;
		}

		public override void SetDefaults()
		{
			NPC.townNPC = true;
			NPC.friendly = true;
			NPC.width = 30;
			NPC.height = 48;
			NPC.aiStyle = 7;
			NPC.damage = 20;
			NPC.defense = 15;
			NPC.lifeMax = 250;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 0.5f;
			AnimationType = NPCID.Nurse;
		}

    public override bool CanTownNPCSpawn(int numTownNPCs)
    {
        foreach (Player player in Main.ActivePlayers)
        {
            if (player.InventoryHas(ModContent.ItemType<FarmerShovel>()))
            {
                return true; 
            }
        }
        return false; 
    }

    public override List<string> SetNPCNameList() => new List<string>()
    {
        this.GetLocalizedValue("Name.Trillian"),
        this.GetLocalizedValue("Name.Penelope"),
        this.GetLocalizedValue("Name.Emily"),
        this.GetLocalizedValue("Name.Abigail"),
        this.GetLocalizedValue("Name.Alma"),
        this.GetLocalizedValue("Name.Alexandra"),
        this.GetLocalizedValue("Name.Peg")
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
            shopName = "Farmer";
    }

    public override void AddShops()
    {
        var notDownedBoss1Condition = new Condition("NotDownedBoss1", () => !NPC.downedBoss1);
        var dayCondition = new Condition("DayTime", () => Main.dayTime);
        var nightCondition = new Condition("NightTime", () => !Main.dayTime);
        var downedSlimeKingCondition = new Condition("DownedSlimeKing", () => NPC.downedSlimeKing);
        var downedBoss2Condition = new Condition("DownedBoss2", () => NPC.downedBoss2);
        var hardmodeCondition = new Condition("Hardmode", () => Main.hardMode);
        var hasCarrowCondition = new Condition("HasCarrow", () => Main.LocalPlayer.HasItem(ModContent.ItemType<Carrow>()));
        var bloodMoonCondition = new Condition("BloodMoon", () => Main.bloodMoon);

        NPCShop shop = new(Type, "Farmer");

        shop.Add(ModContent.ItemType<CornSeed>());

        shop.Add(ModContent.ItemType<Pitchfork>(), notDownedBoss1Condition);

        shop.Add(ItemID.DaybloomSeeds, dayCondition);
        shop.Add(ItemID.MoonglowSeeds, nightCondition);

        shop.Add(ItemID.WaterleafSeeds, downedSlimeKingCondition);

        shop.Add(ItemID.BlinkrootSeeds, downedBoss2Condition);

        shop.Add(ItemID.FireblossomSeeds, hardmodeCondition);

        shop.Add(ModContent.ItemType<Carrow>(), hasCarrowCondition);

        shop.Add(ItemID.DeathweedSeeds, bloodMoonCondition);

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
			projType = ModContent.ProjectileType<TomatoPro>();
			attackDelay = 4;
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
					Dust.NewDust(NPC.position, NPC.width, NPC.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for(int i = 0; i < 3; ++i)
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("FarmerGore1").Type, 1f);
        }
		}
	}