using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using System.Collections.Generic;
using TremorMod.Content.Items.BossSumonItems;
using TremorMod.Content.Items.Vanity;
using TremorMod.Content.Items.Weapons.Magic;
using TremorMod.Content.Items.Weapons.Melee;
using TremorMod.Content.Items.Weapons.Ranged;

namespace TremorMod.Content.NPCs.TownNPCs;

	[AutoloadHead]
	public class Chef : ModNPC
	{
		public override string Texture => $"{typeof(Chef).NamespaceToPath()}/Chef";

    public override bool IsLoadingEnabled(Mod mod) => true;

    public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chef");
			Main.npcFrameCount[NPC.type] = 25;
			NPCID.Sets.ExtraFramesCount[NPC.type] = 5;
			NPCID.Sets.AttackFrameCount[NPC.type] = 4;
			NPCID.Sets.DangerDetectRange[NPC.type] = 150;
			NPCID.Sets.AttackAverageChance[NPC.type] = 30;
			NPCID.Sets.AttackType[NPC.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee) 
			NPCID.Sets.AttackTime[NPC.type] = 30; //this defines the npc attack speed
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
			AnimationType = NPCID.GoblinTinkerer;
		}

    public override bool CanTownNPCSpawn(int numTownNPCs)
    {
        if (!NPC.downedBoss2)
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

    public override List<string> SetNPCNameList() => new List<string>()
    {
        this.GetLocalizedValue("Name.Richard"),
        this.GetLocalizedValue("Name.Oliver"),
        this.GetLocalizedValue("Name.Alan"),
        this.GetLocalizedValue("Name.Gordon"),
        this.GetLocalizedValue("Name.Umeril"),
        this.GetLocalizedValue("Name.Anthony"),
        this.GetLocalizedValue("Name.Jerome"),
        this.GetLocalizedValue("Name.Liam")
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
            shopName = "Chef";
    }

    public override void AddShops()
    {
        var farmerPresentCondition = new Condition("FarmerPresent", () => NPC.AnyNPCs(ModContent.NPCType<Farmer>()));
        var downedBoss2Condition = new Condition("DownedBoss2", () => NPC.downedBoss2);
        var bloodMoonCondition = new Condition("BloodMoon", () => Main.bloodMoon);

        NPCShop shop = new(Type, "Chef");

        shop.Add(ModContent.ItemType<Knife>())
            .Add(ModContent.ItemType<Durian>())
            .Add(ModContent.ItemType<ChefHat>())
            .Add(ModContent.ItemType<ButcherAxe>());

        shop.Add(ModContent.ItemType<Carrow>(), farmerPresentCondition);

        shop.Add(ModContent.ItemType<ChickenLegMace>(), downedBoss2Condition);

        shop.Add(ModContent.ItemType<CursedPopcorn>(), bloodMoonCondition);

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

		public override void DrawTownAttackSwing(ref Texture2D item, ref Rectangle itemFrame, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). ItemType is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
		{
			scale = 1f;
			item = TextureAssets.Item[ModContent.ItemType<ButcherAxe>()].Value; //this defines the item that this npc will use
			itemSize = 40;
		}

		public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
		{
			itemWidth = 50;
			itemHeight = 50;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
        int hitDirection = hit.HitDirection;

        if (NPC.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.SeaSnail, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				for(int i = 0; i < 3; ++i)
                Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("ChefGore1").Type, 1f);
        
			}
		}
	}