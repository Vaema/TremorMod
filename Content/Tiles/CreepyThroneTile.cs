using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ObjectData;
using Terraria.ModLoader;
using Terraria.ID;

namespace TremorMod.Content.Tiles;

	public class CreepyThroneTile : ModTile
{
    public override void SetStaticDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
        TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16];
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 36;
        TileObjectData.addTile(Type);
        DustType = DustID.WoodFurniture;
	        AddMapEntry(new Color(120, 85, 60), CreateMapEntryName());
    }
}