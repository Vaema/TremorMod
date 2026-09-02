using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using TremorMod.Content.Items.Accessories;
using TremorMod.Content.Items;
using TremorMod.Content.Items.Weapons.Magic;
using TremorMod.Content.Items.Weapons.Melee;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class Undertaker : ModNPC
	{
		public override string Texture => $"{typeof(Undertaker).NamespaceToPath()}/Undertaker";

    public override bool IsLoadingEnabled(Mod mod) => true;

    public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Undertaker");
			Main.npcFrameCount[NPC.type] = 25;
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
			NPC.height = 44;
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
            if (!TremorSpawnEnemys.downedTrinity)
            {
                return true;
            }
        }
        return false;
    }

    public override List<string> SetNPCNameList() =>
    [
        this.GetLocalizedValue("Name.Tenner"),
        this.GetLocalizedValue("Name.Geyer"),
        this.GetLocalizedValue("Name.Cleve"),
        this.GetLocalizedValue("Name.Ferron"),
        this.GetLocalizedValue("Name.Gasper"),
        this.GetLocalizedValue("Name.Spots"),
        this.GetLocalizedValue("Name.Hargon")
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
            shopName = "Undertaker";
    }

    public override void AddShops()
    {
        var nightCondition = new Condition("NightTime", () => !Main.dayTime);

        NPCShop shop = new(Type, "Undertaker");

        shop.Add(ModContent.ItemType<Skullheart>())
            .Add(ModContent.ItemType<SpearofJustice>())
            .Add(ModContent.ItemType<TheGhostClaymore>());

        shop.Add(ModContent.ItemType<LivingTombstone>(), nightCondition);

        shop.Register(); 
    }

    public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 150;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 645;
			attackDelay = 5;
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
//            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("TheUndertakerGore1").Type, 1f);
        }
		}
	}