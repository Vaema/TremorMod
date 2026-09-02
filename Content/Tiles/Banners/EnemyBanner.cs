using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using TremorMod.Content.NPCs;

namespace TremorMod.Content.Tiles.Banners;

public class EnemyBanner : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
        TileObjectData.newTile.Height = 3;
        TileObjectData.newTile.CoordinateHeights = [16, 16, 16];
        TileObjectData.newTile.StyleWrapLimit = 111;
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom | AnchorType.PlanterBox, TileObjectData.newTile.Width, 0);
        TileObjectData.newTile.DrawYOffset = -2;
        TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
        TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.Platform, TileObjectData.newTile.Width, 0);
        TileObjectData.newAlternate.DrawYOffset = -10;
        TileObjectData.addAlternate(0);
        TileObjectData.addTile(Type);
        DustType = -1;
        TileID.Sets.DisableSmartCursor[Type] = true;
        AddMapEntry(new Color(13, 88, 130), Language.GetText("MapObject.Banner"));
    }

    public override void NearbyEffects(int i, int j, bool closer)
    {
        if (!closer)
            return;
        Player player = Main.LocalPlayer;
        if (player is null || !player.active || player.dead)
            return;

        int style = Main.tile[i, j].TileFrameX / 18;
        int[] npcs = GetBannerNPCs(style);
        foreach (int npc in npcs)
        {
            if (npc != -1)
            {
                Main.SceneMetrics.NPCBannerBuff[npc] = true;
                Main.SceneMetrics.hasBanner = true;
            }
        }
    }

    public static int GetBannerNPC(int style)
    {
        int npc = -1;
        switch (style)
        {
            case 0:
                npc = NPCType<Abomination>();
                break;
            case 1:
                npc = NPCType<Agloomination>();
                break;
            case 2:
                npc = NPCType<ArmoredJellyfish>();
                break;
            case 3:
                npc = NPCType<Atis>();
                break;
            case 4:
                npc = NPCType<Banshee>();
                break;
            case 5:
                npc = NPCType<HarpyWarrior>();
                break;
            case 6:
                npc = NPCType<Bicholmere>();
                break;
            case 7:
                npc = NPCType<Blazer>();
                break;
            case 11:
                npc = NPCType<CaveGolem>();
                break;
            case 12:
                npc = NPCType<CloudSlime>();
                break;
            case 13:
                npc = NPCType<ConjurerSkeleton>();
                break;
            case 14:
                npc = NPCType<CoreBug>();
                break;
            case 15:
                npc = NPCType<CoreSlime>();
                break;
            case 16:
                npc = NPCType<CorruptedBicholmere>();
                break;
            case 17:
                npc = NPCType<Crimer>();
                break;
            case 18:
                npc = NPCType<CrimsonBicholmere>();
                break;
            case 19:
                npc = NPCType<DeepwaterVilefish>();
                break;
            case 20:
                npc = NPCType<Deimos>();
                break;
            case 21:
                npc = NPCType<DevilishTortoise>();
                break;
            case 22:
                npc = NPCType<Dinictis>();
                break;
            case 23:
                npc = NPCType<DragonSkull>();
                break;
            case 24:
                npc = NPCType<Dranix>();
                break;
            case 25:
                npc = NPCType<DreadBeetle>();
                break;
            case 26:
                npc = NPCType<DungeonKeeper>();
                break;
            case 27:
                npc = NPCType<ElderObserver>();
                break;
            case 28:
                npc = NPCType<EnragedBat>();
                break;
            case 35:
                npc = NPCType<FatFlinx>();
                break;
            case 36:
                npc = NPCType<FireBeetle>();
                break;
            case 37:
                npc = NPCType<Flayer>();
                break;
            case 38:
                npc = NPCType<FrostBeetle>();
                break;
            case 39:
                npc = NPCType<GeneralSnowman>();
                break;
            case 40:
                npc = NPCType<GhostKnight>();
                break;
            case 41:
                npc = NPCType<GiantCrab>();
                break;
            case 42:
                npc = NPCType<GiantGastropod>();
                break;
            case 43:
                npc = NPCType<GiantMeteorHead>();
                break;
            case 44:
                npc = NPCType<Hallower>();
                break;
            case 45:
                npc = NPCType<HallowSlimer>();
                break;
            case 46:
                npc = NPCType<HeadlessZombie>();
                break;
            case 47:
                npc = NPCType<HeavyZombie>();
                break;
            case 48:
                npc = NPCType<HiveHeadZombie>();
                break;
            case 49:
                npc = NPCType<IceBlazer>();
                break;
            case 50:
                npc = NPCType<IronGiant>();
                break;
            case 51:
                npc = NPCType<Leprechaun>();
                break;
            case 52:
                npc = NPCType<MechanicalFirefly>();
                break;
            case 53:
                npc = NPCType<MeteoriteGolem>();
                break;
            case 54:
                npc = NPCType<MightyNimbus>();
                break;
            case 55:
                npc = NPCType<Minotaur>();
                break;
            case 56:
                npc = NPCType<MushroomCreature>();
                break;
            case 57:
                npc = NPCType<NightTerror>();
                break;
            case 58:
                npc = NPCType<Observer>();
                break;
            case 59:
                npc = NPCType<Orc>();
                break;
            case 60:
                npc = NPCType<OrcSkeleton>();
                break;
            case 61:
                npc = NPCType<OrcWarrior>();
                break;
            case 62:
                npc = NPCType<Parasprite>();
                break;
            case 63:
                npc = NPCType<Peepers>();
                break;
            case 64:
                npc = NPCType<Phantom>();
                break;
            case 65:
                npc = NPCType<PharaohCaster>();
                break;
            case 66:
                npc = NPCType<Phobos>();
                break;
            case 69:
                npc = NPCType<PossessedHound>();
                break;
            case 70:
                npc = NPCType<PyramidHead>();
                break;
            case 71:
                npc = NPCType<QuartzBeetle>();
                break;
            case 72:
                npc = NPCType<Rogue>();
                break;
            case 73:
                npc = NPCType<SandThing>();
                break;
            case 74:
                npc = NPCType<ShadowRipper>();
                break;
            case 75:
                npc = NPCType<SkeletonKnight>();
                break;
            case 76:
                npc = NPCType<ScaryBat>();
                break;
            case 77:
                npc = NPCType<Sighted>();
                break;
            case 78:
                npc = NPCType<SnowmanBomber>();
                break;
            case 79:
                npc = NPCType<SnowmanWarrior>();
                break;
            case 80:
                npc = NPCType<SquidZombie>();
                break;
            case 81:
                npc = NPCType<Skullker>();
                break;
            case 82:
                npc = NPCType<Snowcopter>();
                break;
            case 83:
                npc = NPCType<SpiderMan>();
                break;
            case 84:
                npc = NPCType<SupremePossessedArmor>();
                break;
            case 85:
                npc = NPCType<TheAxeman>();
                break;
            case 86:
                npc = NPCType<TheGirl>();
                break;
            case 90:
                npc = NPCType<TheThing>();
                break;
            case 91:
                npc = NPCType<TwilightBat>();
                break;
            case 96:
                npc = NPCType<Zarprite>();
                break;
            case 97:
                npc = NPCType<Zarprute>();
                break;
            case 98:
                npc = NPCType<AncientCursedSkull>();
                break;
            case 99:
                npc = NPCType<ArchDemon>();
                break;
            case 100:
                npc = NPCType<BoneArcher>();
                break;
            case 101:
                npc = NPCType<BoneFlyer>();
                break;
            case 102:
                npc = NPCType<DarkDruid>();
                break;
            case 103:
                npc = NPCType<GraniteBeetle>();
                break;
            case 104:
                npc = NPCType<GraniteBowman>();
                break;
            case 105:
                npc = NPCType<AlphaWolf>();
                break;
            case 106:
                npc = NPCType<BetaWolf>();
                break;
            case 107:
                npc = NPCType<OmegaWolf>();
                break;
            case 108:
                npc = NPCType<Woody>();
                break;
            default:
                break;
        }
        return npc;
    }

    public static int[] GetBannerNPCs(int style)
    {
        switch (style)
        {
            case 0:
                return [NPCType<Abomination>()];
            case 1:
                return [NPCType<Agloomination>()];
            case 2:
                return [NPCType<ArmoredJellyfish>()];
            case 3:
                return [NPCType<Atis>()];
            case 4:
                return [NPCType<Banshee>()];
            case 5:
                return [NPCType<HarpyWarrior>()];
            case 6:
                return [NPCType<Bicholmere>()];
            case 7:
                return [NPCType<Blazer>()];
            case 8: // BloodmoonWarrior1
            case 9: // BloodmoonWarrior2
            case 10: // BloodmoonWarrior3
                return [NPCType<BloodmoonWarrior1>(), NPCType<BloodmoonWarrior2>(), NPCType<BloodmoonWarrior3>()];
            case 11:
                return [NPCType<CaveGolem>()];
            case 12:
                return [NPCType<CloudSlime>()];
            case 13:
                return [NPCType<ConjurerSkeleton>()];
            case 14:
                return [NPCType<CoreBug>()];
            case 15:
                return [NPCType<CoreSlime>()];
            case 16:
                return [NPCType<CorruptedBicholmere>()];
            case 17:
                return [NPCType<Crimer>()];
            case 18:
                return [NPCType<CrimsonBicholmere>()];
            case 19:
                return [NPCType<DeepwaterVilefish>()];
            case 20:
                return [NPCType<Deimos>()];
            case 21:
                return [NPCType<DevilishTortoise>()];
            case 22:
                return [NPCType<Dinictis>()];
            case 23:
                return [NPCType<DragonSkull>()];
            case 24:
                return [NPCType<Dranix>()];
            case 25:
                return [NPCType<DreadBeetle>()];
            case 26:
                return [NPCType<DungeonKeeper>()];
            case 27:
                return [NPCType<ElderObserver>()];
            case 28:
                return [NPCType<EnragedBat>()];
            case 29: // EvolvedZombie
            case 30: // EvolvedZombie2
            case 31: // EvolvedZombier3
                return [NPCType<EvolvedZombie>(), NPCType<EvolvedZombie2>(), NPCType<EvolvedZombie3>()];
            case 32: // FallenWarrior1
            case 33: // FallenWarrior2
            case 34: // FallenWarrior3
                return [NPCType<FallenWarrior1>(), NPCType<FallenWarrior2>(), NPCType<FallenWarrior3>()];
            case 35:
                return [NPCType<FatFlinx>()];
            case 36:
                return [NPCType<FireBeetle>()];
            case 37:
                return [NPCType<Flayer>()];
            case 38:
                return [NPCType<FrostBeetle>()];
            case 39:
                return [NPCType<GeneralSnowman>()];
            case 40:
                return [NPCType<GhostKnight>()];
            case 41:
                return [NPCType<GiantCrab>()];
            case 42:
                return [NPCType<GiantGastropod>()];
            case 43:
                return [NPCType<GiantMeteorHead>()];
            case 44:
                return [NPCType<Hallower>()];
            case 45:
                return [NPCType<HallowSlimer>()];
            case 46:
                return [NPCType<HeadlessZombie>()];
            case 47:
                return [NPCType<HeavyZombie>()];
            case 48:
                return [NPCType<HiveHeadZombie>()];
            case 49:
                return [NPCType<IceBlazer>()];
            case 50:
                return [NPCType<IronGiant>()];
            case 51:
                return [NPCType<Leprechaun>()];
            case 52:
                return [NPCType<MechanicalFirefly>()];
            case 53:
                return [NPCType<MeteoriteGolem>()];
            case 54:
                return [NPCType<MightyNimbus>()];
            case 55:
                return [NPCType<Minotaur>()];
            case 56:
                return [NPCType<MushroomCreature>()];
            case 57:
                return [NPCType<NightTerror>()];
            case 58:
                return [NPCType<Observer>()];
            case 59:
                return [NPCType<Orc>()];
            case 60:
                return [NPCType<OrcSkeleton>()];
            case 61:
                return [NPCType<OrcWarrior>()];
            case 62:
                return [NPCType<Parasprite>()];
            case 63:
                return [NPCType<Peepers>()];
            case 64:
                return [NPCType<Phantom>()];
            case 65:
                return [NPCType<PharaohCaster>()];
            case 66:
                return [NPCType<Phobos>()];
            case 67: // PossessedHornet 1
            case 68: // PossessedHornet 2
                return [NPCType<PossessedHornet1>(), NPCType<PossessedHornet2>()];
            case 69:
                return [NPCType<PossessedHound>()];
            case 70:
                return [NPCType<PyramidHead>()];
            case 71:
                return [NPCType<QuartzBeetle>()];
            case 72:
                return [NPCType<Rogue>()];
            case 73:
                return [NPCType<SandThing>()];
            case 74:
                return [NPCType<ShadowRipper>()];
            case 75:
                return [NPCType<SkeletonKnight>()];
            case 76:
                return [NPCType<ScaryBat>()];
            case 77:
                return [NPCType<Sighted>()];
            case 78:
                return [NPCType<SnowmanBomber>()];
            case 79:
                return [NPCType<SnowmanWarrior>()];
            case 80:
                return [NPCType<SquidZombie>()];
            case 81:
                return [NPCType<Skullker>()];
            case 82:
                return [NPCType<Snowcopter>()];
            case 83:
                return [NPCType<SpiderMan>()];
            case 84:
                return [NPCType<SupremePossessedArmor>()];
            case 85:
                return [NPCType<TheAxeman>()];
            case 86:
                return [NPCType<TheGirl>()];
            case 87:
            case 88:
            case 89:
                return [NPCType<Thief1>(), NPCType<Thief2>(), NPCType<Thief3>()];
            case 90:
                return [NPCType<TheThing>()];
            case 91:
                return [NPCType<TwilightBat>()];
            case 92:
            case 93:
            case 94:
            case 95:
                return [NPCType<UndeadWarrior1>(), NPCType<UndeadWarrior2>(), NPCType<UndeadWarrior3>(), NPCType<UndeadWarrior4>(),];
            case 96:
                return [NPCType<Zarprite>()];
            case 97:
                return [NPCType<Zarprute>()];
            case 98:
                return [NPCType<AncientCursedSkull>()];
            case 99:
                return [NPCType<ArchDemon>()];
            case 100:
                return [NPCType<BoneArcher>()];
            case 101:
                return [NPCType<BoneFlyer>()];
            case 102:
                return [NPCType<DarkDruid>()];
            case 103:
                return [NPCType<GraniteBeetle>()];
            case 104:
                return [NPCType<GraniteBowman>()];
            case 105:
                return [NPCType<AlphaWolf>()];
            case 106:
                return [NPCType<BetaWolf>()];
            case 107:
                return [NPCType<OmegaWolf>()];
            case 108:
                return [NPCType<Woody>()];
            default:
                return [-1];
        }
    }

    public enum StyleID
    {
        Abomination,
        Agloomination,
        ArmoredJellyfish,
        Atis,
        Banshe,
        HarpyWarrior,
        Bicholmere,
        Blazer,
        BloodmoonWarrior1,
        BloodmoonWarrior2,
        BloodmoonWarrior3,
        CaveGolem,
        CloudSlime,
        ConjurerSkeleton,
        CoreBug,
        CoreSlime,
        CorruptedBicholmere,
        Crimer,
        CrimsonBicholmere,
        DeepwaterVilefish,
        Deimos,
        DevilishTortoise,
        Dinictis,
        DragonSkull,
        Dranix,
        DreadBeetle,
        DungeonKeeper,
        ElderObserver,
        EnragedBat,
        EvolvedZombie,
        EvolvedZombie2,
        EvolvedZombie3,
        FallenWarrior1,
        FallenWarrior2,
        FallenWarrior3,
        FatFlinx,
        FireBeetle,
        Flayer,
        FrostBeetle,
        GeneralSnowman,
        GhostKnight,
        GiantCrab,
        GiantGastropod,
        GiantMeteorHead,
        Hallower,
        HallowSlimer,
        HeadlessZombie,
        HeavyZombie,
        HiveHeadZombie,
        IceBlazer,
        IronGiant,
        Leprechaun,
        MechanicalFirefly,
        MeteoriteGolem,
        MightyNimbus,
        Minotaur,
        MushroomCreature,
        NightTerror,
        Observer,
        Orc,
        OrcSkeleton,
        OrcWarrior,
        Parasprite,
        Peepers,
        Phantom,
        PharaohCaster,
        Phobos,
        PossessedHornet1,
        PossessedHornet2,
        PossessedHound,
        PyramidHead,
        QuartzBeetle,
        Rogue,
        SandThing,
        ShadowRipper,
        SkeletonKnight,
        ScaryBat,
        Sighted,
        SnowmanBomber,
        SnowmanWarrior,
        SquidZombie,
        Skullker,
        Snowcopter,
        SpiderMan,
        SupremePossessedArmor,
        TheAxeman,
        TheGirl,
        Thief1,
        Thief2,
        Thief3,
        TheThing,
        TwilightBat,
        UndeadWarrior1,
        UndeadWarrior2,
        UndeadWarrior3,
        UndeadWarrior4,
        Zarprite,
        Zarprute,
        AncientCursedSkull,
        ArchDemon,
        BoneArcher,
        BoneFlyer,
        DarkDruid,
        GraniteBeetle,
        GraniteBowman,
        AlphaWolf,
        BetaWolf,
        OmegaWolf,
        Woody
    }
}