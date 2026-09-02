using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using TremorMod.Content.Items.Armor.Leather;
using TremorMod.Content.Items.Accessories;
using TremorMod.Content.Items.Weapons.Ranged;
using TremorMod.Utilities;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class Archer : ModNPC
	{
		public override string Texture => $"{typeof(Archer).NamespaceToPath()}/Archer";

    public override bool IsLoadingEnabled(Mod mod) => true;

    public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Archer");
			Main.npcFrameCount[NPC.type] = 26;
			NPCID.Sets.ExtraFramesCount[NPC.type] = 5;
			NPCID.Sets.AttackFrameCount[NPC.type] = 4;
			NPCID.Sets.DangerDetectRange[NPC.type] = 1000;
			NPCID.Sets.AttackType[NPC.type] = 1;
			NPCID.Sets.AttackTime[NPC.type] = 30;
			NPCID.Sets.AttackAverageChance[NPC.type] = 30;
		}

		public override void SetDefaults()
		{
			NPC.townNPC = true;
			NPC.friendly = true;

			NPC.width = 30;
			NPC.height = 48;
			NPC.aiStyle = NPCAIStyleID.Passive;
			NPC.damage = 10;
			NPC.defense = 15;
			NPC.lifeMax = 250;
			NPC.knockBackResist = 0.5f;

			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			AnimationType = NPCID.Guide;
		}

    public override bool CanTownNPCSpawn(int numTownNPCs)
    {
        foreach (Player player in Main.ActivePlayers)
        {
            if (player.InventoryHas(ItemID.WoodenArrow))
            {
                return true; 
            }
        }
        return false; 
    }

    public override List<string> SetNPCNameList() => new List<string>()
    {
        this.GetLocalizedValue("Name.Richard"),
        this.GetLocalizedValue("Name.Arthur"),
        this.GetLocalizedValue("Name.Jack"),
        this.GetLocalizedValue("Name.William"),
        this.GetLocalizedValue("Name.Robin"),
        this.GetLocalizedValue("Name.Wales")
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
            shopName = "Archer";
    }

    public override void AddShops()
    {
        var bossCondition = new Condition("DownedEaterOrBrain", () => Condition.DownedEaterOfWorlds.IsMet() || Condition.DownedBrainOfCthulhu.IsMet());
        NPCShop shop = new(Type, "Archer");

        shop.AddWithCustomValue(ModContent.ItemType<Quiver>(), Item.buyPrice(silver: 6), Condition.DownedEyeOfCthulhu)
            .AddWithCustomValue(ModContent.ItemType<ArcherGlove>(), Item.buyPrice(gold: 1))
            .AddWithCustomValue(ModContent.ItemType<Crossbow>(), Item.buyPrice(gold: 3))
            .AddWithCustomValue(ItemID.WoodenArrow, Item.buyPrice(copper: 5))
            .AddWithCustomValue(ModContent.ItemType<MiniGun>(), Item.buyPrice(gold: 5), Condition.DownedEyeOfCthulhu)
            .AddWithCustomValue(ModContent.ItemType<LeatherHat>(), Item.buyPrice(silver: 50), Condition.DownedEyeOfCthulhu)
            .AddWithCustomValue(ModContent.ItemType<LeatherShirt>(), Item.buyPrice(silver: 75), Condition.DownedEyeOfCthulhu)
            .AddWithCustomValue(ModContent.ItemType<LeatherGreaves>(), Item.buyPrice(silver: 75), Condition.DownedEyeOfCthulhu)
            .AddWithCustomValue(ItemID.JestersArrow, Item.buyPrice(silver: 10), Condition.DownedEyeOfCthulhu)
            .AddWithCustomValue(ItemID.BoneJavelin, Item.buyPrice(silver: 15), bossCondition)
            .AddWithCustomValue(ModContent.ItemType<DragonGem>(), Item.buyPrice(gold: 3), bossCondition)
            .AddWithCustomValue(ItemID.UnholyArrow, Item.buyPrice(silver: 20), bossCondition)
            .AddWithCustomValue(ModContent.ItemType<DesertEagle>(), Item.buyPrice(gold: 10), Condition.Hardmode)
            .AddWithCustomValue(ItemID.HolyArrow, Item.buyPrice(silver: 25), Condition.Hardmode)
            .AddWithCustomValue(ItemID.HellfireArrow, Item.buyPrice(silver: 30), Condition.Hardmode)
            .AddWithCustomValue(ItemID.BoneArrow, Item.buyPrice(silver: 5), Condition.BloodMoon);

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

    public override void DrawTownAttackGun(ref Texture2D item, ref Rectangle itemFrame, ref float scale, ref int horizontalHoldoutOffset)
    {
        scale = 1f;
        item = Main.hardMode ? TextureAssets.Item[ItemID.ShadowFlameBow].Value : TextureAssets.Item[ItemID.DemonBow].Value;
        horizontalHoldoutOffset = 20;
    }

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
		{
			projType = !Main.hardMode ? ProjectileID.FireArrow : ProjectileID.ShadowFlameArrow;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
		{
			multiplier = 7f;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for(int i = 0; i < 3; ++i)
            Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ArcherGore1").Type, 1f);
        }
		}
	}