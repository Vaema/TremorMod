using System.Linq;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using TremorMod.Content.Items;
using TremorMod.Content.Items.Accessories;
using TremorMod.Content.Items.Armor.Heaven;
using TremorMod.Content.Items.Armor.Meteor;
using TremorMod.Content.Items.Armor.Paladin;
using TremorMod.Content.Items.Bag;
using TremorMod.Content.Items.BossLoot.TikiTotem;
using TremorMod.Content.Items.BossSumonItems;
using TremorMod.Content.Items.Buffs;
using TremorMod.Content.Items.Crystal;
using TremorMod.Content.Items.Materials;
using TremorMod.Content.Items.Tools;
using TremorMod.Content.Items.Vanity;
using TremorMod.Content.Items.Weapons.Alchemical;
using TremorMod.Content.Items.Weapons.Magic;
using TremorMod.Content.Items.Weapons.Melee;
using TremorMod.Content.Items.Weapons.Ranged;
using TremorMod.Content.Items.Weapons.Summon;
using TremorMod.Content.Items.Weapons.Throwing;

namespace TremorMod.Utilities;

public class TremorNPC : GlobalNPC
{
    public override void OnKill(NPC npc)
    {
        int[] moonlordNpcTypes = [147, 150, 154, 155, 161, 167, 168, 169, 184, 185, 197, 206, 431];
        if (NPC.downedMechBossAny)
        {
            if ((npc.type == NPCID.TheDestroyer || npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism || npc.type == NPCID.SkeletronPrime))
            {
                if (Main.rand.NextFloat() < 0.10f)
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<FlaskCore>());
            }
        }

