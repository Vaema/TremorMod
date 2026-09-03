using System;
using Terraria.ModLoader;
using TremorMod.Content.Biomes.Ice;
using TremorMod.Content.Biomes.Ruins.Tiles;

namespace TremorMod.Utilities;

public class BiomeTileCounterSystem : ModSystem
{
    public static int RuinAltar = 0;
    public static int IceBlock = 0;

    public override void ResetNearbyTileEffects()
    {
        RuinAltar = 0;
        IceBlock = 0;
    }

    public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
    {
        RuinAltar = tileCounts[ModContent.TileType<RuinAltar>()];
        IceBlock = tileCounts[ModContent.TileType<IceBlock>()];
    }
}
