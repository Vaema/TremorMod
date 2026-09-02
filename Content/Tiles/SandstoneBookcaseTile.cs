using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TremorMod.Content.Tiles;

	public class SandstoneBookcaseTile : ModTile
	{
    public override void SetStaticDefaults()
    {
        // Íàñòðîéêè ïëèòêè
        Main.tileSolidTop[Type] = true;
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileTable[Type] = true;
        Main.tileLavaDeath[Type] = true;

        // Êîíôèãóðàöèÿ TileObjectData
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4); // Ðàçìåð 3x4
        TileObjectData.newTile.CoordinateHeights = [16, 16, 16, 16]; // Âûñîòà êàæäîé ñòðîêè â ïèêñåëÿõ
        TileObjectData.addTile(Type);

        // Óêàçàíèå, ÷òî ýòà ïëèòêà àíàëîãè÷íà êíèæíîìó øêàôó
        AdjTiles = [TileID.Bookcases];

        // Êàðòà
        AddMapEntry(new Color(233, 211, 123), CreateMapEntryName());
    }
}