        if (NPC.downedMoonlord)
        {
            if (Main.LocalPlayer.ZoneDungeon)
            {
                if (Main.rand.NextFloat() < 0.4f)
                {
                    if (npc.lifeMax > 200 && !Main.expertMode)
                        Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<Phantaplasm>());
                    if (npc.lifeMax > 400 && Main.expertMode)
                        Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<Phantaplasm>());
                }
            }

            if (Main.eclipse)
            {
                if (Main.rand.NextFloat() < 0.10f)
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<ToothofAbraxas>());
            }

            if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism || npc.type == NPCID.SkeletronPrime || npc.type == NPCID.TheDestroyer)
            {
                if (Main.rand.NextFloat() < 0.12f)
                {
                    int amount = Main.rand.Next(1, 7);
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<CarbonSteel>(), amount);
                }
            }

            if (Main.rand.NextFloat() < 0.060f)
            {
                if ((npc.aiStyle == NPCAIStyleID.Slime))
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<DarkMass>());
            }

            if (npc.type == NPCID.Paladin)
            {
                if (Main.rand.NextFloat() < 0.20f)
                {
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<PaladinHelmet>());
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<PaladinBreastplate>());
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<PaladinGreaves>());
                }
            }

            if ((npc.type == NPCID.SeekerHead || npc.type == NPCID.Corruptor || npc.type == NPCID.Clinger || npc.type == NPCID.PigronCorruption || npc.type == NPCID.PigronCrimson ||
            npc.type == NPCID.FloatyGross))
            {
                if (Main.rand.NextFloat() < 0.7f)
                {
                    int amount = Main.rand.Next(1, 2);
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<ClusterShard>(), amount);
                }
            }

            if ((npc.type == NPCID.Pixie || npc.type == NPCID.Unicorn || npc.type == NPCID.RainbowSlime || npc.type == NPCID.Gastropod || npc.type == NPCID.LightMummy || npc.type == NPCID.DesertGhoulHallow))
            {
                if (Main.rand.NextFloat() < 0.50f)
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<UnstableCrystal>());
            }

            if ((npc.type == NPCID.AngryTrapper || npc.type == NPCID.Moth || npc.type == NPCID.FlyingSnake))
            {
                if (Main.rand.NextFloat() < 0.4f)
                {
                    int amount = Main.rand.Next(1, 2);
                    Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<DragonCapsule>(), amount);
                }
            }

            if (Main.rand.NextFloat() < 0.010f)
                Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<SuspiciousBag>());

            if (moonlordNpcTypes.Contains(npc.type))
                Item.NewItem(npc.GetSource_Loot(), npc.position, ModContent.ItemType<IceSoul>());
        }
    }

    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        int[] moonlordNpcTypes = [147, 150, 154, 155, 161, 167, 168, 169, 184, 185, 197, 206, 431];
        if (moonlordNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceSoul>(), 7000));
        }

        int[] ribNpcTypes = [77, 110];
        if (ribNpcTypes.Contains(npc.type))
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheRib>(), 3));

        int[] StoneofLNpcTypes = [481, 483];
        if (StoneofLNpcTypes.Contains(npc.type))
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<StoneofLife>(), 4));

        if (npc.type == NPCID.PossessedArmor)
        {
            npcLoot.Add(ItemDropRule.OneFromOptions(25, ModContent.ItemType<PossessedHelmet>(), ModContent.ItemType<PossessedChestplate>(), ModContent.ItemType<PossessedGreaves>()));
        }

        if (npc.type == NPCID.WallofFlesh)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AlchemistEmblem>(), 4));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ThrowerEmblem>(), 4));
        }

        if (!Main.expertMode && npc.type == NPCID.TheDestroyer)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Destructor>(), 6));
        }

        if (((npc.type == NPCID.BrainScrambler) || (npc.type == NPCID.RayGunner) || (npc.type == NPCID.MartianOfficer) || (npc.type == NPCID.GrayGrunt) || (npc.type == NPCID.MartianEngineer) ||
        (npc.type == NPCID.MartianDrone) || (npc.type == NPCID.GigaZapper) || (npc.type == NPCID.ScutlixRider) || (npc.type == NPCID.Scutlix) || (npc.type == NPCID.MartianWalker)))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Transistor>(), 500));
        }

        if (!Main.expertMode && npc.type == NPCID.WallofFlesh)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PieceofFlesh>(), 1, 8, 17));
        }

        if (npc.type == NPCID.BloodZombie)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Stigmata>(), 30));
        }

        int[] DemonBNpcTypes = [66, 62];

        if (DemonBNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DemonBlood>(), 2));
        }

        if (npc.type == NPCID.GoblinArcher)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LongBow>(), 20));
        }

        if (npc.type == NPCID.SkeletronPrime)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BenderHead>(), 3));

            if (!Main.expertMode)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PrimeBlade>(), 6));
            }
        }

        if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BenderBody>(), 5));
        }

        if (npc.type == NPCID.TheDestroyer)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BenderLegs>(), 3));
        }

        int[] ToxicHNpcTypes = [42, 231, 232, 233, 234, 235];

        if (ToxicHNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ToxicHilt>(), 30));
        }

        if (npc.type == NPCID.EaterofSouls)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PiercingQuartz>(), 30));
        }

        if (npc.type == NPCID.BloodCrawler)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Vertebrow>(), 28));
        }

        if (npc.type == NPCID.SwampThing)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SwampClump>(), 28));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FiercePaw>(), 25));
        }

        if (npc.type == NPCID.ThePossessed)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LeechingSeed>(), 28));
        }

        if (npc.type == NPCID.Butcher)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ButcherMask>(), 20));
        }

        if (npc.type == NPCID.AngryTrapper)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ThornBall>(), 2, 6, 15));
        }

        int[] ArachnophobiaNpcTypes = [164, 165];

        if (ArachnophobiaNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Arachnophobia>(), 40));
        }

        if (!TremorSpawnEnemys.downedMotherboard && Main.hardMode)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MechanicalBrain>(), 2500));
        }

        if (npc.type == NPCID.DesertBeast)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PetrifiedSpike>(), 3, 5, 10));
        }

        int[] ScorpionSNpcTypes = [530, 531];

        if (ScorpionSNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ScorpionStinger>(), 16));
        }

        if (npc.type == NPCID.MeteorHead)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientMeteorHelmet>(), 100));
        }

        if (npc.type == NPCID.SantaNK1)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SantaNK1Mask>(), 7));
        }

        if (npc.type == NPCID.IceQueen)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IceQueenMask>(), 7));
        }

        if (npc.type == NPCID.Everscream)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EverscreamMask>(), 7));
        }

        int[] PumpkingNpcTypes = [327, 328];

        if (PumpkingNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PumpkingMask>(), 7));
        }

        if (npc.type == NPCID.MourningWood)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MourningWoodMask>(), 7));
        }

        if (npc.type == NPCID.PirateShip)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PirateChest>(), 3));
        }

        if (!Main.expertMode && npc.type == NPCID.Golem)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GolemCore>(), 1));
        }

        if (npc.type == NPCID.Mechanic)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ThrowingWrench>(), 1, 10, 20));
        }

        if (npc.type == NPCID.TombCrawlerHead)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IonBlaster>(), 25));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PetrifiedSpike>(), 3, 5, 10));
        }

        if ((npc.type == NPCID.Zombie || npc.type == NPCID.PincushionZombie || npc.type == NPCID.SlimedZombie || npc.type == NPCID.SwampZombie ||
        npc.type == NPCID.TwiggyZombie || npc.type == NPCID.FemaleZombie || npc.type == NPCID.BaldZombie || npc.type == NPCID.ZombieDoctor || npc.type == NPCID.ZombieSuperman ||
        npc.type == NPCID.ZombiePixie || npc.type == NPCID.ZombieXmas || npc.type == NPCID.ZombieSweater || npc.type == NPCID.ArmedZombie || npc.type == NPCID.ArmedZombiePincussion ||
        npc.type == NPCID.ArmedZombieSlimed || npc.type == NPCID.ArmedZombieSwamp || npc.type == NPCID.ArmedZombieTwiggy || npc.type == NPCID.ArmedZombieCenx))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<UntreatedFlesh>(), 3));
        }

        if ((npc.type == NPCID.Harpy || npc.type == NPCID.Pixie || npc.type == NPCID.WyvernHead))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AirFragment>(), 3));
        }

        if ((npc.type == NPCID.Piranha || npc.type == NPCID.Shark || npc.type == NPCID.BlueJellyfish || npc.type == NPCID.PinkJellyfish || npc.type == NPCID.AnglerFish ||
        npc.type == NPCID.GreenJellyfish || npc.type == NPCID.Arapaima))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SeaFragment>(), 2));
        }

        if ((npc.type == NPCID.GiantWormHead || npc.type == NPCID.DiggerHead || npc.type == NPCID.Snatcher || npc.type == NPCID.GiantTortoise || npc.type == NPCID.AngryTrapper ||
        npc.type == NPCID.MossHornet || npc.type == NPCID.Moth || npc.type == NPCID.HornetFatty || npc.type == NPCID.HornetHoney || npc.type == NPCID.HornetLeafy ||
        npc.type == NPCID.HornetSpikey || npc.type == NPCID.HornetStingy || npc.type == NPCID.JungleCreeper || npc.type == NPCID.JungleCreeperWall))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EarthFragment>(), 4));
        }

        if ((npc.type == NPCID.FireImp || npc.type == NPCID.LavaSlime || npc.type == NPCID.Hellbat || npc.type == NPCID.Lavabat || npc.type == NPCID.Demon ||
        npc.type == NPCID.VoodooDemon))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FireFragment>(), 3));
        }

        if ((npc.type == NPCID.Psycho || npc.type == NPCID.DeadlySphere || npc.type == NPCID.DrManFly || npc.type == NPCID.Nailhead || npc.type == NPCID.Butcher))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DarkMatter>(), 2));
        }

        if (npc.type == NPCID.GiantShelly)
        {
            //npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PurpleShellmet>(), 22));
        }

        if (npc.type == NPCID.GiantShelly2)
        {
            //npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<OrangeShellmet>(), 22));
        }

        if (npc.lifeMax > 100 && npc.lifeMax < 200)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TinySai>(), 300));
        }

        if (npc.value > 100f && npc.value < 1000f)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RoyalClaymore>(), 300));
        }

        if (npc.lifeMax > 200 && npc.lifeMax < 500)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MassiveHammer>(), 300));
        }

        if (npc.defense > 10 && npc.defense < 30)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Crowbar>(), 300));
        }

        if (npc.damage < 200 && npc.damage > 80)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Narsil>(), 300));
        }

        if (npc.boss && !Main.hardMode)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeavenHelmet>(), 5));
        }

        if (npc.boss && !Main.hardMode)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeavenBreastplate>(), 5));
        }

        if (npc.boss && !Main.hardMode)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeavenLeggings>(), 5));
        }

        if (npc.type == NPCID.EaterofWorldsHead)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CorruptorStaff>(), 20));
        }

        if (npc.type == NPCID.BrainofCthulhu)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CreeperStaff>(), 20));
        }

        if (Main.xMas && !Main.LocalPlayer.HasItem(ModContent.ItemType<SuspiciousLookingPresent>()))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SuspiciousLookingPresent>(), 250));
        }

        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SuspiciousBag>(), 10000));

        if (Main.LocalPlayer.ZoneDungeon)
        {
            if (npc.lifeMax > 200 && !Main.expertMode)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Phantaplasm>(), 40000));
            }
            if (npc.lifeMax > 400 && Main.expertMode)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Phantaplasm>(), 40000));
            }
        }

        if (npc.type == NPCID.DevourerHead)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CorruptorGun>(), 26));
        }

        if ((npc.type == NPCID.Antlion || npc.type == NPCID.GiantWalkingAntlion))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AntlionShell>(), 6));
        }

        if (npc.type == NPCID.BirdRed)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RedMask>(), 100));
        }

        if (npc.type == NPCID.Crawdad)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RedClaw>(), 29));
        }

        if (npc.type == NPCID.Crawdad2)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GreenClaw>(), 29));
        }

        if ((npc.type == NPCID.Salamander || npc.type == NPCID.Salamander2 || npc.type == NPCID.Salamander3 || npc.type == NPCID.Salamander4 || npc.type == NPCID.Salamander5 ||
        npc.type == NPCID.Salamander6 || npc.type == NPCID.Salamander7 || npc.type == NPCID.Salamander8 || npc.type == NPCID.Salamander9))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SalamanderSkin>(), 2));
        }

        if ((npc.type == NPCID.Crimera))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CrimCudgel>(), 173));
        }

        if ((npc.type == NPCID.EyeofCthulhu))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TriangleMask>(), 10));
        }

        if ((npc.type == NPCID.SkeletronHead))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheArtifact>(), 6));
        }

        if (Main.eclipse)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ToothofAbraxas>(), 10000));
        }

        if ((npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism || npc.type == NPCID.SkeletronPrime || npc.type == NPCID.TheDestroyer))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CarbonSteel>(), 1, 6, 120000));
        }

        int[] RedSteelNPCs = [21, 449, 450, 451, 452, 322, 323, 324, 294, 295, 296, 201, 202, 20];
        if (WorldGen.shadowOrbSmashed && RedSteelNPCs.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RedSteelArmorPiece>(), 8));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FaultyRedSteelShield>(), 8));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ChippyRedSteelSword>(), 8));
        }

        if ((npc.type == NPCID.BloodZombie))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheBrain>(), 24));
        }

        if ((npc.type == NPCID.Drippler))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DrippingRoot>(), 4));
        }

        if ((npc.aiStyle == NPCAIStyleID.Slime))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DarkMass>(), 60000));
        }

        if ((npc.type == NPCID.WallCreeper || npc.type == NPCID.WallCreeperWall))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SpiderMeat>(), 5, 1, 3));
        }

        if ((npc.type == NPCID.SeekerHead || npc.type == NPCID.Corruptor || npc.type == NPCID.Clinger || npc.type == NPCID.PigronCorruption || npc.type == NPCID.PigronCrimson ||
        npc.type == NPCID.FloatyGross))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ClusterShard>(), 7000, 1, 2));
        }

        if ((npc.type == NPCID.AngryTrapper || npc.type == NPCID.Moth || npc.type == NPCID.FlyingSnake))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DragonCapsule>(), 4000, 1, 2));
        }

        if (npc.type == NPCID.Paladin)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PaladinHelmet>(), 20000));
        }

        if (npc.type == NPCID.Paladin)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PaladinBreastplate>(), 200000));
        }

        if (npc.type == NPCID.Paladin)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<PaladinGreaves>(), 20000));
        }

        if (!Main.expertMode && npc.type == NPCID.SkeletronHead)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TearsofDeath>(), 1, 1, 3));
        }

        int[] FrostCoreNpcTypes = [169, 431, 161];
        if (FrostCoreNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrostCore>(), 5, 1, 3));
        }

        if (npc.type == NPCID.Mothron)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrokenHeroAmulet>(), 4));
        }

        int[] WaterStormNpcTypes = [32, 34];

        if (WaterStormNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WaterStorm>(), 50));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KeyKnife>(), 40));
        }

        if (!Main.expertMode && npc.type == NPCID.EyeofCthulhu)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EyeMonolith>(), 5));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterTooth>(), 3, 20, 40));
        }

        if (npc.type == NPCID.UndeadViking)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<NorthAxe>(), 32));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<NorthHammer>(), 32));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<NorthCutlass>(), 32));
        }

        if (npc.type == NPCID.Wraith)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WrathofWraith>(), 40));
        }

        if (npc.type == NPCID.CultistBoss)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientTablet>(), 1, 12, 22));
        }

        if (npc.type == NPCID.Plantera)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<EssenseofJungle>(), 1, 2, 3));
        }

        if (npc.type == NPCID.DukeFishron && !Main.expertMode)
        {
            //npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DukesCannon>(), 1, 2, 3));
        }

        int[] CrystalSpearNpcTypes = [138, 137];

        if (CrystalSpearNpcTypes.Contains(npc.type))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CrystalSpear>(), 35, 2, 3));
        }

        if (npc.type == NPCID.BoneSerpentHead)
        {
            //npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GunBlade>(), 1, 2, 3));
        }

        if (npc.type == NPCID.SantaNK1)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SpiK3Ball>(), 1, 50, 100));
        }

        if ((npc.type == NPCID.Pixie || npc.type == NPCID.Unicorn || npc.type == NPCID.RainbowSlime || npc.type == NPCID.Gastropod || npc.type == NPCID.LightMummy || npc.type == NPCID.DesertGhoulHallow))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<UnstableCrystal>(), 5000));
        }

        if (npc.type == NPCID.Merchant)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MoneySack>(), 2, 2, 4));
        }

        if (npc.type == NPCID.MoonLordCore)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MultidimensionalFragment>(), 1, 2, 4));
        }

        if (!Main.expertMode && npc.type == NPCID.QueenBee)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<YellowPuzzleFragment>(), 3));
        }

        if ((npc.type == NPCID.BrainScrambler || npc.type == NPCID.RayGunner || npc.type == NPCID.MartianOfficer || npc.type == NPCID.GrayGrunt || npc.type == NPCID.MartianEngineer || npc.type == NPCID.MartianTurret || npc.type == NPCID.MartianDrone || npc.type == NPCID.GigaZapper || npc.type == NPCID.ScutlixRider))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<WarpPad>(), 100));
        }

        if ((npc.type == NPCID.BlueArmoredBones || npc.type == NPCID.BlueArmoredBonesMace || npc.type == NPCID.BlueArmoredBonesNoPants || npc.type == NPCID.BlueArmoredBonesSword || npc.type == NPCID.RustyArmoredBonesAxe || npc.type == NPCID.RustyArmoredBonesFlail || npc.type == NPCID.RustyArmoredBonesSword || npc.type == NPCID.RustyArmoredBonesSwordNoArmor || npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSword || npc.type == NPCID.Necromancer || npc.type == NPCID.NecromancerArmored || npc.type == NPCID.RaggedCaster || npc.type == NPCID.RaggedCasterOpenCoat || npc.type == NPCID.DiabolistRed || npc.type == NPCID.DiabolistWhite))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BottledSpirit>(), 25));
        }

        if ((npc.type == NPCID.TheDestroyer || npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism || npc.type == NPCID.SkeletronPrime))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FlaskCore>(), 10000));
        }

        if (npc.type == NPCID.AngryTrapper)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RichMahoganySeed>(), 50));
        }

        if (!Main.expertMode && npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(125))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BottledSpirit>(), 25));
        }

        if (!Main.expertMode && Main.rand.NextBool(6))
        {
            if ((npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(125)) || (npc.type == NPCID.Retinazer && !NPC.AnyNPCs(126)))
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MechaSprayer>(), 1));
        }

        if (npc.type == NPCID.MartianSaucerCore)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MartianSprayer>(), 20));
        }

        if (npc.type == NPCID.DukeFishron)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DukeFlask>(), 1, 550, 750));
        }

        if (npc.type == NPCID.ChaosElemental)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ChaosElement>(), 20));
        }

        if ((npc.type == NPCID.Frog || npc.type == NPCID.GoldFrog))
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrogMask>(), 33));
        }

        if (npc.type == NPCID.SkeletronHead)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CursedSoul>(), 1, 1, 5));
        }
    }

    public override void ModifyShop(NPCShop shop)
    {
        if (shop.NpcType == NPCID.Merchant && Main.bloodMoon)
            shop.Add(ModContent.ItemType<RedPuzzleFragment>());
    }

    public override void SetDefaults(NPC npc)
    {
        // Allow jellyfish enemies to be captured with a bug net.
        if (npc.type == NPCID.BlueJellyfish && Main.hardMode)
            npc.catchItem = 2436;
        if (npc.type == NPCID.GreenJellyfish && Main.hardMode)
            npc.catchItem = 2437;
        if (npc.type == NPCID.PinkJellyfish && Main.hardMode)
            npc.catchItem = 2438;

        // Tremode stat changes.
        if (NPC.downedMoonlord && !npc.boss && !npc.townNPC && npc.type >= NPCID.None && npc.type <= NPCID.BartenderUnconscious)
        {
            npc.lifeMax *= 2;
            npc.defense *= 2;
        }
    }
}
