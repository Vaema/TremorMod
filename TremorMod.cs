using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using TremorMod.Content.Biomes.Ice.Dungeon;
using TremorMod.Content.Biomes.Ice.Items.Furniture;
using TremorMod.Content.Event;
using TremorMod.Content.Tiles;
using TremorMod.Utilities;

namespace TremorMod;

public class TremorMod : Mod
{
    public static DamageClass alchemicalDamage;

    public static Texture2D Ice3;
    public static bool HasGeneratedLunarRootTile;
    public static bool HasGeneratedCometiteOre;
    public static TremorMod Instance;
    public static bool DungeonBlock;
    public static bool IceChest;

    public override void Load()
    {
        if (!Main.dedServ)
            ModContent.GetInstance<CyberWrathUISystem>().Load();

        ModContent.TileType<LunarRootTile>();
        ModContent.TileType<CometiteOreTile>();
        ModContent.TileType<HardCometiteOreTile>();
        ModContent.TileType<DungeonBlock>();
        ModContent.TileType<IceChest>();

        HasGeneratedLunarRootTile = false;
        HasGeneratedCometiteOre = false;
        alchemicalDamage = ModContent.GetInstance<AlchemicalClass>();
    }

    public TremorMod()
    {
        Instance = this;
    }
}
